using System;
using System.Collections.Generic;
using System.Linq;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            SortedDictionary<string, string> phoneBook = new SortedDictionary<string, string>();

            List<string> result = new List<string>();

            while (input[0] != "END")
            {
                if (input[0] == "A")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        string name = input[1];
                        string phone = input[2];
                        phoneBook[name] = phone;
                    }
                    else
                    {
                        phoneBook.Add(input[1], input[2]);
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var item in phoneBook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }


                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]) == false)
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                    else
                    {

                        string foundName = input[1];
                        string foundNumber = phoneBook[foundName];

                        Console.WriteLine($"{foundName} -> {foundNumber}");


                    }

                }
                input = Console.ReadLine().Split().ToArray();

            }
        }
    }
}
