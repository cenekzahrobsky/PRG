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
            string binary = null;
            Console.WriteLine("Hello, World!");

            while (true)
            {
                Console.WriteLine("Vyberte operaci");
                Console.WriteLine("1 - scitani, 2 - odcitani, 3 - nasobeni, 4 - deleni, 5 - mocnina a na b, 6 - druha mocnina, 7 - odmocnina, 8 - logaritmus, 9 - binarni kod");
                int operation = int.Parse(Console.ReadLine());
                Console.WriteLine();
               
                Console.WriteLine("Zadej a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine();
                
                int b = 0;
                if (operation <6)
                {
                    Console.WriteLine("Zadej b");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                double result = 0.0;

                switch (operation)
                {
                    case 1: 
                        result = a + b;
                        break;
                    
                    case 2: 
                        result = a - b;
                        break;

                    case 3: 
                        result = a * b;
                        break;

                    case 4:
                        if (b == 0)
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nesmite delit 0");
                            continue;
                        }
                        result = Convert.ToDouble(a) / b;
                        break;

                    case 5: 
                        result = Math.Pow(a, b);
                        break;

                    case 6: 
                        result = Math.Pow(a, 2);
                        break;

                    case 7: 
                        result = Math.Sqrt(a);
                        break;

                    case 8: 
                        result = Math.Log(a);
                        break;

                    case 9:
                        binary = Convert.ToString(a, 2);
                        break;

                    default:
                        Console.WriteLine("Nevalidni operace");
                        break;

                }
                if (operation < 9)
                Console.WriteLine("Vysledek je: "+result);
                
                if (operation == 9)
                    Console.WriteLine("cislo a v binarim kodu: "+ binary);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Chcete pokracovat? y/n");
                string con = Console.ReadLine();

                if (con != "y")
                {
                    break;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
