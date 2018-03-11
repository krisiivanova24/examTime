using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoVa__04_Tourist_Destinations
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
            destinations.Sort();
            destinations.Reverse();
            //Console.WriteLine(string.Join("   *****   ", destinations));
            List<string> otdelno = new List<string>();
            List<string> dyrj = new List<string>();
            List<string> all = new List<string>();
            string zaMahane = null;
            for (int i = 0; i < destinations.Count; i++)
            {
                dyrj = new List<string>();
                otdelno = destinations[i].Split(' ').ToList();
                if (String.Equals(otdelno[0], "Add"))
                {
                    if (!all.Contains(otdelno[1]))
                    {
                        if (!String.Equals(zaMahane, otdelno[2]))
                        {
                            dyrj.Add(otdelno[1]);
                            dyrj.Add(otdelno[2]);
                            all.Add(string.Join(" ", dyrj));
                        }
                        else
                        {
                            dyrj.Add(otdelno[1]);
                            all.Add(string.Join(" ", dyrj));
                        }

                    }
                    else
                    {
                        if (!String.Equals(zaMahane, otdelno[2]))
                        {
                            dyrj.Add(otdelno[2]);
                            //all.RemoveAt(i - 1);
                            all.Add(string.Join(" ", dyrj));


                        }

                    }
                }
                else
                {
                    zaMahane = otdelno[1];
                }
            }
            Console.WriteLine(string.Join(" - ", all));
        }
    }
}

