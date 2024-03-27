using sexOSKernel.Graphics;
using System;

namespace sexOSKernel.Commands
{
    public class launchGameOfLife : Command
    {
        public launchGameOfLife(String name, String description) : base(name, description) { }

        public override string Execute(string[] args)
        {
            if (Kernel.badapple != null)
                return "GameOfLife already launched!";

            Kernel.gameoflife = new gameOfLife();
            Kernel.currentMode = Kernel.Mode.GameOfLife;

            return "Launched GameOfLife!";
        }
    }
}
