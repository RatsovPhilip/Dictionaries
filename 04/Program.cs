using System;
using System.Collections.Generic;
using System.Linq;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> output = new Dictionary<string, string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name == "stop")
                {
                    break;
                }

                List<string> emailList = Console.ReadLine().Split('.').ToList();
                if (emailList[1] == "us" || emailList[1] == "uk")
                {
                    emailList.RemoveAt(0);
                    emailList.RemoveAt(0);
                }


                if (output.ContainsKey(name) == false)
                {
                    if (emailList.Count != 0)
                    {
                        string concat = emailList[0] + "." + emailList[1];
                        output[name] = concat;
                    }
                }
            }

            foreach (var item in output)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}