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
using Cosmos.Core.Memory;

namespace sexOSKernel.Graphics
{
    public class badApple
    {
        public bool ShouldExitApple { get; private set; } = false;
        public static Canvas canvas;
        private Pen pen;

        public badApple() //constructor
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);

            this.pen = new Pen(Color.Black);

            // Refresh the canvas to display the updated state
            canvas.Display();
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
            }
        }
    }
}
