using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            while (true)
            {
                int operation = ZvoleniOperace();
                if (operation == -1)
                {
                    Console.WriteLine("Zvolená operace neexistuje");
                    continue;
                }

                float result = ProvedeniOperace(operation);
                ZobrazitVysledek(operation, result);

                Console.WriteLine("Do you want to continue? (y/n)");
                string con = Console.ReadLine();

                if (con != "y")
                {
                    break;
                }
            }

            Console.ReadKey();
        }

        static int ZvoleniOperace()
        {
            Console.WriteLine("Vyber operaci:");
            Console.WriteLine("1 - Sčítání, 2 - Odčítání, 3 - Násobení, 4 - Dělení, 5 - Exponenciály, 6 - Logaritmus, 7 - Převod soustav, 8 - Na druhou, 9 - Odmocnina");

            if (int.TryParse(Console.ReadLine(), out int operation))
            {
                if (operation >= 1 && operation <= 9)
                {
                    return operation;

                }
            }
            return -1;
        }

        static float ProvedeniOperace(int operation)
        {
            if (operation==6)
            { 
                Console.WriteLine("Logaritmus o základu a s argumentem b");
            }

            Console.WriteLine("Zadej 'a':");
            float a = float.Parse(Console.ReadLine());

            float b = 0;

            if (operation < 7)
            {
                Console.WriteLine("Zadej 'b':");
                b = float.Parse(Console.ReadLine());
            }

            switch (operation)
            {
                case 1:
                    return a + b;

                case 2:
                    return a - b;

                case 3:
                    return a * b;

                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine("Nulou nelze dělit");
                        return float.NaN;
                    }
                    return a / b;

                case 5:
                    return (float)Math.Pow(a, b);
                
                case 6:
                    return (float)Math.Log(b, a);

                case 7:
                    Console.WriteLine("Vyber si do jaké soustavy chceš číslo prevést:");
                    int soustava = int.Parse(Console.ReadLine());
                    return PrevodSoustavy(a, soustava);

                case 8:
                    return a * a;

                case 9:
                    return (float)Math.Sqrt(a);

                

                default:
                    Console.WriteLine("Zvolená operace neexistuje.");
                    return float.NaN;
            }
        }

        static float PrevodSoustavy(float number, int soustava)
        {
            return float.Parse(Convert.ToString(Convert.ToInt64(number), soustava));
        }

        static void ZobrazitVysledek(int operation, float result)
        {
            if (float.IsNaN(result))
            {
                return;
            }

            if (operation == 7)
            {
                Console.WriteLine("Číslo ve vybraseé soustavě: "+result);
            }
            else
            {
                Console.WriteLine("Výsledek: "+result);
            }
        }
    }
}


