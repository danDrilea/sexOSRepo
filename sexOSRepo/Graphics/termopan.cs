using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sexOSRepo.Graphics
{
    public class Termopan
    {
        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.termopan-boop.bmp")] public static byte[] image;
        public static Bitmap bitmap = new Bitmap(32, 32, ColorDepth.ColorDepth32);//termopan
 
        private int x;
        private int y;

        private int heigth;
        private int width;

        private bool isopen;


        /// <summary>
        /// Creates a new unopened termopan object that needs a position
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public Termopan(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.heigth = (int)bitmap.Height;
            this.width = (int)bitmap.Width;
            this.isopen = false;

            bitmap = new Bitmap(image, ColorOrder.BGR);
        }

        public Termopan()
        {
            this.x = 0;
            this.y = 0;
            this.heigth = (int)bitmap.Height;
            this.width = (int)bitmap.Width;
            this.isopen = false;

            bitmap = new Bitmap(image, ColorOrder.BGR);
        }

        public void close()
        {
            this.isopen = false;
        }
        public void open()
        {
            this.isopen = true;
        }
        public bool isOpen()
        {
            return this.isopen;
        }
        public void setPos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public int getHeigth()
        {
            return heigth;
        }
        public int getWidth()
        {
            return width;
        }
    }
}
