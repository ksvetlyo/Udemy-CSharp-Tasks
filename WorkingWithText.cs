using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace ThisIsIT
{
    class WorkingWithText
    {
        //Exercise1
        public static void Exercise1()
        {
            Console.Write("Enter a few numbers (e.g. 1-2-3-4): ");
            var input = Console.ReadLine();

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            numbers.Sort();

            var isConsecutive = true;
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                {
                    isConsecutive = false;
                    break;
                }
            }
            var message = isConsecutive ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(message);
        }

        //Exercise2
        public static void Exercise2()
        {

            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
            {
                Console.WriteLine("Duplicate");
            }
        }

        //Exercise3
        public static void Exercise3()
        {
            var input = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time.");
                return;
            }

            var components = input.Split(':');
            if (components.Length != 2)
            {
                Console.WriteLine("Invalid Time");
                return;
            }

            var hour = Convert.ToInt32(components[0]);
            var minutes = Convert.ToInt32(components[1]);

            try
            {
                if (hour >=0 && hour <=23 && minutes >=0 && minutes <=59)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("Invalid Time.");
                }

            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Time.");
                throw;
            }
        }

        //Exercise4
        public static void Exercise4()
        {
            Console.Write("Enter a few words: ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
            {
                return;
            }

            var variableName = "";
            foreach (var word in input.Split(' '))
            {
                var wordWithPascalCase = char.ToUpper(word[0]) + word.ToLower().Substring(1);
                variableName += wordWithPascalCase;
            }

            Console.WriteLine(variableName);
        }

        //Exercise5
        public static void Exercise5()
        {
            Console.Write("Enter the word you want the count vowels of: ");
            var input = Console.ReadLine().ToLower();
            var vowels = new List<char>(new[]{'a', 'e', 'o', 'u', 'i'});
            var vowelCount = 0;
            foreach (var character in input)
            {
                if (vowels.Contains(character))
                {
                    vowelCount++;
                }
            }
            Console.WriteLine(vowelCount);
        }
    }
}
