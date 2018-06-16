using System;
using System.Collections.Generic;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, SortedDictionary<string, List<long>>> army
                = new Dictionary<string, SortedDictionary<string, List<long>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string type = input[0];
                string name = input[1];

                long damage = input[2] == "null" ? 45 : long.Parse(input[2]);
                long health = input[3] == "null" ? 250 : long.Parse(input[3]);
                long armor = input[4] == "null" ? 10 : long.Parse(input[4]);

                List<long> stats = new List<long>();
                stats.Add(damage);
                stats.Add(health);
                stats.Add(armor);

                if (army.ContainsKey(type) == false)
                {
                    army.Add(type, new SortedDictionary<string, List<long>>());
                }

                if (army[type].ContainsKey(name) == false)
                {
                    army[type].Add(name, stats);
                }
                else
                {
                    army[type][name] = stats;
                }

            }

            foreach (var type in army)
            {
                double sumStr = 0.0;
                double sumHelath = 0.0;
                double sumArmor = 0.0;

                SortedDictionary<string, List<long>> namesWithStats = army[type.Key];

                foreach (var inside in namesWithStats)
                {
                    sumStr += namesWithStats[inside.Key][0];
                    sumHelath += namesWithStats[inside.Key][1];
                    sumArmor += namesWithStats[inside.Key][2];
                }

                Console.WriteLine($"{type.Key}::({(sumStr / namesWithStats.Count):f2}/" +
                                  $"{(sumHelath / namesWithStats.Count):f2}/" +
                                  $"{(sumArmor / namesWithStats.Count):f2})");

                foreach (var names in namesWithStats)
                {
                    Console.WriteLine($"-{names.Key} -> damage: {names.Value[0]}, health: {names.Value[1]}, armor: {names.Value[2]}");
                }
            }

        }
    }
}