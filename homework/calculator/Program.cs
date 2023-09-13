namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            while (true)
            {   
                Console.WriteLine("Vyberte operaci");
                Console.WriteLine("1 - secti, 2 - odecti, 3 - vynasob, 4 - vydel, 5 - na druhou, 6 - odmocni");
                int operation = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine("Zadej a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine();

                int b = 0;
                if (operation < 5)
                {
                    Console.WriteLine("Zadej b");
                    b = int.Parse(Console.ReadLine());
                }


                

                double result = 0.0;

                if (operation == 1)
                {
                    result = a + b;
                }
                else if (operation == 2)
                {
                    result = a - b;
                }
                else if (operation == 3)
                {
                    result = a * b;
                }
                else if (operation == 4)
                {
                    if (b == 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nesmite delit 0");
                        continue;
                    }    

                    result = Convert.ToDouble(a) / b;
                }
                else if (operation == 5)
                {
                    result = Math.Pow(a, 2);
                }
                else if (operation == 6)
                {
                    result = Math.Sqrt(a);
                }
                else
                {
                    Console.WriteLine("Nevalidni cislo operace");
                    continue;
                }

                Console.WriteLine("Vysledek je");
                Console.WriteLine(result);

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