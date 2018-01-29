using System;
using System.Data.SqlTypes;
using System.Linq;

namespace ThisIsIt
{
    public class Exercises
    {
        //Exercise1
        public static void Exercise1(int number)
        {
            int lineCount = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    lineCount++;
                }
            }
            Console.WriteLine("There are {0} numbers divisible by 3 between 1 and 100.", lineCount);
        }
        //Exercise2
        public static void Exercise2(int number)
        {
            var sum = 0;

            while (true)
            {
                Console.WriteLine("Enter a number or type 'ok' to terminate app. ");
                var input = Console.ReadLine();
                if (input.ToLower() == "ok")
                {
                    break;
                }

                sum += Convert.ToInt32(input);

            }

            Console.WriteLine("Sum of numbers is " + sum);
        }
        //Exercise3
        public static void Exercise3(int number)
        {
            Console.Write("Please enter a number you want the factorial of: ");
            var input = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            for (int i = input; i >= 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine("factorial of {0} is {1}", input, factorial);

        }
        //Exercise4
        public static void Exercise4(int input)
        {
            Console.WriteLine("Welcome to the guess game, ready to lose?");
            input = new Random().Next(0, 10);
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Guess the number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                if (number == input)
                {
                    Console.WriteLine("You won! The number was " + input);
                }
            }
            Console.WriteLine("You lost!");
        }

        //Exercise5
        public static void Exercise5(int num)
        {
            Console.WriteLine("Enter comma separated values.");
            var input = Console.ReadLine();
            var numbers = input.Split(",");
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }
            Console.WriteLine("Max is " + max);
        }
    }
}