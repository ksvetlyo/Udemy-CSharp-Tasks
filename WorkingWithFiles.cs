using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ThisIsIT
{
    class WorkingWithFiles
    {
        //Exercise 1 - Reading a file and displaying the number of words.
        public static void NumberOfWords()
        {
            var path = @"C:\Users\Svetoslav\Desktop\file.txt";
            StreamReader myReader = new StreamReader(path);
            int wordCounter = 0;
            var words = new List<string>();
            foreach (var word in myReader.ReadToEnd().Split(' '))
            {
                words.Add(Convert.ToString(word));
                if (words.Contains(Convert.ToString(word)))
                {
                    wordCounter++;
                }
            }
            Console.WriteLine(wordCounter);
        }

        //Exercise 2 - Longest word in a text file
        public static void LongestWord()
        {
            var path = @"C:\Users\Svetoslav\Desktop\file.txt";
            StreamReader myReader = new StreamReader(path);
            var words = new List<string>();
            foreach (var word in myReader.ReadToEnd().Split(' ').OrderBy(s => s.Length))
            {
                string lastWord = word.Substring(word.LastIndexOf(word, StringComparison.Ordinal));
                words.Add(lastWord);
            }

            var last = "";
            for (int i = 0; i < words.Count; i++)
            {
               last = words[words.Count - 1];
            }
            Console.WriteLine("The longest word in the file is: " + last);
        }
    }
}
