using System;

namespace CharacterCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            int numberOfLetters = 0;
            int leftPadding = 4;

            while (!string.IsNullOrWhiteSpace(text))
            {
                string inText = Console.ReadLine();
                text = inText.ToLower();

                foreach (var character in text ?? string.Empty)
                {
                    numberOfLetters++;
                    counts[(int)character]++;
                }

                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        var character = (char)i;
                        var charPercent = 100 * (double)counts[i] / numberOfLetters;
                        Console.WriteLine(character + " - " 
                            + counts[i].ToString().PadLeft(leftPadding) + " " 
                            + charPercent.ToString("F1").PadLeft(leftPadding) + "%");
                    }
                }
            }
        }
    }
}
