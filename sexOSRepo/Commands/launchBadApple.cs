using sexOSKernel.Graphics;
using System;

namespace sexOSKernel.Commands
{
    public class launchBadApple : Command
    {
        public launchBadApple(String name, String description) : base(name, description) { }

        public override string Execute(string[] args)
        {
            if (Kernel.badapple != null)
                return "BadApple already launched!";

            Kernel.badapple = new badApple();
            Kernel.currentMode = Kernel.Mode.BadApple;

            return "Launched badApple!";
        }
    }
}
