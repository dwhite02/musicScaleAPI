using System;
using Microsoft.Extensions.FileSystemGlobbing.Internal;

namespace MusicScale.Services
{
	public class ScaleMakerService
	{


		public static string[] musicalNotes = { "C","C#","D","D#", "E", "F","F#", "G","G#", "A","A#","B",};

        public static List<string>? Scale { get; set; }

		public static List<string> FindMajor(string note)
		{
            
            int[] pattern = { 2, 2, 1, 2, 2, 2, 1 };

            return stepper(note, pattern);
        }

        public static List<string> FindMinor(string note)
        {

            int[] pattern = { 2, 1, 2, 2, 1, 2, 2 };

            return stepper(note, pattern);

        }

        public static List<string> stepper(string note, int[] item)
        {
            int rootPosition = Array.IndexOf(musicalNotes, note.ToUpper());
            int currPosition = rootPosition;
            Scale?.Add(musicalNotes[currPosition]);

            foreach (int step in item)
            {
                Scale?.Add(musicalNotes[currPosition]);
                currPosition = (currPosition + step) % musicalNotes.Length;

            }

            return Scale;
        }
    }
}

