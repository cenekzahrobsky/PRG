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
            string soustava = null;
            int cisloSoustavy = 0;
            Console.WriteLine("Hello, World!");

            while (true)
            {
                Console.WriteLine("Vyberte operaci"); //Zeptám se uživatele, jakou operaci chce dělat
                Console.WriteLine("1 - scitani, 2 - odcitani, 3 - nasobeni, 4 - deleni, 5 - mocnina a na b, 6 - prevod soustav, 7 - druha mocnina, 8 - odmocnina, 9 - logaritmus");
                int operation = int.Parse(Console.ReadLine()); //Zavedu si proměnnou, do které to uložím
                Console.WriteLine();
               
                Console.WriteLine("Zadej a"); 
                int a = int.Parse(Console.ReadLine()); //Proměnná a pro první číslo
                Console.WriteLine();

                if (operation == 6)  //Když je zvolená operace "prevod soustav", potřebuji ještě vědět, na kterou soustavu chce uživatel číslo a převádět
                {
                    Console.WriteLine("Na kterou soustavu chces cislo a prevadet?");
                    cisloSoustavy = int.Parse(Console.ReadLine()); //Uložím do proměnné cisloSoustavy
                }
                
                int b = 0; //Zavedu proměnnou b pro druhé číslo od uživatele
                if (operation <6) //Cislo b nepotřebuju pro operace větší než 6
                {
                    Console.WriteLine("Zadej b");
                    b = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }

                double result = 0.0; //Zavedu proměnnouy pro výsledek (s použitím desetinných čísel)

                switch (operation) 
                {
                    case 1: 
                        result = a + b; //sčítání
                        break;
                    
                    case 2: 
                        result = a - b; //odčítání
                        break;

                    case 3: 
                        result = a * b; //násobení
                        break;

                    case 4:
                        if (b == 0) //ochrana proti dělení nulou
                        {
                            Console.WriteLine();
                            Console.WriteLine("Nesmite delit 0");
                            continue;
                        }
                        result = Convert.ToDouble(a) / b; //dělení
                        break;

                    case 5: 
                        result = Math.Pow(a, b); //mocnění
                        break;

                    case 6:
                        soustava = Convert.ToString(a, cisloSoustavy); //prevod soustav
                        break;

                    case 7: 
                        result = Math.Pow(a, 2); //na druhou
                        break;

                    case 8: 
                        result = Math.Sqrt(a); //odmocnina
                        break;

                    case 9: 
                        result = Math.Log(a); //logaritmus
                        break;

                    

                    default:
                        Console.WriteLine("Nevalidni operace"); //pri zadání čísla operace mimo rozsah
                        break;

                }
                if (operation <6 || operation>6) //zobrazení výsledku pro operace, mimo prevodu soustav (to je string)
                Console.WriteLine("Vysledek je: "+result);
                
                if (operation == 6) //zobrazení výsledku pro prevod soustav
                    Console.WriteLine("cislo a ve vybrane soustave: "+ soustava);

                Console.WriteLine(); 
                Console.WriteLine("Chcete pokracovat? y/n");
                string con = Console.ReadLine();

                if (con != "y") //při stisknutí klávesy "y" se celý cyklus opakuje
                {
                    break;
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
