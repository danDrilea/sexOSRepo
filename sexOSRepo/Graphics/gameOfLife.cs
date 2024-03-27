using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using Console = System.Console;
using Sys = Cosmos.System;

namespace sexOSKernel.Graphics
{
    public class gameOfLife
    {
        public struct Pattern
        {
            public int x;
            public int y;
            public string RLE;

            public Pattern(int x, int y, string RLE)
            {
                this.x = x;
                this.y = y;
                this.RLE = RLE;
            }
        }
        public bool ShouldExitGameOfLife { get; private set; } = false;
        private bool isPaused = false;

        public static Canvas canvas;
        private Pen whitePen = new Pen(Color.White);
        private Pen blackPen = new Pen(Color.Black);

        private const int Height = 768;
        private const int Width = 1024;
        private const int pixelSize = 10;
        private const int gridHeight = Height / pixelSize;
        private const int gridWidth = Width / pixelSize;

        private bool[][] grid = new bool[Height][];

        Random rand = new Random();

        Pattern[] patterns = new Pattern[10];
        public gameOfLife() // Constructor
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);

            for (int i = 0; i < gridHeight; i++)
                grid[i] = new bool[gridWidth];

            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
                    grid[i][j] = false;

            grid[5][5] = true;///glider
            grid[6][6] = true;
            grid[6][7] = true;
            grid[5][7] = true;
            grid[4][7] = true;

            patterns[0] = new Pattern(9, 7, "2bo3b2o$b2o2bo2bo$b2o3b2o$ob4o$o5b2o$3bobo2bo$b2o3b2o!");

        }

        private void drawGrid()
        {
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    if (grid[i][j])
                        canvas.DrawFilledRectangle(blackPen, new Sys.Graphics.Point(j * pixelSize, i * pixelSize), pixelSize, pixelSize);
                    else
                        canvas.DrawFilledRectangle(whitePen, new Sys.Graphics.Point(j * pixelSize, i * pixelSize), pixelSize, pixelSize);
                }
            }


        }

        public void patternToGridPopulation(Pattern pattern, int StartPosX, int StartPosY)
        {
            if ((StartPosY + pattern.x > (Width / pixelSize)) || (StartPosX + pattern.y > (Height / pixelSize)))
            {
                Console.WriteLine("COULD NOT PLACE PATTERN! NOT ENOUGH SPACE!");
                return;
            }

            int currentPosX = StartPosX;
            int currentPosY = StartPosY;

            for (int i = 0; i < pattern.RLE.Length && pattern.RLE[i] != '!'; i++)
            {
                if (char.IsDigit(pattern.RLE[i]))
                {
                    int numberOfTimes = 0;
                    while (char.IsDigit(pattern.RLE[i]))
                    {
                        numberOfTimes = numberOfTimes * 10 + (pattern.RLE[i] - '0');
                        i++;
                    }

                    for (int j = 0; j < numberOfTimes; j++)
                    {
                        switch (pattern.RLE[i])
                        {
                            case 'o':
                                grid[currentPosX][currentPosY] = true;
                                currentPosY++;
                                break;
                            case 'b':
                                currentPosY++;
                                break;
                            case '$':
                                currentPosX++;
                                currentPosY = StartPosY;
                                break;
                        }
                    }
                }
                else
                {
                    switch (pattern.RLE[i])
                    {
                        case 'o':
                            grid[currentPosX][currentPosY] = true;
                            currentPosY++;
                            break;
                        case 'b':
                            currentPosY++;
                            break;
                        case '$':
                            currentPosX++;
                            currentPosY = StartPosY;
                            break;
                    }
                }
            }
        }

        private void updateGrid()
        {
            List<Tuple<int, int>> positionsToChange = new List<Tuple<int, int>>();

            for (int i = 0; i < gridHeight; i++) //height
            {
                for (int j = 0; j < gridWidth; j++) //width
                {
                    int neighborCount = 0;

                    // Count live neighbors
                    for (int di = -1; di <= 1; di++)
                    {
                        for (int dj = -1; dj <= 1; dj++)
                        {
                            if (di == 0 && dj == 0)
                                continue;

                            int ni = i + di;
                            int nj = j + dj;

                            if (ni >= 0 && ni < gridHeight && nj >= 0 && nj < gridWidth && grid[ni][nj])
                            {
                                neighborCount++;
                            }
                        }
                    }

                    // Apply rules
                    if (grid[i][j]) // Live cell
                    {
                        if (neighborCount < 2 || neighborCount > 3) // Underpopulation or overpopulation
                        {
                            positionsToChange.Add(new Tuple<int, int>(i, j));
                        }
                    }
                    else // Dead cell
                    {
                        if (neighborCount == 3) // Reproduction
                        {
                            positionsToChange.Add(new Tuple<int, int>(i, j));
                        }
                    }
                }
            }

            // Apply the changes
            foreach (Tuple<int, int> pos in positionsToChange)
            {
                grid[pos.Item1][pos.Item2] = !grid[pos.Item1][pos.Item2];
            }
        }
        public void handleGameOfLifeInputs()
        {
            drawGrid();

            if (!isPaused)
                updateGrid();

            if (KeyboardManager.KeyAvailable)
            {
                var key = KeyboardManager.ReadKey().Key;
                if (key == ConsoleKeyEx.Escape)
                {
                    ShouldExitGameOfLife = true;
                }
                else if (key == ConsoleKeyEx.R)
                {
                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                        {
                            int coinFlip = rand.Next(2);
                            grid[i][j] = (coinFlip == 1 ? true : false);
                        }
                }
                else if (key == ConsoleKeyEx.C)
                {
                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                            grid[i][j] = false;
                }
                else if (key == ConsoleKeyEx.Spacebar)
                {
                    isPaused = !isPaused;
                }
                else
                {
                    //load pattern
                    for (int i = 0; i < gridHeight; i++)
                        for (int j = 0; j < gridWidth; j++)
                            grid[i][j] = false;
                    patternToGridPopulation(patterns[0], gridHeight / 2, gridWidth / 2);
                }

            }
            Heap.Collect();
            canvas.Display();
        }
    }
}