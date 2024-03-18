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
using System.IO;
using System.Reflection;

namespace sexOSKernel.Graphics
{
    public class badApple
    {
        public bool ShouldExitApple { get; private set; } = false;
        public static Canvas canvas;
        private Pen pen;
        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.frame_110.txt")] public static byte[] test_image;
        public badApple() //constructor
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);
            this.pen = new Pen(Color.Black);
        }

        private string ReadTextFromResource(string resourceName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
        private void displayRandPoints(int height, int width)
        {
            Random rand = new Random();
            for (int i = 2; i < height; i++)
            {
                for (int j = 2; j < width; j++)
                {
                    pen.Color = Color.FromArgb(255, rand.Next(0, 255), rand.Next(0, 255), rand.Next(0, 255));
                    canvas.DrawPoint(pen, new Sys.Graphics.Point(i, j));
                }
            }
        }
        public void handleAppleInputs()
        {
            CheckKeypress();
            //canvas.Display();
        }
        private void CheckKeypress()
        {
            if (KeyboardManager.KeyAvailable)
            {
                if (KeyboardManager.ReadKey().Key == ConsoleKeyEx.Enter)
                {
                    displayRandPoints(1022, 766);
                    canvas.Display();
                }
                else if (KeyboardManager.ReadKey().Key == ConsoleKeyEx.Escape)
                {
                    ShouldExitApple = true;
                }
                else if(KeyboardManager.ReadKey().Key == ConsoleKeyEx.Tab)
                {
                   DrawImageFromBytes(test_image, 800, 603);
                }
            }
        }
        Pen whitePen = new Pen(Color.White);
        private void DrawImageFromBytes(byte[] imageData, int width, int height)
        {
            int index = 0; // Index for the position in the imageData array
            for (int y = 0; y < height && index < imageData.Length; y++)
            {
                for (int x = 0; x < width && index < imageData.Length; x++)
                {
                    // Check if we've encountered a newline character. If so, skip it.
                    while (imageData[index] == 10 || imageData[index] == 13)
                    {
                        index++; // Skip the newline or carriage return characters
                    }

                    // Draw black pixel for '0'
                    if (imageData[index] == 48) // ASCII '0'
                    {
                        canvas.DrawPoint(pen, x, y); // Black pixel
                    }
                    // Draw white pixel for '1'
                    else if (imageData[index] == 49) // ASCII '1'
                    {
                        canvas.DrawPoint(whitePen, x, y); // White pixel
                    }
                    // Increment index after drawing
                    if(index + 1 < imageData.Length)
                    index++;
                }
                canvas.Display(); // Refresh the canvas to display the drawn image once all pixels are drawn
            }
            

        }
    }




}
