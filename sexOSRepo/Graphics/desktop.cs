using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using Sys = Cosmos.System;
namespace sexOSRepo.Graphics
{
    public class desktop
    {
        public bool shouldExitdesktop { get; private set; } = false;
        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.raton_1024x768.bmp")] public static byte[] test_image;
        public static Bitmap image_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background


        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.cursor.bmp")] public static byte[] cursor_image;
        public static Bitmap cursor_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background

        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.TASKBAR.bmp")] public static byte[] taskbar_image;
        public static Bitmap taskbar_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//taskbar

        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.start-button.bmp")] public static byte[] start_image;
        public static Bitmap start_bitmap = new Bitmap(64, 64, ColorDepth.ColorDepth32);//start btn
        public static desktop Instance { get; private set; }

        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.start-button.bmp")] public static byte[] taskbar_icon_image;
        private long lastClickTime = 0; // Timestamp of the last click in ticks
        private readonly long clickCooldown = TimeSpan.FromMilliseconds(100).Ticks; // cooldown for click
        public static Bitmap taskbar_icon_bitmap = new Bitmap(32, 32, ColorDepth.ColorDepth32);//start btn
        private List<Sys.FileSystem.Listing.DirectoryEntry> directoryListing;
        private int startY = 20; // The Y position where the directory listing will start on the canvas
        public List<Termopan> termopane = new List<Termopan>();
        public List<DesktopIcon> desktopIcons = new List<DesktopIcon>();
        private bool showDirectoryListing = false; // Toggle for showing the directory listing
        public static Canvas canvas;
        public bool textUpdateRequired = false;
        public desktop()
        {
            Heap.Collect();
            Instance = this;
            MouseManager.ScreenWidth = 1024;
            MouseManager.ScreenHeight = 768;
            MouseManager.X = 1024 / 2;
            MouseManager.Y = 768 / 2;
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);
            image_bitmap = new Bitmap(test_image, ColorOrder.BGR);
            cursor_bitmap = new Bitmap(cursor_image, ColorOrder.BGR);
            taskbar_bitmap = new Bitmap(taskbar_image, ColorOrder.BGR);
            start_bitmap = new Bitmap(start_image, ColorOrder.BGR);

        }
        public void DrawText(string text, int x, int y, Color color)
        {
            var font = Cosmos.System.Graphics.Fonts.PCScreenFont.Default;
            int maxWidth = 300; // The maximum width of the Termopan for text
            int charWidth = font.Width; // Width of a character; this is a simplification
            int charsPerLine = maxWidth / charWidth; // Max characters per line

            // Split the text into lines
            List<string> lines = new List<string>();
            for (int i = 0; i < text.Length; i += charsPerLine)
            {
                lines.Add(text.Substring(i, Math.Min(charsPerLine, text.Length - i)));
            }

            // Draw each line
            int lineHeight = font.Height; // Height of a line; this is a simplification
            for (int lineIndex = 0; lineIndex < lines.Count; lineIndex++)
            {
                canvas.DrawString(lines[lineIndex], font, new Pen(color), x, y + (lineHeight * lineIndex));
            }
        }
        public void handledesktopinput()
        {
            canvas.DrawImage(image_bitmap, 0, 0);
            var currentTime = DateTime.Now;
            string timeString = currentTime.ToString("HH:mm:ss");
            string dateString = currentTime.ToString("yyyy-MM-dd");
            canvas.DrawImageAlpha(taskbar_bitmap, 0, 733);
            canvas.DrawImageAlpha(start_bitmap, 0, 733);

            DrawText(timeString, 950, 737, Color.Black);
            DrawText(dateString, 940, 752, Color.Black);
            int mouseX = Math.Clamp((int)MouseManager.X, 0, (int)(MouseManager.ScreenWidth - cursor_bitmap.Width + 15));
            int mouseY = Math.Clamp((int)MouseManager.Y, 0, (int)(MouseManager.ScreenHeight - cursor_bitmap.Height + 15));


            if (KeyboardManager.KeyAvailable)
            {
                var key = KeyboardManager.ReadKey();
                if (key.Key == ConsoleKeyEx.Escape)
                {
                    shouldExitdesktop = true;
                    Heap.Collect();
                }
                /*
                else if (key.Key == ConsoleKeyEx.N)
                {
                    Termopan newTermopan = new Termopan();
                    termopane.Add(newTermopan);
                    newTermopan.Open();
                    AddTaskbarIconForTermopan(newTermopan);
                }*/
                else if (key.Key == ConsoleKeyEx.Home)
                {
                    // Toggle the directory listing visibility
                    showDirectoryListing = !showDirectoryListing;

                    // If turning on, refresh the listing
                    if (showDirectoryListing)
                    {
                        ListDirectoryContents(sexOSKernel.Commands.File.currentDirectory);
                    }
                    else
                    {
                        // Clear the directory listing area if turning off
                        ClearDirectoryListingArea();
                    }

                }
            }

            // Handle clicks on desktop icons to restore minimized Termopans
            if (MouseManager.MouseState == MouseState.Left)
            {
                foreach (DesktopIcon icon in desktopIcons)
                {
                    if (icon.IsClicked((int)MouseManager.X, (int)MouseManager.Y))
                    {
                        if (icon.AssociatedTermopan.IsMinimized())
                        {
                            // Restore the Termopan
                            icon.AssociatedTermopan.Unminimize();
                        }
                        else
                        {
                            // Optionally minimize or bring to front here if needed
                        }
                        break; // Assuming one click can only interact with one icon
                    }
                }
            }
            ///FOR DIRECTORIES
            if (MouseManager.MouseState == MouseState.Left && showDirectoryListing)
            {
                int startX = 1024 - 200; // Assuming the listing area starts 200 pixels from the right edge
                long currentTime_click = DateTime.Now.Ticks; // Get current time in ticks
                // Check if the click is within the listing area
                if (currentTime_click - lastClickTime > clickCooldown)
                {
                    if (mouseX >= startX)
                    {
                        lastClickTime = currentTime_click;
                        // Calculate which index was clicked, taking startY as the initial Y position
                        int clickedIndex = (mouseY - startY) / 20; // Assuming 20 pixels per entry height

                        if (clickedIndex == 0) // The back button is always the first entry
                        {
                            // Navigate up a directory, but prevent going above the root
                            if (sexOSKernel.Commands.File.currentDirectory != @"0:\")
                            {
                                string parentDirectory = Path.GetDirectoryName(sexOSKernel.Commands.File.currentDirectory.TrimEnd('\\'));
                                // Ensure we do not go up past the root directory
                                sexOSKernel.Commands.File.currentDirectory = parentDirectory == null ? @"0:\" : parentDirectory + @"\";
                                ListDirectoryContents(sexOSKernel.Commands.File.currentDirectory);
                            }
                        }
                        else
                        {
                            clickedIndex -= 1; // Adjust index since the first entry is the back button

                            // Ensure the click is on a valid directory entry
                            if (clickedIndex >= 0 && clickedIndex < directoryListing.Count)
                            {
                                var clickedEntry = directoryListing[clickedIndex];
                                if (clickedEntry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                                {
                                    // Change the current directory to the clicked one and list its contents
                                    sexOSKernel.Commands.File.currentDirectory = clickedEntry.mFullPath;
                                    ListDirectoryContents(sexOSKernel.Commands.File.currentDirectory);
                                }
                                else if (clickedEntry.mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.File)
                                {
                                    // Read the content of the file
                                    string fileContent = ReadFileContent(clickedEntry.mFullPath);

                                    // Calculate where to place the new Termopan based on existing ones or your specific layout logic
                                    int newTermopanX = 100; // Example X coordinate
                                    int newTermopanY = 100; // Example Y coordinate

                                    // Create a new Termopan at the specified position
                                    Termopan fileTermopan = new Termopan(newTermopanX, newTermopanY);
                                    fileTermopan.Content = fileContent; // Assuming you have a Content property or similar to set
                                    fileTermopan.Open(); // Open the Termopan, making it ready for display
                                    fileTermopan.OpenFile(clickedEntry.mFullPath, fileContent);
                                    termopane.Add(fileTermopan); // Add the new Termopan to your list of Termopans to be displayed
                                    AddTaskbarIconForTermopan(fileTermopan);
                                }
                            }
                        }
                    }
                }
            }
            foreach (DesktopIcon icon in desktopIcons)
            {
                icon.Draw(canvas);
            }
            ListDirectoryContents(sexOSKernel.Commands.File.currentDirectory); // Assuming File.currentDirectory is root
            DrawTaskbar();
            DrawUnminimizedTermopans();
            HandleTermopanMovement(mouseX, mouseY);
            canvas.DrawImageAlpha(cursor_bitmap, mouseX, mouseY);
            canvas.Display();
            Heap.Collect();
        }


        public void DrawUnminimizedTermopans()
        {

            foreach (Termopan t in termopane)
            {
                if (!t.IsMinimized() && t.IsOpen())
                {
                    canvas.DrawImage(Termopan.bitmap, t.GetX(), t.GetY());
                    if (t.IsFocused)
                    {
                        // Only draw the focused text and cursor if required
                        DrawText(t.Content + "|", t.GetX() + 10, t.GetY() + 50, Color.Black); // Append a cursor at the end of the text
                        if (KeyboardManager.KeyAvailable)
                        {
                            var key = KeyboardManager.ReadKey();
                            t.HandleKeyboardInput(key.Key);
                        }

                    }
                    else
                    {
                        DrawText(t.Content, t.GetX() + 10, t.GetY() + 50, Color.Black);
                    }

                }
                else if (!t.IsOpen())
                {
                    RemoveTaskbarIconForTermopan(t);
                }
            }
        }

        private string ReadFileContent(string filePath)
        {
            try
            {
                var fileStream = Sys.FileSystem.VFS.VFSManager.GetFile(filePath).GetFileStream();
                if (fileStream.CanRead)
                {
                    byte[] bytes = new byte[fileStream.Length];
                    fileStream.Read(bytes, 0, bytes.Length);
                    return System.Text.Encoding.ASCII.GetString(bytes);
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions or log them
                System.Console.WriteLine($"Error reading file: {ex.Message}");
            }
            return "Could not read file.";
        }
        public void SaveFileContent(string filePath, string content)
        {
            try
            {
                // Adjust this path as necessary. Here, it's assumed FilePath is a full path.
                using (var fileStream = Sys.FileSystem.VFS.VFSManager.GetFile(filePath).GetFileStream())
                {
                    if (fileStream.CanWrite)
                    {
                        byte[] bytes = System.Text.Encoding.ASCII.GetBytes(content);
                        fileStream.SetLength(bytes.Length); // Adjust the file size to match the content length
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error writing file: {ex.Message}");
            }
        }

        public void RemoveTaskbarIconForTermopan(Termopan termopan)
        {
            // Find the desktop icon associated with the Termopan to be removed
            var iconToRemove = desktopIcons.FirstOrDefault(icon => icon.AssociatedTermopan == termopan);
            if (iconToRemove != null)
            {
                // Remove the found icon from the list
                desktopIcons.Remove(iconToRemove);
                RepositionTaskbarIcons();
            }
        }

        public void RepositionTaskbarIcons()
        {
            int startingX = 64; // Initial position for the first icon
            int gap = 5; // Gap between icons
            int taskbarHeight = 768 - 733; // Example calculation
            int iconY = 733 + (taskbarHeight - 32) / 2; // Center icon vertically within the taskbar

            for (int i = 0; i < desktopIcons.Count; i++)
            {
                int newX = startingX + i * (32 + gap); // Assuming each icon is 32px wide
                DesktopIcon icon = desktopIcons[i];
                icon.X = newX;
                icon.Y = iconY; // Adjust Y position for vertical centering
            }
        }

        public void HandleTermopanMovement(int mouseX, int mouseY)
        {
            Termopan topmostInteractedTermopan = null;

            for (int i = termopane.Count - 1; i >= 0; i--)
            {
                Termopan t = termopane[i];
                if (t.IsOpen() && t.HandleInteraction(mouseX, mouseY, MouseManager.MouseState))
                {
                    topmostInteractedTermopan = t;
                    break;
                }
            }

            if (topmostInteractedTermopan != null)
            {
                termopane.Remove(topmostInteractedTermopan);
                termopane.Add(topmostInteractedTermopan);
            }

            // If a termopan was interacted with, move it to the end of the list to make it the topmost
            if (topmostInteractedTermopan != null)
            {
                termopane.Remove(topmostInteractedTermopan);
                termopane.Add(topmostInteractedTermopan);
            }
        }


        private void AddTaskbarIconForTermopan(Termopan termopan)
        {
            int iconX = 64 + (desktopIcons.Count * (32 + 5)); // Calculate new icon position based on existing icons
            int taskbarHeight = 768 - 733; // Example calculation, adjust based on your taskbar's actual height
            int iconY = 733 + (taskbarHeight - 32) / 2; // Center icon vertically within the taskbar

            DesktopIcon newIcon = new DesktopIcon(iconX, iconY, taskbar_icon_bitmap, termopan);
            desktopIcons.Add(newIcon);
        }

        public void DrawTaskbar()
        {
            int iconPositionX = 64; // Starting position for icons
            int taskbarHeight = 768 - 733; // Adjust based on your taskbar's actual height
            foreach (DesktopIcon icon in desktopIcons)
            {
                if (icon.AssociatedTermopan.IsOpen())
                {
                    int iconY = 733 + (taskbarHeight - 32) / 2; // Center icon vertically within the taskbar
                    canvas.DrawImage(icon.Image, iconPositionX, iconY);
                    iconPositionX += 32 + 5; // Increment for next icon
                }
            }
        }
        public void ListDirectoryContents(string directoryPath)
        {
            if (!showDirectoryListing) return;

            int startX = 1024 - 200; // Adjust as necessary
            startY = 20; // Reset startY to 20 each time you list the directory contents

            ClearDirectoryListingArea();

            // Update the directoryListing with the contents of the new directory
            directoryListing = Sys.FileSystem.VFS.VFSManager.GetDirectoryListing(directoryPath).ToList();

            // Draw the back button
            DrawText("<- Back", startX, startY, Color.Red);

            // Increment startY for the first file/directory entry
            int fileEntryStartY = startY + 20;

            for (int i = 0; i < directoryListing.Count; i++)
            {
                string entryText = directoryListing[i].mName;
                if (directoryListing[i].mEntryType == Sys.FileSystem.Listing.DirectoryEntryTypeEnum.Directory)
                {
                    entryText += " (D)"; // Append (D) to directory names
                }
                DrawText(entryText, startX, fileEntryStartY + (i * 20), Color.White); // Increment Y by 20 for each entry
            }
        }
        public void ClearDirectoryListingArea()
        {
            int width = 200; // Match this to the width used in ListDirectoryContents
            int height = 250; // Full height of the canvas
            int startX = 1024 - width;
            int startY = 0;
            // Clear the directory listing area
            canvas.DrawFilledRectangle(new Pen(Color.Black), startX, startY, width, height);
        }

    }
}