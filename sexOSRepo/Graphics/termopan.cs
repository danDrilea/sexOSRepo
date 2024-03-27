using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;

namespace sexOSRepo.Graphics
{
    public class Termopan
    {
        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.termopan-boop.bmp")]
        public static byte[] image;
        public static Bitmap bitmap = new Bitmap(354, 224, ColorDepth.ColorDepth32); //termopan
        private int cursor_Width = 32;
        private int cursor_Height = 32;
        private int x;
        private int y;
        private int height;
        private int width;
        private bool isOpen;
        private bool isDragging = false;
        private int offsetX = 0;
        private int offsetY = 0;
        public Termopan(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.height = (int)bitmap.Height;
            this.width = (int)bitmap.Width;
            this.isOpen = false;
            bitmap = new Bitmap(image, ColorOrder.BGR);
        }

        public Termopan()
        {
            this.x = 0;
            this.y = 0;
            this.height = (int)bitmap.Height;
            this.width = (int)bitmap.Width;
            this.isOpen = false;
            bitmap = new Bitmap(image, ColorOrder.BGR);
        }
        // Inside your Termopan class, modify the SetPos method or the part where you calculate the new position
        public bool HandleInteraction(int mouseX, int mouseY, MouseState mouseState)
        {
            bool interacted = false; // Flag to indicate if interaction occurs

            // Define the bounds of the top bar
            int topBarHeight = 24; // The height of the top bar
            bool isWithinTopBar = mouseX >= x && mouseX <= x + width && mouseY >= y && mouseY <= y + topBarHeight;

            // Interaction logic for closing the Termopan using the corner
            int cornerTolerance = 32; // Pixels area around the corner where the mouse is considered to intersect with the corner
            int topRightCornerX = x + width - cornerTolerance; // X coordinate of the top-right corner area
            int topRightCornerY = y; // Y coordinate of the top-right corner
            bool isWithinCloseButton = mouseX >= topRightCornerX && mouseX <= x + width && mouseY >= topRightCornerY && mouseY <= topRightCornerY + cornerTolerance;

            if (isWithinCloseButton && mouseState == MouseState.Left)
            {
                Close();
                interacted = true; // Closing is considered an interaction
                isDragging = false; // Ensure dragging is stopped if the Termopan is closed
                return interacted; // Return early since no further interaction should be processed
            }

            // Check if the interaction is within the top bar for dragging
            if (mouseState == MouseState.Right && isWithinTopBar)
            {
                if (!isDragging)
                {
                    // Start dragging
                    isDragging = true;
                    // Calculate and store the offset from the mouse to the top-left corner of the Termopan
                    offsetX = mouseX - x;
                    offsetY = mouseY - y;
                    interacted = true; // Interaction started
                }
            }

            if (isDragging)
            {
                // Update Termopan's position based on mouse movement, applying the initial offset
                int newX = mouseX - offsetX;
                int newY = mouseY - offsetY;

                // Clamp the new position to ensure Termopan stays within screen boundaries
                newX = Math.Clamp(newX, 0, (int)MouseManager.ScreenWidth - width);
                newY = Math.Clamp(newY, 0, (int)MouseManager.ScreenHeight - height);

                SetPos(newX, newY);
                interacted = true; // Termopan is being interacted with
            }

            // Stop dragging when the mouse button is released
            if (isDragging && mouseState != MouseState.Right)
            {
                isDragging = false;
                interacted = true; // Ending the drag is also an interaction
            }

            return interacted;
        }

        public void Close()
        {
            isOpen = false;
        }
        public void Open()
        {
            isOpen = true;
        }
        public bool IsOpen()
        {
            return isOpen;
        }
        public void SetPos(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int GetX()
        {
            return x;
        }
        public int GetY()
        {
            return y;
        }
        public int GetHeight()
        {
            return height;
        }
        public int GetWidth()
        {
            return width;
        }
    }
}
