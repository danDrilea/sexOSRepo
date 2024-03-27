using System;
using System.Collections.Generic;
using System.Text;
using sexOSKernel.Graphics;

namespace sexOSKernel.Commands
{
    public class launchPaint : Command
    {
        public launchPaint(String name, String description) : base(name, description) { }

        public override string Execute(string[] args)
        {
            if (Kernel.paint != null)
                return "Paint already launched!";

            Kernel.paint = new paint();
            Kernel.currentMode = Kernel.Mode.Paint;

            return "Launched Paint!";
        }
    }
}
