using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();
            List<string> allComm = new List<string>();
            while (!String.Equals(command, "print"))
            {
                allComm.Add(command);
                command = Console.ReadLine();
            }
            List<string> otdelno = new List<string>();
            int element = 0;
            for (int i = 0; i < allComm.Count; i++)
            {
                otdelno = allComm[i].Split(' ').ToList();
                string com = otdelno[0];
                
                if (String.Equals(com, "push"))
                {
                    element = int.Parse(otdelno[1]);
                    input.Add(element);
                }
                else
                {
                    if (String.Equals(com, "pop"))
                    {
                        element = input[input.Count - 1];
                        Console.WriteLine(element);
                        input.Remove(element);
                    }
                    else
                    {
                        if (String.Equals(com, "shift"))
                        {
                            element = input[input.Count - 1];
                            input[input.Count - 1] = input[0];
                            input[0] = element;
                            
                        }
                        else
                        {
                            if (String.Equals(com, "addMany"))
                            {
                                element = int.Parse(otdelno[1]);
                                List<int> many = new List<int>();
                                for (int y = 2; y < otdelno.Count; y++)
                                {
                                    many.Add(int.Parse(otdelno[y]));
                                }
                                //Console.WriteLine(string.Join(" , ",many));
                                if (element>0 && element < input.Count)
                                {
                                    input.InsertRange(element, many);

                                }
                                 
                                
                            }
                            else
                            {
                                if (String.Equals(com, "remove"))
                                {
                                    element = int.Parse(otdelno[1]);
                                    if (element > 0 && element < input.Count)
                                    {
                                        input.RemoveAt(element);
                                    }

                                }
                                
                                    

                                
                            }
                        }
                    }
                }
            }
            input.Reverse();
             Console.WriteLine(string.Join(", ", input));  
        }
    }
}
