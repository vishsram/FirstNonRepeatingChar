using System;
using System.Collections.Generic;

namespace FirstNonRepeatingChar
{
    public static class Program
    {
        public static char FindFirstNonRepeatingChar(String str) {
            if (String.IsNullOrEmpty(str)) {
                throw new ArgumentNullException();
            }

            char firstNonRepeatingChar = char.MinValue;

            // Construct a dictionary for each char in the string with count as value
            Dictionary<char,int> charMap = new Dictionary<char, int>();

            // Iterate through the string array and increment count in dictionary
            for(int i = 0; i < str.Length; i++) {
                if (charMap.ContainsKey(str[i])) {
                    charMap[str[i]]++;
                }
                else {
                    charMap.Add(str[i], 1);
                }
            }

            // Iterate through the dictionary and return the first char whose count is 1
            foreach(var charCount in charMap) {
                if (charCount.Value == 1) {
                    firstNonRepeatingChar = charCount.Key;
                    break;
                }
            }

            return firstNonRepeatingChar;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char result = FindFirstNonRepeatingChar("hello world hi hey");
            Console.WriteLine(result);
        }
    }
}
