using System;
using System.Collections.Generic;
using System.Linq;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> output = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();

                if (resource == "stop")
                {
                    break;
                }

                int resourceQuantity = int.Parse(Console.ReadLine());

                if (output.ContainsKey(resource))
                {
                    output[resource] += resourceQuantity;
                }
                else
                {
                    output.Add(resource, resourceQuantity);
                }

            }

            foreach (KeyValuePair<string, int> item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");

            }

        }
    }
}