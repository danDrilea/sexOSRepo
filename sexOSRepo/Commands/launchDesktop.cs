using sexOSRepo.Graphics;
using System;

namespace sexOSKernel.Commands
{
    public class launchDesktop : Command
    {
        public launchDesktop(String name, String description) : base(name, description) { }
        public override string Execute(string[] args)
        {
            if (Kernel.desktop != null)
                return "Desktop is running";

            Kernel.desktop = new desktop();
            Kernel.currentMode = Kernel.Mode.Desktop;
            return "Launched Desktop!";
        }
    }
}
