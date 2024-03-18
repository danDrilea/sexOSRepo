using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
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
        public int termopanX, termopanY;
        public bool isTermopanOpen = true;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.raton_1024x768.bmp")] public static byte[] test_image;
        public static Bitmap image_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background

        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.cursor.bmp")] public static byte[] cursor_image;
        public static Bitmap cursor_bitmap = new Bitmap(32, 32, ColorDepth.ColorDepth32);//cursor

        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.termopan.bmp")] public static byte[] termopan_image;
        public static Bitmap termopan_bitmap = new Bitmap(32, 32, ColorDepth.ColorDepth32);//termopan
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
            termopan_bitmap = new Bitmap(termopan_image, ColorOrder.BGR);
        }

        public void handleImageGUIinput()
        {
            // Ensure the background is redrawn every frame
            canvas.DrawImage(image_bitmap, 0, 0);

            // Assuming termopanX and termopanY are defined elsewhere in your class
            if (isTermopanOpen)
            canvas.DrawImage(termopan_bitmap, termopanX, termopanY);

            // Clamp MouseManager.X and MouseManager.Y within the screen boundaries
            int mouseX = Math.Clamp((int)MouseManager.X, 0, (int)(MouseManager.ScreenWidth - cursor_bitmap.Width + 15));
            int mouseY = Math.Clamp((int)MouseManager.Y, 0, (int)(MouseManager.ScreenHeight - cursor_bitmap.Height + 15));

            // Draw the mouse cursor at the clamped position
            canvas.DrawImageAlpha(cursor_bitmap, mouseX, mouseY);

            // Check if the mouse cursor intersects with the termopan
            if (isTermopanOpen && (mouseX < termopanX + termopan_bitmap.Width && mouseX + cursor_bitmap.Width > termopanX && mouseY < termopanY + termopan_bitmap.Height && mouseY + cursor_bitmap.Height > termopanY))
            {
                // Intersection detected
                
                if (MouseManager.MouseState == MouseState.Right)
                {
                    termopanX = mouseX;
                    termopanY = mouseY;
                }
                
                int cornerTolerance = 32; // Pixels area around the corner where the mouse is considered to intersect with the corner
                int topRightCornerX = termopanX + (int)termopan_bitmap.Width - cornerTolerance; // X coordinate of the top-right corner area
                int topRightCornerY = termopanY; // Y coordinate of the top-right corner
                // Check if the mouse position is within the corner tolerance area
                if (mouseX >= topRightCornerX && mouseX <= termopanX + termopan_bitmap.Width && mouseY >= topRightCornerY && mouseY <= topRightCornerY + cornerTolerance)
                {
                    if (MouseManager.MouseState == MouseState.Left)
                    {
                        System.Console.Beep();
                        isTermopanOpen = false;
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
                    isTermopanOpen = true;
                }
            }

            // Display the updated canvas
            Heap.Collect();
            canvas.Display();
        }

    }
}
