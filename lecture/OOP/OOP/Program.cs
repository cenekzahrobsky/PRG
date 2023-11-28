using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Lojza",29,178.1f,79.4f,"Brown","Green");
            human1.PrintCharacteristics();
            Console.WriteLine($"{human1.name} má BMI {human1.BMI()}");

            Human human2 = new Human("Karel",38,197.5f,88.6f);
            human2.PrintCharacteristics();
            Console.WriteLine($"{human2.name} má BMI {human2.BMI()}");
            Console.WriteLine($"{human2.name} má věk {human2.GetAge()}");
            human2.SetAge(58);
            human2.SetAge(300);
            human2.PrintCharacteristics();
            human2.SetAge(58);
            human2.PrintCharacteristics();
            human2.SetAge("hfd");
            human2.PrintCharacteristics();

            Console.ReadKey();

        }
    }
}
