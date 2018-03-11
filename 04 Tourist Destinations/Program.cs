using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tourist_Destinations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> dest = Console.ReadLine().Split(' ').ToList();
            List<string> destinations = new List<string>();
            while (!dest.Contains("End"))
            {
                destinations.Add(string.Join(" ", dest));
                dest = Console.ReadLine().Split(' ').ToList();
            }
            //Console.WriteLine(string.Join(" >>>> ", destinations));
            List<string> otdelno = new List<string>();
            List<string> cities2 = new List<string>();
            Dictionary<string, List<string>> all = new Dictionary<string, List<string>>();
            for (int i = 0; i < destinations.Count; i++)
            {
                otdelno = destinations[i].Split(' ').ToList();
                if (String.Equals(otdelno[0], "Add"))
                {
                    if (all.ContainsKey(otdelno[1]))
                    {
                        all[otdelno[1]].Add(otdelno[2]);
                        cities2.Add(otdelno[2]);
                    }
                    else
                    {
                        List<string> cities = new List<string>();
                        cities.Add(otdelno[2]);
                        all[otdelno[1]] = cities;
                        cities2.Add(otdelno[2]);
                    }
                }
                else
                {
                    
                    
                    {
                        bool flag = false;
                        foreach (var pair in all.Values)
                        {
                            if (pair.Contains(otdelno[1]))
                            {
                                pair.Remove(otdelno[1]);
                                flag = true;
                            }
                        }
                        if (!flag )
                        {
                            Console.WriteLine($"City {otdelno[1]} not found");
                            

                        }
                    }
                }
            }
            all = all.OrderByDescending(pair => pair.Value.Count).ThenBy(pair => pair.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in all.Keys)
            {
                Console.WriteLine($"{item} has {all[item].Count} cities and they are: {string.Join(", ", all[item])}");
               
            }
        }
    }
}
