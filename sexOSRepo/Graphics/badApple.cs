using Cosmos.System;
using Cosmos.System.FileSystem;
using Cosmos.System.Graphics;
using sexOSKernel.Commands;
using System;
using System.Drawing;
using Sys = Cosmos.System;
using Console = System.Console;
using System.Collections.Generic;
using System.Net.Http.Headers;
using IL2CPU.API.Attribs;

namespace sexOSKernel.Graphics
{
    public class badApple
    {
        public bool ShouldExitApple { get; private set; } = false;
        public static Canvas canvas;
        private Pen pen;
        int index = 0;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_198.bmp")] public static byte[] test_image;
        public badApple() //constructor
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);

            this.pen = new Pen(Color.Black);
            //displayRandPoints(1022, 766);
        }

        private void displayRandPoints(int height, int width)
        {
            Random rand = new Random();
            for (int i = 3; i < height; i++)
            {
                for (int j = 3; j < width; j++)
                {
                    pen.Color = Color.FromArgb(255, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    canvas.DrawPoint(pen, new Sys.Graphics.Point(i, j));
                }
            }
        }
        public void handleAppleInputs()
        {
            CheckKeypress();
            canvas.Display();
        }
        private void CheckKeypress()
        {
            if (KeyboardManager.KeyAvailable)
            {
                if (KeyboardManager.ReadKey().Key == ConsoleKeyEx.Enter)
                {
                    displayRandPoints(1022, 766);
                }
                else if (KeyboardManager.ReadKey().Key == ConsoleKeyEx.Escape)
                {
                    ShouldExitApple = true;
                }
                else if(KeyboardManager.ReadKey().Key == ConsoleKeyEx.Tab)
                {
                    DrawImageFromBytes(test_image, 100, 100);
                }
            }
        }
        private void DrawImageFromBytes(byte[] imageData, int width, int height)
        {
            if (imageData.Length < width * height)
            {
                throw new ArgumentException("Image data does not have enough pixels for the specified width and height.");
            }

            pen.Color = Color.Black; // Set pen color once if all drawn pixels are black

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = y * width + x;
                    if (imageData[index] == 0) // Assuming '0' represents black pixels
                    {
                        canvas.DrawPoint(pen, new Sys.Graphics.Point(x, y));
                    }
                    // Skip drawing white pixels assuming the canvas is already cleared to white
                }
            }
            canvas.Display(); // Refresh the canvas to display the drawn image
        }




    }
}