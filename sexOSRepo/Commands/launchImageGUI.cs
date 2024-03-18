using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using sexOSKernel.Graphics;
using sexOSRepo.Graphics;

namespace sexOSKernel.Commands
{
    public class launchImageGUI : Command
    {
        public launchImageGUI(String name, String description) : base(name, description) { }
        public override string Execute(string[] args)
        {
            if(Kernel.imagegui != null)
                return "Image GUI is running";

            Kernel.imagegui = new imageGUI();
            return "Launched gui!";
        }
    }
}
