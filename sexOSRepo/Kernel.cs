using Cosmos.System.FileSystem;
using sexOSKernel.Commands;
using sexOSKernel.Graphics;
using sexOSRepo.Graphics;
using System;
using Sys = Cosmos.System;

namespace sexOSKernel//<------ INCEPUT SCOPE KERNEL
{
    ///nu IESITI DIN NAMESPACE CA FACE ASTA URAT
    ///practic ce e in scope-ul lui sexOSKernel il foloseste, daca iesi din scope nu mai recunoaste nimic
    public class Kernel : Sys.Kernel
    {
        public CosmosVFS vfs;//file system class
        private CommandManager commandManager;
        public enum Mode
        {
            Console,
            Paint,
            BadApple,
            Desktop,
            GameOfLife,
            Snake
        }

        public static Mode currentMode = Mode.Console;

        public static paint paint;
        public static badApple badapple;
        public static desktop desktop;
        public static gameOfLife gameoflife;
        public static snake snake;

        protected override void BeforeRun()
        {
            this.vfs = new CosmosVFS();//register vfs
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            this.commandManager = new CommandManager();//adauga comenzile ca sa fie recunoscute in scope

            Console.Clear();
            Console.Write("                ___  ____  \r\n ___  _____  __/ _ \\/ ___| \r\n/ __|/ _ \\ \\/ / | | \\___ \\ \r\n\\__ \\  __/>  <| |_| |___) |\r\n|___/\\___/_/\\_\\\\___/|____/ \n");
            Console.Write("sexOS successfully booted!\n");
        }

        protected override void Run()
        {
            switch (currentMode)
            {
                case Mode.Paint:
                    paint.handlePaintInputs();
                    break;
                case Mode.BadApple:
                    badapple.handleAppleInputs();
                    break;
                case Mode.Desktop:
                    desktop.handledesktopinput();
                    break;
                case Mode.GameOfLife:
                    gameoflife.handleGameOfLifeInputs();
                    break;
                case Mode.Snake:
                    snake.handleSnakeInputs();
                    break;
                case Mode.Console:
                default:
                    Console.Write(File.currentDirectory + ">");
                    string input = Console.ReadLine();
                    string response = commandManager.processInput(input);
                    Console.WriteLine(response);
                    break;
            }

            if(paint != null && paint.ShouldExitPaint)
                exitMode(Mode.Paint);
            if(badapple != null && badapple.ShouldExitApple)
                exitMode(Mode.BadApple);
            if(desktop != null && desktop.shouldExitdesktop)
                exitMode(Mode.Desktop);
            if(gameoflife != null && gameoflife.ShouldExitGameOfLife)
                exitMode(Mode.GameOfLife);
            if(snake != null && snake.ShouldExitSnake)
                exitMode(Mode.Snake);

            if(currentMode == Mode.Console)
            {
                Console.Write(File.currentDirectory + ">");
                string input = Console.ReadLine();
                string response = commandManager.processInput(input);
                Console.WriteLine(response);
            }
        }

        private void exitMode(Mode mode)
        {
            switch (mode)
            {
                case Mode.Paint:
                    paint.canvas.Disable();
                    paint = null;
                    break;
                case Mode.BadApple:
                    badApple.canvas.Disable();
                    badapple= null;
                    break;
                case Mode.Desktop:
                    desktop.canvas.Disable();
                    desktop = null;
                    break;
                case Mode.GameOfLife:
                    gameOfLife.canvas.Disable();
                    gameoflife= null;
                    break;
                case Mode.Snake:
                    snake.canvas.Disable();
                    snake = null;
                    break;
            }
            currentMode = Mode.Console;

            Console.Clear();
            Console.WriteLine("Welcome back to sexOS!");
        }

    }

}///<--- SFARSIT SCOPE KERNEL