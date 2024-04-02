using System;

namespace sexOSKernel.Commands
{
    public class Sing : Command
    {
        // 4/4 time (music theory time)
        private float tempo;

        private float wholeNote;
        private float halfNote;
        private float quarterNote;
        private float eightNote;
        private float sixteenthNote;

        private float dottedQuarterNote;
        private float dottedEightNote;

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
        private float C5 = 523.25f;   // Hz
        private float Cs5 = 554.37f;  // Hz C sharp or Db
        private float D5 = 587.33f;   // Hz
        private float Ds5 = 622.25f;  // Hz D sharp or Eb
        private float E5 = 659.25f;   // Hz

        public Sing(String name, String description) : base(name, description)
        {
            tempo = 200; // 113 bpm = quarter note

            quarterNote = (60 / tempo) * 1000;
            wholeNote = 4 * quarterNote;
            halfNote = 2 * quarterNote;
            eightNote = quarterNote / 2;
            sixteenthNote = quarterNote / 4;

            dottedQuarterNote = quarterNote + (quarterNote / 2);
            dottedEightNote = eightNote + (eightNote / 2);

        }
        public override string Execute(string[] args)
        {
            PlaySong();
            return @"
   ___
 /     \
| () () |
 \  ^  /
  |||||
";
        }
        private void PlaySong() //N-am stat sa gasesc duratele floatre note ca n-aveam chef, dar notele sunt bune
        {
            //NEVER GONNA GIVE YOU UP
            PlayNote(D4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(B4, dottedEightNote);
            PlayNote(B4, dottedEightNote);
            PlayNote(A4, dottedEightNote);

            //NEVER GONNA LET YOU DOWN
            PlayNote(D4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(A4, dottedEightNote);
            PlayNote(A4, dottedEightNote);
            PlayNote(G4, dottedEightNote);
            PlayNote(Fs4, sixteenthNote);
            PlayNote(E4, eightNote);


            //NEVER GONNA RUN AROUND AND DESERT YOU
            PlayNote(D4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, quarterNote);
            PlayNote(A4, eightNote);
            PlayNote(Fs4, dottedEightNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(D4, eightNote);
            PlayNote(D4, eightNote);
            PlayNote(D4, eightNote);
            PlayNote(A4, quarterNote);
            PlayNote(G4, halfNote);

            //NEVER GONNA MAKE YOU CRY
            PlayNote(D4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(B4, dottedEightNote);
            PlayNote(B4, dottedEightNote);
            PlayNote(A4, dottedQuarterNote);
            //NEVER GONNA SAY GOODBYE 
            PlayNote(D4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(D5, quarterNote);
            PlayNote(Fs4, eightNote);
            PlayNote(G4, dottedEightNote);
            PlayNote(Fs4, sixteenthNote);
            PlayNote(E4, eightNote);
            //NEVER GONNA TELL A LIE AND HURT YOU
            PlayNote(D4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, sixteenthNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(G4, quarterNote);
            PlayNote(A4, eightNote);
            PlayNote(Fs4, dottedEightNote);
            PlayNote(E4, sixteenthNote);
            PlayNote(D4, quarterNote);
            PlayNote(D4, eightNote);
            PlayNote(A4, quarterNote);
            PlayNote(G4, halfNote);
        }

        private void PlayNote(float frequency, float duration)
        {
            Console.Beep((int)frequency, (int)duration);
        }
    }
}
