using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;
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
            patterns[0] = new Pattern(3, 3, "bob$2bo$3o!");                                                                                                                         //glider
            patterns[1] = new Pattern(36, 9, "24bo11b$22bobo11b$12b2o6b2o12b2o$11bo3bo4b2o12b2o$2o8bo5bo3b2o14b$2o8bo3bob2o4bobo11b$10bo5bo7bo11b$11bo3bo20b$12b2o!");              //first glider gun
            patterns[2] = new Pattern(38, 21, "bo36b$bo36b$o37b$b3o17b3o3b3o8b$b2obo9bo3bobo6b3o8b$2bo11b2obo7bo4b4o4b$6bo6bo3bobo3b2obo5b2o4b$3bo2bob3o3b2o9bo8b2obo$3b2obo5bo5bo17bob$9bob7o20b2$9bob7o20b$3b2obo5bo5bo17bob$3bo2bob3o3b2o9bo8b2obo$6bo6bo3bobo3b2obo5b2o4b$2bo11b2obo7bo4b4o4b$b2obo9bo3bobo6b3o8b$b3o17b3o3b3o8b$o37b$bo36b$bo!");  //snail (left)
            patterns[3] = new Pattern(27, 8, "9bo7bo9b$3b2obobob2o3b2obobob2o3b$3obob3o9b3obob3o$o3bobo5bobo5bobo3bo$4b2o6bobo6b2o4b$b2o9bobo9b2ob$b2ob2o15b2ob2ob$5bo15bo!");      //spider (up)
            patterns[4] = new Pattern(9, 7, "2bo3b2o$b2o2bo2bo$b2o3b2o$ob4o$o5b2o$3bobo2bo$b2o3b2o!");                                                                              //face thing
            patterns[5] = new Pattern(9, 6, "bo5bo$obo3bobo$obo3bobo$bo5bo2$3b3o!");                                                                                                //kisses
            patterns[6] = new Pattern(6, 6, "2o2b2o$o2bobo$bo4b$4bob$obo2bo$2o2b2o!");                                                                                              //square thing
            patterns[7] = new Pattern(20, 11, "2o16b2o$bo16bob$bobo12bobob$2b2o12b2o2b$7bo4bo7b$5b2ob4ob2o5b$7bo4bo7b$2b2o12b2o2b$bobo12bobob$bo16bob$2o16b2o!");                   //candy
            patterns[8] = new Pattern(12, 8, "5bob2o$4bo6bo$3b2o3bo2bo$2obo5b2o$2obo5b2o$3b2o3bo2bo$4bo6bo$5bob2o!");                                                               //flying right thingy
            patterns[9] = new Pattern(5, 4, "bo2bo$o4b$o3bo$4o!");                                                                                                                  //smol spaceship

            
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

                    switch (key)
                    {
                        case ConsoleKeyEx.D1://glider
                            patternToGridPopulation(patterns[0], 0, 0);
                            break;
                        case ConsoleKeyEx.D2://first glider gun
                            patternToGridPopulation(patterns[1], 0, 0);
                            break;
                        case ConsoleKeyEx.D3://snail (left)
                            patternToGridPopulation(patterns[2], gridHeight / 2, gridWidth - patterns[2].x - 5);
                            break;
                        case ConsoleKeyEx.D4://spider (up)
                            patternToGridPopulation(patterns[3], gridHeight - patterns[3].y - 5, gridWidth / 2);
                            break;
                        case ConsoleKeyEx.D5://face thing
                            patternToGridPopulation(patterns[4], gridHeight / 2, gridWidth / 2);
                            break;
                        case ConsoleKeyEx.D6://kisses
                            patternToGridPopulation(patterns[5], gridHeight / 2, gridWidth / 2);
                            break;
                        case ConsoleKeyEx.D7://square thing
                            patternToGridPopulation(patterns[6], gridHeight / 2, gridWidth / 2);
                            break;
                        case ConsoleKeyEx.D8://candy
                            patternToGridPopulation(patterns[7], gridHeight / 2, gridWidth / 2);
                            break;
                        case ConsoleKeyEx.D9://flying right thingy
                            patternToGridPopulation(patterns[8], gridHeight / 2, 0);
                            break;
                        case ConsoleKeyEx.D0://smol spaceship
                            patternToGridPopulation(patterns[9], gridHeight / 2, gridWidth - patterns[9].x - 5);
                            break;
                        default:
                            patternToGridPopulation(patterns[rand.Next(9)], gridHeight / 2, gridWidth / 2);
                            break;
                    }
                }

            }
            Heap.Collect();
            canvas.Display();
        }
    }
}