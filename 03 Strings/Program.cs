using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string dumi = Console.ReadLine();
            string shablon = Console.ReadLine();
            while (dumi.Contains(shablon)  &&shablon.Length != 0)
            {
                int index = dumi.LastIndexOf(shablon);
                
                int n = shablon.Length;
               dumi = dumi.Remove(index, n);
                //Console.WriteLine(dumi);

                int newIndex = shablon.Length / 2;
                shablon = shablon.Remove(newIndex, 1);
               // Console.WriteLine(shablon);

                char[] charset = shablon.ToCharArray();
                 Array.Reverse(charset);
                shablon = string.Join("", charset);
                //Console.WriteLine(shablon);

            }
            Console.WriteLine(dumi);
        }


    }
}

