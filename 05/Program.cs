using System;
using System.Collections.Generic;
using System.Linq;

namespace _05
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> players = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(":").ToArray();

            while (true)
            {
                if (input[0] == "JOKER")
                {
                    break;
                }
                string name = input[0];
                List<string> cards = input[1].Trim().Split(", ").ToList();


                if (players.ContainsKey(name) == false)
                {

                    players.Add(name, new List<string>());
                }

                players[name].AddRange(cards);
                



                input = Console.ReadLine().Split(":").ToArray();
            }

            Dictionary<string, int> powers = new Dictionary<string, int>();

            for (int i = 2; i <= 9; i++)
            {
                powers[i.ToString()] = i;
            }

            powers.Add("1", 10);
            powers.Add("J", 11);
            powers.Add("Q", 12);
            powers.Add("K", 13);
            powers.Add("A", 14);

            powers.Add("S", 4);
            powers.Add("H", 3);
            powers.Add("D", 2);
            powers.Add("C", 1);


            foreach (var player in players)
            {
                List<string> cards = player.Value.Distinct().ToList();

                int sum = 0;

                foreach (var card in cards)
                {
                    string powerCardStr = card[0].ToString();
                    string colorCardStr = card[card.Length-1].ToString();

                    int powerCards = powers[powerCardStr];
                    int suitCards = powers[colorCardStr];

                    sum += powerCards * suitCards;

                }

                Console.WriteLine($"{player.Key}: {sum}");

            }
 
        }
    }
}
