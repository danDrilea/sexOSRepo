using System;

namespace sexOSKernel.Commands
{
    public class ClearScreen : Command
    {
        public ClearScreen(String name, String description) : base(name, description) { }
        public override string Execute(string[] args)
        {
            Console.Clear();
            return base.Execute(args);
        }
    }
}
