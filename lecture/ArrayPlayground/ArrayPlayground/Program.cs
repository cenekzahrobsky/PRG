using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array:");
            //TODO 1: Vytvoř integerové pole a naplň ho pěti čísly.
            int[] Array = {1,2,3,4,5};
            int sum = 0;
            int max = Array[0];
            int min = Array[0];
            
            //TODO 2: Vypiš do konzole všechny prvky pole, zkus klasický for, kde i využiješ jako index v poli, a foreach (vysvětlíme si).
            foreach (int number in Array)
            {
                Console.WriteLine(Array[number - 1]);
            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
                sum += Array[number - 1];
            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
                if (Array[number - 1] > max)
                    max = Array[number - 1];
            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
                if (Array[number - 1] < min)
                    min = Array[number];
            }
            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum / Array.Length;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Max: {max}");
            Console.WriteLine(Array.Max());
            Console.WriteLine($"Min: {min}");

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            int index;
            int userNum = int.Parse(Console.ReadLine());
            bool foundNum = false;
            for (int i = 0; i < Array.Length; i++)
            {
                if (userNum == Array[i])
                {
                    foundNum = true;
                    Console.WriteLine($"Num: {userNum} is on index {i}");
                }
            }
            if (foundNum==false)
                Console.WriteLine("jsi kokot");

            //TODO 8: Změň tvorbu integerového pole tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9. Vytvoř si na to proměnnou typu Random.
            Random rnd = new Random();
            int[] Array1 =new int[100];
            foreach (int value in Array1) 
                rnd.Next(9);


                //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
                int[] counts = new int[10];

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.


            Console.ReadKey();
        }
    }
}
