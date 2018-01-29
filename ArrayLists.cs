using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThisIsIT
{
    class ArrayLists
    {
        // Exercise1 Facebook likes
        public static void Exercise1()
        {
            var names = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter names(or hit ENTER to exit).");
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }
                names.Add(input);

            }

            if (names.Count == 1)
            {
                Console.WriteLine("{0} likes your post.", names[0]);
            }
            else if (names.Count == 2)
            {
                Console.WriteLine("{0} and {1} like your post.", names[0], names[1]);
            }
            else if (names.Count > 2)
            {
                Console.WriteLine("{0}, {1} and {2} other people like your post.", names[0], names[1], names.Count - 2);
            }
            else
            {
                Console.WriteLine();
            }
        }

        //Exercise2 Reverse Name
        public static void Exercise2()
        {
            Console.WriteLine("Vat is y'name?");
            var input = Console.ReadLine();
            if (input != null)
            {
                var array = new char[input.Length];
                for (var i = input.Length; i > 0; i--)
                {
                    array[input.Length - i] = input[i - 1];
                }
                var reversed = new string(array);
                Console.WriteLine("Reversed name: " + reversed);

            }
        }

        //Exercise3 
        public static void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count < 5)
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(number))
                {
                    Console.WriteLine("You've previously entered " + number);
                    continue;
                }
                numbers.Add(number);
            }
            numbers.Sort();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        //Exercise4
        public static void Exercise4()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Enter a number or type 'Quit' to exit.");
                var input = Console.ReadLine();
                if (input == "Quit")
                {
                    break;
                }
                numbers.Add(Convert.ToInt32(input));

            }
            var uniques = new List<int>();
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }
        //Exercise5
        public static void Exercise5()
        {
            string[] elements;
            while (true)
            {
                Console.WriteLine("Enter a list of comma-separated values: ");
                var input = Console.ReadLine();
                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5)
                    {
                        break;
                    }

                    Console.WriteLine("Invalid List");
                }
            }

            var numbers = new List<int>();
            foreach (var number in elements)
                numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);
        }
    }
}
