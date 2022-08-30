using System;

namespace RhythmLibrary
{
    public class Rhythm
    {
        string originalInput;
        public Rhythm(string str)
        {
            originalInput = str;
        }
        private bool matches(string str)
        {
            // split into into char and make into linked list
            char[] beats = str.ToCharArray();
            LinkedList<char> beatList = new LinkedList<char>(beats);
            for (var i = 0; i < beats.Length - 1; i++)
            {
                // Move first item in linked list to the end
                beatList.AddLast(beatList.First()); 
                beatList.RemoveFirst();
                // join into a string
                string check = String.Join("", beatList);
                // check if string matches original
                if (originalInput == check)
                {
                    return true;
                }
            }
            return false;
        }

        public string createMeasure(string str)
        {
            // split into into char and make into linked list
            char[] beats = str.ToCharArray();
            if (beats.Length == 0) return "";

            string notatedString = "";
            char prevValue = '\0';
            bool insideBracket = false;
            for (var i = 0; i < beats.Length; i++)
            {
                if (beats[i].Equals('0'))
                {
                    if (prevValue.Equals('1') && insideBracket)
                    {
                        notatedString += "]";
                        insideBracket = false;
                    }
                    notatedString += " r8"; // eighth-note rest
                }
                else if (beats[i].Equals('1'))
                {
                    if (i == beats.Length - 1 && insideBracket)
                    {
                        notatedString += "]";
                    }
                    else if (prevValue.Equals('1') && !insideBracket)
                    {
                        notatedString += "[";
                        insideBracket = true;
                    } // Ending in "01" does not require brackets around the "1"
                    notatedString += " gui8"; // eigth-note beat
                }
                prevValue = beats[i];
            }
            return notatedString;
        }

        public bool repetitionCheck()
        {
            return matches(originalInput);
        }
    }
}