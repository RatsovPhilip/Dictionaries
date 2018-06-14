using System;
using System.Collections.Generic;
using System.Linq;

namespace _08
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTimes = int.Parse(Console.ReadLine());
            var usersInfo = new SortedDictionary<string, SortedDictionary<string, int>>();

            for (int i = 0; i < nTimes; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                string ip = input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);

                if (usersInfo.ContainsKey(name) == false)
                {
                    usersInfo.Add(name, new SortedDictionary<string, int>());
                }

                if (usersInfo[name].ContainsKey(ip) == false)
                {
                    usersInfo[name].Add(ip, 0);
                }

                usersInfo[name][ip] += duration;



            }



            foreach (var user in usersInfo)
            {

                int sum = user.Value.Values.Sum();

                Console.Write($"{user.Key}: {sum} ");
                Console.Write("[");
                Console.Write(string.Join(", ",user.Value.Keys));
                Console.WriteLine("]");

            }

        }
    }
}
