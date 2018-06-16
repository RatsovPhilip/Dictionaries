using System;
using System.Collections.Generic;
using System.Linq;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split('@');

            Dictionary<string, Dictionary<string, decimal>> allInfo =
                new Dictionary<string, Dictionary<string, decimal>>();

            while (true)
            {
                if (input[0] == "End")
                {
                    break;
                }

                try
                {
                    string singer = input[0].Trim();
                    List<string> inputSecondPart = input[1].Split().ToList();
                    long ticketPrice = long.Parse(inputSecondPart[inputSecondPart.Count - 1]);
                    long ticketCount = long.Parse(inputSecondPart[inputSecondPart.Count - 2]);
                    inputSecondPart.RemoveAt(inputSecondPart.Count - 1);
                    inputSecondPart.RemoveAt(inputSecondPart.Count - 1);
                    string place = string.Join(" ", inputSecondPart);
                    decimal sumOfTickets = ticketPrice * ticketCount;

                    if (allInfo.ContainsKey(place) == false)
                    {
                        allInfo.Add(place, new Dictionary<string, decimal>());
                    }

                    if (allInfo[place].ContainsKey(singer) == false)
                    {
                        allInfo[place].Add(singer, 0);
                    }

                    allInfo[place][singer] += sumOfTickets;

                }
                catch (Exception)
                {
                input = Console.ReadLine().Split('@');
                    continue;
                }

                input = Console.ReadLine().Split('@');


            }

            foreach (var place in allInfo)
            {
                Console.WriteLine(place.Key);

                Dictionary<string, decimal> singersAndPrices = allInfo[place.Key];

                foreach (var singer in singersAndPrices.OrderByDescending(x=>x.Value))
                {
                    
                    Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
                }
            }

        }
    }
}
