using sexOSRepo.Graphics;
using System;

namespace sexOSKernel.Commands
{
    public class launchPiano : Command
    {
        public launchPiano(string name, string description) : base(name, description) { }

        public override string Execute(string[] args)
        {
            if (Kernel.piano != null)
                return "Piano is already running.";

            Kernel.piano = new Piano();
            Kernel.currentMode = Kernel.Mode.Piano; // Asumând că ai un mod definit pentru Piano în Kernel
            return "Launched Piano!";
        }
    }
}
