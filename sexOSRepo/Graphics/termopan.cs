using Cosmos.Core.Memory;
using Cosmos.System;
using Cosmos.System.Graphics;
using IL2CPU.API.Attribs;
using System;

namespace sexOSRepo.Graphics
{
    public class Termopan
    {
        [ManifestResourceStream(ResourceName = "sexOSRepo.GUIBMP.termopan.bmp")]
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
        private bool isMinimized = false;
        private int offsetX = 0;
        private int offsetY = 0;
        private string contentText = ""; // Property to store text content
        public string Content { get; set; } = ""; // Add this line to store the text content
        public string FilePath { get; set; } // Path to save the content


        public bool IsFocused = false;
        public Termopan(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.height = (int)bitmap.Height;
            this.width = (int)bitmap.Width;
            this.isOpen = false;
            bitmap = new Bitmap(image, ColorOrder.BGR);
            this.isMinimized = false;
        }
        public void SetContent(string text)
        {
            contentText = text; // Set the content text
        }
        public Termopan()
        {
            this.x = 0;
            this.y = 0;
            this.height = (int)bitmap.Height;
            this.width = (int)bitmap.Width;
            this.isOpen = false;
            bitmap = new Bitmap(image, ColorOrder.BGR);
            this.isMinimized = false;
        }
        public void OpenFile(string filePath, string content)
        {
            this.FilePath = filePath;
            this.Content = content;
        }
        public void Minimize()
        {
            isMinimized = true;
        }
        public bool IsMinimized()
        {
            return isMinimized;
        }
        public void Unminimize()
        {
            isMinimized = false;
        }
        public void HandleKeyboardInput(ConsoleKeyEx key)
        {
            if (!IsFocused) return;
            if(Content.Length <= 255)
            switch (key)
            {
                case ConsoleKeyEx.Backspace:
                    if (Content.Length > 0)
                    {
                        Content = Content.Substring(0, Content.Length - 1);
                        desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    }
                    break;

                // Letters
                case ConsoleKeyEx.A:
                    Content += "a";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.B:
                    Content += "b";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.C:
                    Content += "c";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D:
                    Content += "d";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.E:
                    Content += "e";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.F:
                    Content += "f";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.G:
                    Content += "g";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.H:
                    Content += "h";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.I:
                    Content += "i";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.J:
                    Content += "j";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.K:
                    Content += "k";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.L:
                    Content += "l";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.M:
                    Content += "m";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.N:
                    Content += "n";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.O:
                    Content += "o";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.P:
                    Content += "p";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.Q:
                    Content += "q";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.R:
                    Content += "r";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.S:
                    Content += "s";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.T:
                    Content += "t";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.U:
                    Content += "u";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.V:
                    Content += "v";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.W:
                    Content += "w";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.X:
                    Content += "x";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.Y:
                    Content += "y";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.Z:
                    Content += "z";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;

                // Numbers
                case ConsoleKeyEx.D0:
                    Content += "0";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D1:
                    Content += "1";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D2:
                    Content += "2";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D3:
                    Content += "3";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D4:
                    Content += "4";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D5:
                    Content += "5";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D6:
                    Content += "6";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D7:
                    Content += "7";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D8:
                    Content += "8";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.D9:
                    Content += "9";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;

                // Punctuation
                case ConsoleKeyEx.Spacebar:
                    Content += " ";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.Period:
                    Content += ".";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                case ConsoleKeyEx.Comma:
                    Content += ",";
                    desktop.Instance.SaveFileContent(this.FilePath, this.Content); // Save after each change
                    break;
                // Add cases for other punctuation marks

                default:
                    break;
            }
        }


        // Inside your Termopan class, modify the SetPos method or the part where you calculate the new position
        public bool HandleInteraction(int mouseX, int mouseY, MouseState mouseState)
        {
            bool interacted = false; // Flag to indicate if interaction occurs
            bool isWithinTermopan = mouseX >= x && mouseX <= x + width && mouseY >= y && mouseY <= y + height;
            // Define the bounds of the top bar
            int topBarHeight = 24; // The height of the top bar
            bool isWithinTopBar = mouseX >= x && mouseX <= x + width && mouseY >= y && mouseY <= y + topBarHeight;

            // Interaction logic for closing the Termopan using the corner
            int cornerTolerance = 32; // Pixels area around the corner where the mouse is considered to intersect with the corner
            int topRightCornerX = x + width - cornerTolerance; // X coordinate of the top-right corner area
            int topRightCornerY = y; // Y coordinate of the top-right corner


            bool isWithinCloseButton = mouseX >= topRightCornerX && mouseX <= x + width && mouseY >= topRightCornerY && mouseY <= topRightCornerY + cornerTolerance;
            // Similar logic to the close button for minimize button


            int minimizeButtonX = topRightCornerX - cornerTolerance; // Position it to the left of the close button
            bool isWithinMinimizeButton = mouseX >= minimizeButtonX && mouseX < topRightCornerX && mouseY >= topRightCornerY && mouseY <= topRightCornerY + cornerTolerance;

            if (isWithinMinimizeButton && mouseState == MouseState.Left)
            {
                Minimize();
                interacted = true;
                return interacted; // Minimizing should also stop further interactions
            }

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
            if (isWithinTermopan && (mouseState == MouseState.Left || mouseState == MouseState.Right))
            {
                IsFocused = true;
            }
            else if(!isWithinTermopan && (mouseState == MouseState.Left || mouseState == MouseState.Right))
            { 
                IsFocused = false; 
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