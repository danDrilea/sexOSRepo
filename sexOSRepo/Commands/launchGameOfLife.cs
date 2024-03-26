using System;
using System.Collections.Generic;
using System.Text;
using sexOSKernel.Graphics;

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

            return "Launched GameOfLife!";
        }
    }
}
