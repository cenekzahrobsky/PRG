using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KamenNuzkyPapir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrac = 0;
            int pocitac = 0;
            while (true)
            {
                Console.WriteLine("Vyberte akci, (pro ukonceni zvolte 4)");
                Console.WriteLine("1 - kamen, 2 - nuzky, 3 - papir");
                int akce = int.Parse(Console.ReadLine());
                Random rnd = new Random();
                int a = rnd.Next(3);
                if (akce == 1)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("Souper zvolil kamen, Remíza!");
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine("Souper zvolil nuzky, Výhra!");
                        hrac++;
                    }
                    else
                    {
                        Console.WriteLine("Souper zvolil papir, Prohra!");
                        pocitac++;
                    }
                }
                else if (akce == 2)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("Souper zvolil kamen, Prohra!");
                        pocitac++;
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine("Souper zvolil nuzky, Remíza!");
                    }
                    else
                    {
                        Console.WriteLine("Souper zvolil papir, Vyhra!");
                        hrac++;
                    }
                }
                else if (akce == 3)
                {
                    if (a == 1)
                    {
                        Console.WriteLine("Souper zvolil kamen, Vyhra!");
                        pocitac++;
                    }
                    else if (a == 2)
                    {
                        Console.WriteLine("Souper zvolil nuzky, Prohra!");
                        hrac++;
                    }
                    else
                    {
                        Console.WriteLine("Souper zvolil papir, Remíza!");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Konecne skore je: " + hrac + ":" + pocitac);
                    Console.ReadKey();
                    break;
                    
                }
            }

        }
    }
}
