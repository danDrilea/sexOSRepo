using Cosmos.Core.IOGroup;
using Cosmos.System;
using Cosmos.System.Graphics;
using System.Collections.Generic;
using System;
using System.Drawing;
using Sys = Cosmos.System;
using Cosmos.Core.Memory;

namespace sexOSRepo.Graphics
{
    public class Piano
    {
        public bool ShouldExitPiano { get; private set; } = false;
        public static Canvas canvas;

        // Dimensiuni și poziționare
        private int startX = 200; // Centrat pe ecran
        private int startY = 284; // Centrat pe ecran
        private int whiteKeyWidth = 60;
        private int whiteKeyHeight = 200;
        private int blackKeyWidth = 40;
        private int blackKeyHeight = 120;

        public Piano()
        {
            canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1024, 768, ColorDepth.ColorDepth32));
            canvas.Clear(Color.Black);
            InitializePianoKeys();
        }

        private void InitializePianoKeys()
        {
            Pen whiteKeyPen = new Pen(Color.White);
            Pen blackKeyPen = new Pen(Color.Gray);

            // Desenează tastele albe
            for (int i = 0; i < 9; i++)
            {
                canvas.DrawFilledRectangle(whiteKeyPen, startX + (whiteKeyWidth + 10) * i, startY, whiteKeyWidth, whiteKeyHeight);
            }

            // Desenează tastele negre
            for (int i = 0; i < 8; i++)
            {
                if (i != 2 && i != 6) // Excludem locurile fără clape negre
                {
                    canvas.DrawFilledRectangle(blackKeyPen, startX + whiteKeyWidth - (blackKeyWidth / 2) + (whiteKeyWidth + 10) * i, startY, blackKeyWidth, blackKeyHeight);
                }
            }

            // Desenează notele pe taste
            string[] notes = { "A", "S", "D", "F", "G", "H", "J", "K", "L" };
            for (int i = 0; i < notes.Length; i++)
            {
                DrawText(notes[i], startX + (whiteKeyWidth + 10) * i + 20, startY + whiteKeyHeight - 30, Color.Black);
            }
        }

        public void HandlePianoInputs()
        {
            if (KeyboardManager.KeyAvailable)
            {
                var key = KeyboardManager.ReadKey();
                int[] frequencies = { 261, 294, 330, 349, 392, 440, 494, 523, 587 }; // Frecvențe pentru notele C4, D4, E4, F4, G4, A4, B4, C5, D5

                // Index pentru a selecta frecvența corectă
                int keyIndex = -1;
                switch (key.Key)
                {
                    case ConsoleKeyEx.A: keyIndex = 0; break;
                    case ConsoleKeyEx.S: keyIndex = 1; break;
                    case ConsoleKeyEx.D: keyIndex = 2; break;
                    case ConsoleKeyEx.F: keyIndex = 3; break;
                    case ConsoleKeyEx.G: keyIndex = 4; break;
                    case ConsoleKeyEx.H: keyIndex = 5; break;
                    case ConsoleKeyEx.J: keyIndex = 6; break;
                    case ConsoleKeyEx.K: keyIndex = 7; break;
                    case ConsoleKeyEx.L: keyIndex = 8; break;
                }

                if (keyIndex >= 0)
                {
                    ChangeKeyColorAndPlayNote(keyIndex, frequencies[keyIndex], 200); // Apasă și redă nota
                }

                if (key.Key == ConsoleKeyEx.Escape)
                {
                    ShouldExitPiano = true;
                }
            }
            canvas.Display();
        }

        private void ChangeKeyColorAndPlayNote(int keyIndex, int frequency, int duration)
        {
            // Reîmprospătează toate tastele pentru a reveni la culoarea inițială
            InitializePianoKeys();

            // Redă nota
            System.Console.Beep(frequency, duration);
        }

        public void DrawText(string text, int x, int y, Color color)
        {
            var font = Cosmos.System.Graphics.Fonts.PCScreenFont.Default;
            canvas.DrawString(text, font, new Pen(color), x, y);
        }
    }
}