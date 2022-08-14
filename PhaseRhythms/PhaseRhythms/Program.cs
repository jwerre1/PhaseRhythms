using System;
using System.Text.RegularExpressions;
using RhythmLibrary;

namespace PhaseRhythms
{
    class Program
    {
        static void Main(string[] args)
        {
            string rhythmInput = "";

            Console.WriteLine("Type a rhythm of equal length notes and rests");
            Console.WriteLine("Signify '1' for a note and '0' for a rest");
            Console.WriteLine("Example: 111011010110 (Reich: Clapping Music)");
            rhythmInput = Console.ReadLine();

            Rhythm original = new Rhythm(rhythmInput);
            Console.WriteLine(original.matches(rhythmInput, false));
        }
    }
}
