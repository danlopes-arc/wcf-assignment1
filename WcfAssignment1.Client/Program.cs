using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfAssignment1.Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new WcfService.ServiceClient();

            while (true)
            {
                Console.WriteLine("Calculator");
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Pring HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");

                Console.WriteLine();
                Console.Write("Enter your choice: ");

                var choice = Console.ReadLine();

                if (choice == "6")
                {
                    return;
                }

                HandleChoice(service, choice);
                Console.WriteLine();
            }
        }



        private static void HandleChoice(WcfService.ServiceClient service, string choice)
        {
            Console.WriteLine();
            switch (choice)
            {
                case "1":
                    {
                        var value = ReadInt("Enter the number: ");
                        var isPrime = service.IsPrimeNumber(value);
                        Console.WriteLine();
                        Console.WriteLine(isPrime ? "Prime number" : "Not prime number");
                        return;
                    }
                case "2":
                    {
                        var value = ReadInt("Enter the number: ");
                        Console.WriteLine();
                        Console.WriteLine(service.SumDigits(value));
                        return;
                    }
                case "3":
                    {
                        var value = ReadString("Enter the text: ");
                        Console.WriteLine();
                        Console.WriteLine(service.ReverseString(value));
                        return;
                    }
                case "4":
                    {
                        var tag = ReadString("Enter the tag: ");
                        var data = ReadString("Enter the data: ");
                        Console.WriteLine();
                        Console.WriteLine(service.MakeHtmlTag(tag, data));
                        return;
                    }
                case "5":
                    {
                        var type = ReadString("Enter the sort type (Ascending/Descending): ", "Ascending", "Descending");
                        var n1 = ReadInt("Enter number 1: ");
                        var n2 = ReadInt("Enter number 2: ");
                        var n3 = ReadInt("Enter number 3: ");
                        var n4 = ReadInt("Enter number 4: ");
                        var n5 = ReadInt("Enter number 5: ");
                        var sortedNumbers = service.Sort(new int[] { n1, n2, n3, n4, n5 }, type.ToLower() == "descending");
                        Console.WriteLine();
                        Console.WriteLine(String.Join(", ", sortedNumbers));
                        return;
                    }
                default:
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid choice");
                        return;
                    }
            }
        }

        static int ReadInt(string message)
        {
            while (true)
            {
                Console.Write(message);

                if (int.TryParse(Console.ReadLine(), out var a))
                {
                    return a;
                }

                Console.WriteLine();
                Console.WriteLine("Not an integer");
                Console.WriteLine();
            }
        }

        static string ReadString(string message, params string[] allowedValues)
        {
            while (true)
            {
                Console.Write(message);
                var input = Console.ReadLine();

                if (allowedValues.Length == 0 || allowedValues.Any(v => v.ToLower() == input.ToLower()))
                {
                    return input;
                }

                Console.WriteLine();
                Console.WriteLine("Not a valid option");
                Console.WriteLine();
            }
        }
    }
}
