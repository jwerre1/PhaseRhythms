using System;

namespace RhythmLibrary
{
    public class Rhythm
    {
        string originalInput;
        public Rhythm(string str)
        {
            originalInput = str;
            /*
            char[] charBeats = str.ToCharArray();
            int[] beats = new int[charBeats.Length];
            for (int i = 0; i < charBeats.Length; i++)
            {
                beats[i] = int.Parse(charBeats[i].ToString());
                Console.WriteLine(beats[i]);
            }
            */
        }

        public bool matches(string str, bool checkInitial)
        {
            // if applicable, check if input matches original
            if (checkInitial && originalInput == str)
            {
                return true;
            }
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
                Console.WriteLine(check);
                // check if string matches original
                if (originalInput == check)
                {
                    return true;
                }
            }
            return false;
        }
    }
}