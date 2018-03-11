using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise._1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal bitcoin = decimal.Parse(Console.ReadLine());
            decimal etereum = decimal.Parse(Console.ReadLine());
            decimal ligthcoin = decimal.Parse(Console.ReadLine());
            byte brTranzk = byte.Parse(Console.ReadLine());

            List<long> aktivi = new List<long>();
            List<string> valuti = new List<string>();
            List<string> doing = new List<string>();
            for (int i = 1; i <= brTranzk; i++)
            {
                long brAktivi = long.Parse(Console.ReadLine());
                aktivi.Add(brAktivi);
                string valuta = Console.ReadLine();
                valuti.Add(valuta);
                string buyOrSell = Console.ReadLine();
                doing.Add(buyOrSell);
            }
            
            decimal systoqnie = 0;
            decimal kom = 0; ;
            decimal[] systoqniq = new decimal[brTranzk];
            decimal[] comisionni = new decimal[brTranzk];
            for (int j = 0; j < brTranzk; j++)
            {
                if (String.Equals(valuti[j], "Bitcoin"))
                {
                    systoqnie = aktivi[j] * bitcoin;
                }
                else
                {
                    if (String.Equals(valuti[j], "Ethereum"))
                    {
                        systoqnie = aktivi[j] * etereum;
                    }
                    else
                    {
                        systoqnie = aktivi[j] * ligthcoin;
                    }
                }
                systoqniq[j] = systoqnie;
                kom = systoqnie * 0.073456764216789345M;
                comisionni[j] = kom;
                //Console.WriteLine(systoqnie);
                //Console.WriteLine(kom);
            }
            //Console.WriteLine(systoqnie);
            //Console.WriteLine(kom);
             systoqnie = 0;
             kom = 0; ;
            for (int i = 0; i < brTranzk; i++)
            {
                if (String.Equals(doing[i], "Buy"))
                {
                    systoqnie += systoqniq[i];
                }
                else
                {
                    systoqnie -= systoqniq[i];
                }
                
                kom += comisionni[i]; 
            }
            decimal res = systoqnie - kom;
            Console.WriteLine($"{res:f16}");
            //Console.WriteLine(systoqnie + " -");
            //Console.WriteLine(kom + " *");
        }
    }
}
