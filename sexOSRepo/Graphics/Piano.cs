using Cosmos.Core.IOGroup;
using Cosmos.System;
using Cosmos.System.Graphics;
using System.Collections.Generic;
using System;
using System.Drawing;
using Sys = Cosmos.System;
using Cosmos.Core.Memory;
using System.Collections;

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

        // Variables for notes from the central octave (C4 to B4)
        private float C4 = 262;   // Hz
        private float Cs4 = 277;  // Hz C sharp or Db
        private float D4 = 294;   // Hz
        private float Ds4 = 311;  // Hz D sharp or Eb
        private float E4 = 330;   // Hz
        private float F4 = 349;   // Hz
        private float Fs4 = 370;  // Hz F sharp or Gb
        private float G4 = 392;   // Hz
        private float Gs4 = 415;  // Hz G sharp or Ab
        private float A4 = 440;   // Hz
        private float As4 = 466;  // Hz A sharp or Bb
        private float B4 = 494;   // Hz
        private float C5 = 523f;   // Hz
        private float Cs5 = 554f;
        private float D5 = 587f;
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

            string[] whiteNotes = { "A", "S", "D", "F", "G", "H", "J", "K" , "L"};
            string[] blackNotes = { "W", "E", "T", "Y", "U", "O" };
            

            // Desenează tastele albe
            for (int i = 0; i < 9; i++)
            {
                canvas.DrawFilledRectangle(whiteKeyPen, startX + (whiteKeyWidth + 10) * i, startY, whiteKeyWidth, whiteKeyHeight);
                DrawText(whiteNotes[i], startX + (whiteKeyWidth + 10) * i + 20, startY + whiteKeyHeight - 30, Color.RebeccaPurple);
            }

            // Desenează tastele negre
            for (int i = 0; i < 8; i++)
            {
                if (i != 2 && i != 6) // Excludem locurile fără clape negre
                {
                    canvas.DrawFilledRectangle(blackKeyPen, startX + whiteKeyWidth - (blackKeyWidth / 2) + (whiteKeyWidth + 10) * i, startY, blackKeyWidth, blackKeyHeight);
                }
            }
        }

        public void HandlePianoInputs()
        {
            if (KeyboardManager.KeyAvailable)
            {



        var key = KeyboardManager.ReadKey();
                float[] frequencies = { C4,Cs4,D4,Ds4,E4,F4,Fs4,G4,Gs4,A4,As4,B4,C5,Cs5,D5}; // Frecvențe pentru notele C4-C5

                // Index pentru a selecta frecvența corectă
                int keyIndex = -1;
                switch (key.Key)
                {
                    case ConsoleKeyEx.A: keyIndex = 0; break; //C4
                    case ConsoleKeyEx.W: keyIndex = 1; break; //Cs4
                    case ConsoleKeyEx.S: keyIndex = 2; break; //D4
                    case ConsoleKeyEx.E: keyIndex = 3; break; //Ds4
                    case ConsoleKeyEx.D: keyIndex = 4; break; //E4
                    case ConsoleKeyEx.F: keyIndex = 5; break; //F4
                    case ConsoleKeyEx.T: keyIndex = 6; break; //Fs4
                    case ConsoleKeyEx.G: keyIndex = 7; break; //G4
                    case ConsoleKeyEx.Y: keyIndex = 8; break; //Gs4
                    case ConsoleKeyEx.H: keyIndex = 9; break; //A4
                    case ConsoleKeyEx.U: keyIndex = 10; break; //As4
                    case ConsoleKeyEx.J: keyIndex = 11; break; //B4
                    case ConsoleKeyEx.K: keyIndex = 12; break;//C5
                    case ConsoleKeyEx.O: keyIndex = 13; break;//Cs5
                    case ConsoleKeyEx.L: keyIndex = 14; break;//D5

                }
                
                if (keyIndex >= 0)
                {
                    ChangeKeyColorAndPlayNote(keyIndex, frequencies[keyIndex], 200); // Apasă și redă nota
                }

                if (key.Key == ConsoleKeyEx.Escape)
                {
                    ShouldExitPiano = true;
                    Heap.Collect();
                }
            }
            canvas.Display();
        }

        private void ChangeKeyColorAndPlayNote(int keyIndex, float frequency, int duration)
        {
            // Reîmprospătează toate tastele pentru a reveni la culoarea inițială
            InitializePianoKeys();

            // Redă nota
            System.Console.Beep((int)frequency, duration);
        }

        public void DrawText(string text, int x, int y, Color color)
        {
            var font = Cosmos.System.Graphics.Fonts.PCScreenFont.Default;
            canvas.DrawString(text, font, new Pen(color), x, y);
        }
    }
}