using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using Cosmos.System.Graphics.Fonts;
using System;
using System.Drawing;
using System.Threading;
using Sys = Cosmos.System;

namespace sexOSKernel.Graphics
{
    public class snake
    {
        public bool ShouldExitSnake { get; private set; } = false;

        public static Canvas canvas;
        private Pen whitePen = new Pen(Color.White);
        private Pen blackPen = new Pen(Color.Black);
        private Pen redPen = new Pen(Color.Red);
        private Pen greenPen = new Pen(Color.Green);
        private Pen darkGreenPen = new Pen(Color.DarkGreen);

        private const int Height = 768;
        private const int Width = 1024;
        private const int pixelSize = 30;
        private const int gridHeight = Height / pixelSize;
        private const int gridWidth = Width / pixelSize;

        private int[][] grid = new int[gridHeight][];

        Random rand = new Random();


        //wall is -1
        //fruit is -2
        //air is 0
        //snake segment is number from 1-(however big it is)

        enum blockState
        {
            Wall = -1,
            Fruit = -2,
            Air = 0,
            SnakeHead = 1
        }

        enum direction
        {
            Up = 0,
            Down = 1,
            Left = 2,
            Right = 3
        }

        private int HeadSnakeI;
        private int HeadSnakeJ;

        private int TailSnakeI;
        private int TailSnakeJ;

        private direction currentDirection;
        private bool grow = true;
        private int sneklen = 0;
        private int score = 0;

        private bool game = true;

        private bool isValidPosition(int posI, int posJ)
        {
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    if (grid[posI][posJ] != (int)blockState.Air)
                        return false;
                }
            }
            return true;
        }

        void newFruit()
        {
            int randI;
            int randJ;
            do
            {
                randI = rand.Next(0, gridHeight - 1);
                randJ = rand.Next(0, gridWidth - 1);

            } while (!isValidPosition(randI, randJ));

            grid[randI][randJ] = (int)blockState.Fruit;
        }

        private void drawGrid()
        {
            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    switch (grid[i][j])
                    {
                        case ((int)blockState.Wall):
                            canvas.DrawFilledRectangle(whitePen, new Sys.Graphics.Point(j * pixelSize, i * pixelSize), pixelSize, pixelSize);
                            break;
                        case ((int)blockState.Air):
                            canvas.DrawFilledRectangle(blackPen, new Sys.Graphics.Point(j * pixelSize, i * pixelSize), pixelSize, pixelSize);
                            break;
                        case ((int)blockState.Fruit):
                            canvas.DrawFilledRectangle(redPen, new Sys.Graphics.Point(j * pixelSize, i * pixelSize), pixelSize, pixelSize);
                            break;
                        case ((int)blockState.SnakeHead):
                            canvas.DrawFilledRectangle(darkGreenPen, new Sys.Graphics.Point(j * pixelSize, i * pixelSize), pixelSize, pixelSize);
                            break;
                        default: //Snake Body
                            canvas.DrawFilledRectangle(greenPen, new Sys.Graphics.Point(j * pixelSize, i * pixelSize), pixelSize, pixelSize);
                            break;
                    }
                }
            }
            string scoretxt = "SCORE: ";
            scoretxt += score.ToString();
            canvas.DrawString(scoretxt, PCScreenFont.Default, blackPen, new Sys.Graphics.Point(0, 0));

        }
        public snake() // Constructor
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);
            currentDirection = direction.Up;

            for (int i = 0; i < gridHeight; i++)
                grid[i] = new int[gridWidth];

            for (int i = 0; i < gridHeight; i++)
            {
                for (int j = 0; j < gridWidth; j++)
                {
                    if (i == 0 || j == 0 || i == gridHeight - 1 || j == gridWidth - 1)
                    {
                        grid[i][j] = (int)blockState.Wall;
                    }
                    else
                    {
                        grid[i][j] = (int)blockState.Air;
                    }
                }
            }

            HeadSnakeI = (gridHeight - 1) / 2;
            HeadSnakeJ = (gridWidth - 1) / 2;

            TailSnakeI = HeadSnakeI + 3;
            TailSnakeJ = HeadSnakeJ;

            grid[HeadSnakeI][HeadSnakeJ] = (int)blockState.SnakeHead;
            grid[HeadSnakeI + 1][HeadSnakeJ] = 2;
            grid[HeadSnakeI + 2][HeadSnakeJ] = 3;
            grid[HeadSnakeI + 3][HeadSnakeJ] = 4;

            newFruit();
        }

        private bool check_move_head()
        {
            if (grid[HeadSnakeI][HeadSnakeJ] == (int)blockState.Air || grid[HeadSnakeI][HeadSnakeJ] == (int)blockState.Fruit)
                return true;
            else
                return false;

        }

        void increment()
        {
            for (int i = 1; i < gridHeight; i++)
                for (int j = 1; j < gridWidth; j++)
                    if (grid[i][j] > 0)
                        grid[i][j]++;
        }

        void search_and_destroy_tail()
        {
            sneklen = 0;
            for (int i = 0; i < gridHeight; i++)
                for (int j = 0; j < gridWidth; j++)
                    if (sneklen < grid[i][j])
                    {
                        sneklen = grid[i][j];
                        TailSnakeI = i;
                        TailSnakeJ = j;
                    }
            grid[TailSnakeI][TailSnakeJ] = (int)blockState.Air;
        }

        void check_grow()
        {
            if (grid[HeadSnakeI][HeadSnakeJ] == (int)blockState.Fruit)
            {
                grow = false;
                score++;
                newFruit();
            }
            else
                grow = true;
        }

        public void handleSnakeInputs()
        {

            if (grid[HeadSnakeI][HeadSnakeJ] != 1 && grid[HeadSnakeI][HeadSnakeJ] != 2)
                game = false;

            if (game == false)
            {
                canvas.Clear(Color.Black);
                string gameOverText = "GAME IS OVER, YOUR SCORE IS ";
                gameOverText += score.ToString();
                canvas.DrawString(gameOverText, PCScreenFont.Default, redPen, new Sys.Graphics.Point(gridHeight / 2, gridWidth / 2));
                canvas.Display();

                Thread.Sleep(5000);
                ShouldExitSnake = true;
                return;
            }

            if (KeyboardManager.KeyAvailable)
            {
                var key = KeyboardManager.ReadKey().Key;
                if (key == ConsoleKeyEx.Escape)
                {
                    ShouldExitSnake = true;
                }
                else if (key == ConsoleKeyEx.W || key == ConsoleKeyEx.UpArrow)
                {
                    if (currentDirection != direction.Down)
                        currentDirection = direction.Up;
                }
                else if (key == ConsoleKeyEx.D || key == ConsoleKeyEx.RightArrow)
                {
                    if (currentDirection != direction.Left)
                        currentDirection = direction.Right;
                }
                else if (key == ConsoleKeyEx.S || key == ConsoleKeyEx.DownArrow)
                {
                    if (currentDirection != direction.Up)
                        currentDirection = direction.Down;
                }
                else if (key == ConsoleKeyEx.A || key == ConsoleKeyEx.LeftArrow)
                {
                    if (currentDirection != direction.Right)
                        currentDirection = direction.Left;
                }
            }

            switch (currentDirection)
            {
                case direction.Up:
                    HeadSnakeI--;
                    break;
                case direction.Down:
                    HeadSnakeI++;
                    break;
                case direction.Left:
                    HeadSnakeJ--;
                    break;
                case direction.Right:
                    HeadSnakeJ++;
                    break;
            }

            if (check_move_head())
            {
                increment();
                if (grow)
                    search_and_destroy_tail();
                check_grow();
                grid[HeadSnakeI][HeadSnakeJ] = (int)blockState.SnakeHead;
                drawGrid();
                Thread.Sleep(125);
            }
            else
                game = false;


            Heap.Collect();
            canvas.Display();
        }
    }
}