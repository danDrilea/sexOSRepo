using System;
using System.Collections.Generic;
namespace sexOSKernel.Commands
{

    public class CommandManager
    {
        /// <summary>
        /// Aici se afla logica pentru comenzi
        /// </summary>
        private List<Command> commands;//O lista cu comenzi


        public CommandManager()//constructorul pentru comenzi
        {
            this.commands = new List<Command>();//in paranteza se afla numarul de comenzi, pot sa l las asa
            //dar e good practice sa scriu cate sunt ca sa 
            //adaug la lista de comenzi comenzi xd
            this.commands.Add(new Help("help", "Lists commands and their descriptions", this.commands));
            this.commands.Add(new Sing("song", "Plays a song"));
            this.commands.Add(new ClearScreen("clear", "Clears the screen"));
            this.commands.Add(new File("file", "File System Operations. Type the argument 'help' for the manual."));
            this.commands.Add(new launchPaint("draw", "DRAW! Press S to save, L to load and ESC to exit!"));
            this.commands.Add(new launchBadApple("badApple", "plays the Bad Apple animation!"));
            this.commands.Add(new launchDesktop("desktop", "Starts a GUI with images."));
            this.commands.Add(new launchGameOfLife("life", "Starts Conway's Game Of Life Simulation - Press R for random or L for preset patterns! or C for clear"));
            this.commands.Add(new launchPiano("piano", "A simple piano for making music!"));
        }

        public String processInput(String input)
        {
            String[] split = input.Split(' ');//asta imi imparte string ul folosind separatorul ' '
            ///comanda blah blah => comanda, blah, blah "[]" arata ca e un vector de asa ceva
            String label = split[0];
            List<String> args = new List<String>();
            int ctr = 0;//contor
            foreach (String s in split)//argumente pt label (comanda arata ceva de genu: comanda(label) argument1 argument2 ...
            {
                if (ctr != 0)
                {
                    args.Add(s);
                }
                ++ctr;
            }
            //labelele le facem noi
            //label == help 
            foreach (Command cmd in this.commands)//comanda
            {
                if (cmd.name == label)
                {
                    return cmd.Execute(args.ToArray());//aici se afla argumentele
                }
            }
            return "Your command \"" + label + "\"does not exist!";
        }
    }
}
