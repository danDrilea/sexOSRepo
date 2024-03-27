using System;
using System.Collections.Generic;

namespace sexOSKernel.Commands
{
    public class Help : Command
    {
        private List<Command> commands;
        public Help(String name, String description, List<Command> commands) : base(name, description)   //Help ia ca argument si lista de comenzi, ca sa arate dinamic cate comenzi avem
        {
            this.commands = commands;
        }
        public override string Execute(String[] args)
        {
            string commandList = "Available commands:\n";

            // Calculate maximum length of command names
            int maxLength = 0;
            foreach (Command cmd in commands)
            {
                if (cmd.name.Length > maxLength)
                {
                    maxLength = cmd.name.Length;
                }
            }

            // List all command names with aligned descriptions
            foreach (Command cmd in commands)
            {
                string padding = new string(' ', maxLength - cmd.name.Length + 2); // Add padding to align descriptions
                commandList += $"{cmd.name}{padding} {cmd.description}\n";
            }

            return commandList;
        }

    }
}