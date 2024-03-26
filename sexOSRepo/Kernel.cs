using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using Sys = Cosmos.System;
using sexOSKernel.Commands;
using Cosmos.System.FileSystem;
using sexOSKernel.Graphics;
using sexOSRepo.Graphics;

namespace sexOSKernel//<------ INCEPUT SCOPE KERNEL
{
    ///nu IESITI DIN NAMESPACE CA FACE ASTA URAT
    ///practic ce e in scope-ul lui sexOSKernel il foloseste, daca iesi din scope nu mai recunoaste nimic
    public class Kernel : Sys.Kernel
    {
        public CosmosVFS vfs;//file system class
        private CommandManager commandManager;

        public static GUI gui;
        public static badApple badapple;
        public static imageGUI imagegui;
        public static gameOfLife gameoflife;

        protected override void BeforeRun()
        {
            this.vfs = new CosmosVFS();//register vfs
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(this.vfs);
            this.commandManager = new CommandManager();//adauga comenzile ca sa fie recunoscute in scope

            Console.Write("                ___  ____  \r\n ___  _____  __/ _ \\/ ___| \r\n/ __|/ _ \\ \\/ / | | \\___ \\ \r\n\\__ \\  __/>  <| |_| |___) |\r\n|___/\\___/_/\\_\\\\___/|____/ \n");
            Console.Write("sexOS successfully booted!\n");
        }

        protected override void Run()
        {
            //gui
            if (gui != null && !gui.ShouldExitGUI)
            {
                gui.handleGUIInputs();
            }
            else if (gui != null && gui.ShouldExitGUI)
            {
                // Exit GUI mode
                ExitGUIMode(); // You need to define this method
                gui = null; // Reset GUI to null if you're done with it
            }
            else if (badapple != null && !badapple.ShouldExitApple)
            {
                badapple.handleAppleInputs();
            }
            else if (badapple != null && badapple.ShouldExitApple)
            {
                // Exit Apple mode
                ExitBadAppleMode();
                badapple = null; // Reset GUI to null if you're done with it
            }
            else if(imagegui != null && !imagegui.shouldExitImageGUI)
            {
                    imagegui.handleImageGUIinput();
            }
            else if(imagegui != null && imagegui.shouldExitImageGUI)
            {
                ExitImageGUIMode();
                imagegui = null;
            }
            else if (gameoflife != null && !gameoflife.ShouldExitGameOfLife)
            {
                gameoflife.handleGameOfLifeInputs();
            }
            else if (gameoflife != null && gameoflife.ShouldExitGameOfLife)
            {
                ExitGameOfLife();
                gameoflife = null;
            }
            else
            {
                // Handle console input/output as before
                HandleConsoleInput();
            }

        }

        private void ExitBadAppleMode()
        {
            // Clear the GUI canvas or disable graphics mode as necessary
            badApple.canvas.Disable(); // This is conceptual; actual method to disable canvas or graphics mode may vary

            // Potentially clear the console and reset any needed console settings
            Console.Clear();
            Console.WriteLine("Back to console mode.");

            // Re-enable console input if it was disabled during GUI mode
        }
        private void ExitImageGUIMode()
        {
            // Potentially clear the console and reset any needed console settings
            Console.Clear();
            Console.WriteLine("Back to console mode.");
            imageGUI.canvas.Disable();
            // Re-enable console input if it was disabled during GUI mode
        }
        private void ExitGUIMode()
        {
            // Clear the GUI canvas or disable graphics mode as necessary
            GUI.canvas.Disable(); // This is conceptual; actual method to disable canvas or graphics mode may vary

            // Potentially clear the console and reset any needed console settings
            Console.Clear();
            Console.WriteLine("Back to console mode.");

            // Re-enable console input if it was disabled during GUI mode
        }

        private void ExitGameOfLife()
        {
            // Clear the GUI canvas or disable graphics mode as necessary
            gameOfLife.canvas.Disable(); // This is conceptual; actual method to disable canvas or graphics mode may vary

            // Potentially clear the console and reset any needed console settings
            Console.Clear();
            Console.WriteLine("Back to console mode.");

            // Re-enable console input if it was disabled during GUI mode
        }

        private void HandleConsoleInput()
        {
            Console.Write(File.currentDirectory + ">");
            String input = Console.ReadLine();
            string response = this.commandManager.processInput(input);
            Console.WriteLine(response);
        }


    }

}///<--- SFARSIT SCOPE KERNEL