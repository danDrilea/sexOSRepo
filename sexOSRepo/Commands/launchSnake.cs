using System;
using System.Collections.Generic;
using System.Text;
using sexOSKernel.Graphics;

namespace sexOSKernel.Commands
{
    public class launchSnake : Command
    {
        public launchSnake(String name, String description) : base(name, description) { }

        public override string Execute(string[] args)
        {
            if (Kernel.snake != null)
                return "Snake already launched!";

            Kernel.snake = new snake();
            Kernel.currentMode = Kernel.Mode.Snake;

            return "Launched Snake!";
        }
    }
}
