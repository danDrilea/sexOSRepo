using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace sexOSRepo.Graphics
{
    public class desktop
    {
        public bool shouldExitdesktop { get; private set; } = false;
        public int open_Termopane_Index = -1;

        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.raton_1024x768.bmp")] public static byte[] test_image;
        public static Bitmap image_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background


        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.cursor.bmp")] public static byte[] cursor_image;
        public static Bitmap cursor_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background

        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.TASKBAR.bmp")] public static byte[] taskbar_image;
        public static Bitmap taskbar_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//taskbar
        public List<Termopan> termopane = new List<Termopan>();
        public static Canvas canvas;
        public desktop()
        {
            MouseManager.ScreenWidth = 1024;
            MouseManager.ScreenHeight = 768;
            MouseManager.X = 1024 / 2;
            MouseManager.Y = 768 / 2;
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);
            image_bitmap = new Bitmap(test_image, ColorOrder.BGR);
            cursor_bitmap = new Bitmap(cursor_image, ColorOrder.BGR);
            taskbar_bitmap = new Bitmap(taskbar_image, ColorOrder.BGR);

        }
        public void DrawText(string text, int x, int y, Color color)
        {
            // Check if the Canvas supports DrawString directly
            if (canvas != null)
            {
                // Set the font and color for the text
                // Note: The actual implementation might differ based on the Cosmos OS version and your project setup
                // var font =font(; // Example font, adjust as necessary
                var font = Cosmos.System.Graphics.Fonts.PCScreenFont.Default;
                canvas.DrawString(text, font, new Pen(color), x, y);
            }
        }
        public void handledesktopinput()
        {
            // Ensure the background is redrawn every frame
            canvas.DrawImage(image_bitmap, 0, 0);
            var currentTime = DateTime.Now; // Note: This gets the system time; ensure your system clock is set correctly.
            string timeString = currentTime.ToString("HH:mm:ss");//HOUR STRING!!
            string dateString = currentTime.ToString("yyyy-MM-dd"); // Date string
            canvas.DrawImageAlpha(taskbar_bitmap, 0, 733);//768 - cv
            DrawText(timeString, 950, 737, Color.Black);//ora!!
            DrawText(dateString, 940, 752, Color.Black);//data
            int mouseX = Math.Clamp((int)MouseManager.X, 0, (int)(MouseManager.ScreenWidth - cursor_bitmap.Width + 15));
            int mouseY = Math.Clamp((int)MouseManager.Y, 0, (int)(MouseManager.ScreenHeight - cursor_bitmap.Height + 15));
            // Assuming termopanX and termopanY are defined elsewhere in your class


            HandleTermopanMovement(mouseX, mouseY);
            canvas.DrawImageAlpha(cursor_bitmap, mouseX, mouseY);

            // Keyboard handling
            if (KeyboardManager.KeyAvailable)
            {
                var key = KeyboardManager.ReadKey();
                if (key.Key == ConsoleKeyEx.Escape)
                {
                    shouldExitdesktop = true;
                }
                else if (key.Key == ConsoleKeyEx.N)
                {
                    open_Termopane_Index++;
                    termopane.Add(new Termopan());
                    termopane[open_Termopane_Index].Open();
                }
            }

            Heap.Collect();
            canvas.Display();

        }

        public void HandleTermopanMovement(int mouseX, int mouseY)
        {
            Termopan topmostInteractedTermopan = null;

            // Iterate through termopane in reverse order to check the topmost termopan first
            for (int i = termopane.Count - 1; i >= 0; i--)
            {
                Termopan t = termopane[i];
                if (t.IsOpen() && t.HandleInteraction(mouseX, mouseY, MouseManager.MouseState))
                {
                    // If an interaction is detected, break the loop as we only want to interact with the topmost termopan
                    topmostInteractedTermopan = t;
                    break;
                }
            }

            // If a termopan was interacted with, move it to the end of the list to make it the topmost
            if (topmostInteractedTermopan != null)
            {
                termopane.Remove(topmostInteractedTermopan);
                termopane.Add(topmostInteractedTermopan);

                // Redraw or update the GUI as necessary to reflect the new z-index
                // This might involve reordering how termopans are drawn or updating the canvas
            }

            // Optionally, redraw all Termopans in their new order to reflect the z-index change
            // This could be placed here or handled separately depending on your rendering logic
            foreach (Termopan t in termopane)
            {
                if (t.IsOpen())
                {
                    // Draw the termopan on the canvas
                    canvas.DrawImage(Termopan.bitmap, t.GetX(), t.GetY());
                }
            }
        }


    }
}
