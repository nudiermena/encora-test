using System.Globalization;

namespace StringManipulation.Program.Models
{
    public static class StringSorting
    {
        public static List<string> SortingOperations(List<string> inputStrings)
        {
            CultureInfo usCultureInfo = new CultureInfo("en-US");
            CultureInfo.CurrentCulture = usCultureInfo;

            //Create a dictionary to store the frequency of each character
            Dictionary<char, int> charFrequency = new();
            List<string> outputStrings = new();

            foreach (string inputString in inputStrings)
            {
                foreach (char c in inputString)
                {
                    if (char.IsLetter(c))
                    {
                        if (charFrequency.ContainsKey(c))
                        {
                            charFrequency[c]++;
                        }
                        else
                        {
                            charFrequency[c] = 1;
                        }
                    }
                }

                //perform the sort operation.
                var sortedChars = charFrequency.OrderByDescending(pair => pair.Value)
                                         .ThenBy(pair => pair.Key)
                                         .SelectMany(pair => Enumerable.Repeat(pair.Key, pair.Value));

                outputStrings.Add(new string(sortedChars.ToArray()));
                charFrequency.Clear();
            }

            if (outputStrings.Count.Equals(inputStrings.Count))
            {
                return outputStrings;
            }
            else
            {
                return new List<string>();
            }
        }
    }
}

