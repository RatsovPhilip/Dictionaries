using System;
using System.Collections.Generic;
using System.Linq;

namespace _01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {

                    phoneBook.Add(input[1], input[2]);

                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]) == false)
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    else
                    {
                   // Console.WriteLine($"{phoneBook.Key} -> {result.Value}");

                    }


                }

            input = Console.ReadLine().Split().ToArray();
            }

        }
    }
}

