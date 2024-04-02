using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sexOSRepo.Graphics
{
    public class DesktopIcon
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Bitmap Image { get; set; }
        public Termopan AssociatedTermopan { get; set; }

        public DesktopIcon(int x, int y, Bitmap image, Termopan termopan)
        {
            X = x;
            Y = y;
            Image = image;
            AssociatedTermopan = termopan;
        }

        public void Draw(Canvas canvas)
        {
            canvas.DrawImage(Image, X, Y);
        }

        // Check if the icon is clicked
        public bool IsClicked(int mouseX, int mouseY)
        {
            return mouseX >= X && mouseX <= X + Image.Width && mouseY >= Y && mouseY <= Y + Image.Height;
        }
    }
}
