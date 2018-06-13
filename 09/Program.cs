using System;
using System.Collections.Generic;
using System.Linq;

namespace _09
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> correctItems = new Dictionary<string, int>();
            correctItems["shards"] = 0;
            correctItems["fragments"] = 0;
            correctItems["motes"] = 0;

            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();


            bool gameRunning = true;

            while (gameRunning)
            {

                string[] input = Console.ReadLine().ToLower().Split();

                for (int i = 0; i < input.Length - 1; i += 2)
                {
                    string item = input[i + 1];
                    int quantity = int.Parse(input[i]);

                    if (correctItems.ContainsKey(item) && gameRunning == true)
                    {
                        switch (item)
                        {
                            case "shards":
                                correctItems[item] += quantity;

                                if (correctItems[item] >= 250)
                                {
                                    correctItems[item] -= 250;
                                    Console.WriteLine("Shadowmourne obtained!");
                                    gameRunning = false;
                                }
                                break;

                            case "fragments":
                                correctItems[item] += quantity;

                                if (correctItems[item] >= 250)
                                {
                                    correctItems[item] -= 250;
                                    Console.WriteLine("Valanyr obtained!");
                                    gameRunning = false;
                                }
                                break;

                            case "motes":
                                correctItems[item] += quantity;

                                if (correctItems[item] >= 250)
                                {
                                    correctItems[item] -= 250;
                                    Console.WriteLine("Dragonwrath obtained!");
                                    gameRunning = false;
                                }
                                break;
                        }
                    }
                    else if (gameRunning == true)
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }
                        else
                        {
                            junkItems.Add(item, quantity);
                        }

                    }

                }

            }

            var sortedDict = correctItems.OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToList();

            foreach (var item in sortedDict)
            {

                Console.WriteLine($"{item.Key}: {item.Value}");


            }

            foreach (var junk in junkItems)
            {
                Console.WriteLine($"{junk.Key}: {junk.Value}");
            }
        }
    }
}