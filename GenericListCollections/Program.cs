using System;
using System.Collections.Generic;

namespace GenericListCollections
{
    class Program
    {
        static void Main()
        {
            WorkingWithStrings();
            ChallengeGenerateTheFirst20FibonacciNumbers();
        }

        private static void ChallengeGenerateTheFirst20FibonacciNumbers()
        {
            var fibonacciNumbers = new List<int> { 1, 1 };

            while (fibonacciNumbers.Count < 20)
            {
                int count = fibonacciNumbers.Count;
                int prevNum1 = fibonacciNumbers[count - 1];
                int prevNum2 = fibonacciNumbers[count - 2];

                fibonacciNumbers.Add(prevNum1 + prevNum2);
            }

            foreach (int number in fibonacciNumbers)
                Console.WriteLine(number);
        }

        public static void WorkingWithStrings()
        {
            var names = new List<string> { "Tùng", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }

            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            Console.WriteLine($"The name {names[index]} is at index {index}");

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
        }
    }
}
