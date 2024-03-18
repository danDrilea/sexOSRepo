using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sexOSRepo.Graphics
{
    public class imageGUI
    {
        public bool shouldExitImageGUI { get; private set; } = false;

        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.raton_1024x768.bmp")] public static byte[] test_image;
        public static Bitmap image_bitmap = new Bitmap(1024, 768, ColorDepth.ColorDepth32);//background

        [ManifestResourceStream(ResourceName = "sexOSRepo.badAppleBMP.cursor.bmp")] public static byte[] cursor_image;
        public static Bitmap cursor_bitmap = new Bitmap(32, 32, ColorDepth.ColorDepth32);//cursor

        public static Canvas canvas;
        public imageGUI() 
        {
            MouseManager.ScreenWidth = 1024;
            MouseManager.ScreenHeight = 768;
            MouseManager.X = 1024 / 2;
            MouseManager.Y = 768 / 2;
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.White);
            image_bitmap = new Bitmap(test_image, ColorOrder.BGR);
            cursor_bitmap = new Bitmap(cursor_image, ColorOrder.BGR);
        }

        public void handleImageGUIinput()
        {
            canvas.DrawImage(image_bitmap, 0, 0);
            if(MouseManager.X > 0 && MouseManager.X < 1023 && MouseManager.Y > 0 && MouseManager.Y < 767)
            canvas.DrawImageAlpha(cursor_bitmap, (int)MouseManager.X, (int)MouseManager.Y);
            if (KeyboardManager.KeyAvailable)
            {
                var key = KeyboardManager.ReadKey();
                if (key.Key == ConsoleKeyEx.Escape)
                {
                    shouldExitImageGUI = true;
                }
            }
            canvas.Display();
        }

    }
}
