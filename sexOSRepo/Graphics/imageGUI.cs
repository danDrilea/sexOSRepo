using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using GraphicPoint = Cosmos.System.Graphics.Point;

namespace sexOSRepo.Graphics
{
    public class imageGUI
    {
        public bool shouldExitImageGUI { get; private set; } = false;

        Termopan termopan;

        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.raton_1024x768.bmp")] public static byte[] test_image;
        public static Bitmap image_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background


        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.cursor.bmp")] public static byte[] cursor_image;
        public static Bitmap cursor_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background

        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.TASKBAR.bmp")] public static byte[] taskbar_image;
        public static Bitmap taskbar_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//taskbar

        public static Canvas canvas;
        public imageGUI() 
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

            termopan = new Termopan();
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
        public void handleImageGUIinput()
        {
            // Ensure the background is redrawn every frame
            canvas.DrawImage(image_bitmap, 0, 0);
            var currentTime = DateTime.Now; // Note: This gets the system time; ensure your system clock is set correctly.
            string timeString = currentTime.ToString("HH:mm:ss");//HOUR STRING!!
            string dateString = currentTime.ToString("yyyy-MM-dd"); // Date string
            canvas.DrawImageAlpha(taskbar_bitmap, 0, 733);//768 - cv
            DrawText(timeString, 950, 737, Color.Black);//ora!!
            DrawText(dateString, 940, 752, Color.Black);//data
            // Assuming termopanX and termopanY are defined elsewhere in your class
            if (termopan.isOpen())
            canvas.DrawImage(Termopan.bitmap, termopan.getX(), termopan.getY());

            // Clamp MouseManager.X and MouseManager.Y within the screen boundaries
            int mouseX = Math.Clamp((int)MouseManager.X, 0, (int)(MouseManager.ScreenWidth - cursor_bitmap.Width + 15));
            int mouseY = Math.Clamp((int)MouseManager.Y, 0, (int)(MouseManager.ScreenHeight - cursor_bitmap.Height + 15));

            // Draw the mouse cursor at the clamped position
            canvas.DrawImageAlpha(cursor_bitmap, mouseX, mouseY);

            // Check if the mouse cursor intersects with the termopan
            if(termopan.isOpen() && (mouseX < termopan.getX() + Termopan.bitmap.Width && mouseX + cursor_bitmap.Width > termopan.getX() && mouseY < termopan.getY() + Termopan.bitmap.Height && mouseY + cursor_bitmap.Height > termopan.getY()))
            {
                // Intersection detected
                if (MouseManager.MouseState == MouseState.Right)
                {
                    // Calculate the new intended position for termopan
                    int intendedX = mouseX - (int)(Termopan.bitmap.Width / 2);
                    int intendedY = mouseY - (int)(Termopan.bitmap.Height / 2);

                    // Clamp the new position to ensure termopan stays within screen boundaries
                    int clampedX = (int)(Math.Clamp(intendedX, 0, MouseManager.ScreenWidth - Termopan.bitmap.Width));
                    int clampedY = (int)(Math.Clamp(intendedY, 0, MouseManager.ScreenHeight - Termopan.bitmap.Height));

                    // Set the clamped position
                    termopan.setPos(clampedX, clampedY);
                }
                int cornerTolerance = 32; // Pixels area around the corner where the mouse is considered to intersect with the corner
                int topRightCornerX = termopan.getX() + (int)Termopan.bitmap.Width - cornerTolerance; // X coordinate of the top-right corner area
                int topRightCornerY = termopan.getY(); // Y coordinate of the top-right corner
                // Check if the mouse position is within the corner tolerance area
                if (mouseX >= topRightCornerX && mouseX <= termopan.getX() + Termopan.bitmap.Width && mouseY >= topRightCornerY && mouseY <= topRightCornerY + cornerTolerance)
                {
                    if (MouseManager.MouseState == MouseState.Left)
                    {
                        System.Console.Beep();
                        termopan.close();
                    }
                    
                }
                else if (MouseManager.MouseState == MouseState.Left)
                {
                    System.Console.Beep();
                }

            }

            // Keyboard handling
            if (KeyboardManager.KeyAvailable)
            {
                var key = KeyboardManager.ReadKey();
                if (key.Key == ConsoleKeyEx.Escape)
                {
                    shouldExitImageGUI = true;
                }
                else if(key.Key == ConsoleKeyEx.N)
                {
                    termopan.open();
                }
            }

            // Display the updated canvas
            Heap.Collect();
            canvas.Display();


        }

    }
}
