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
            Console.Write("Your rhythm: ");
            rhythmInput = Console.ReadLine();
            while (!rhythmInput.All(c => "01".Contains(c))) {
                Console.Write("Only characters '0' & '1' allowed. Please re-enter: ");
                rhythmInput = Console.ReadLine();
            }
            Rhythm original = new Rhythm(rhythmInput);
            bool repetition = original.repetitionCheck();
            Console.WriteLine(repetition);
        }
    }
}
