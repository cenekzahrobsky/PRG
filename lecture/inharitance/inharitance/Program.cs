using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inharitance
{
    internal class Program
    {
        class Animal
        {
            public string name;
            public int averageMaxAge;
            public int endangerment;
            
            public virtual void AnimalNoise()
            {
                Console.WriteLine("*happy animal soises*");
            }
            
            
        }

        class Dog:Animal 
        {
            public int numberOfPuppies;
            public string race;
            
            public override void AnimalNoise()
            {
                Console.WriteLine("Woof woof!");
            }
        }

        class Cat:Animal
        {
            public bool lovesMilk;
            public string furColor;
            
            public override void AnimalNoise()
            {
                Console.WriteLine("Meow");
            }
        }

        static void Main(string[] args)
        {
            Dog newDog = new Dog();
            newDog.name = "Fido";
            newDog.race = "Bullterier";
            Console.WriteLine($"name - {newDog.name}, race - {newDog.race}");
            newDog.AnimalNoise();

            Cat newCat = new Cat(); 
            newCat.name = "Micka";
            newCat.lovesMilk = true;
            newCat.furColor = "black";
            Console.WriteLine($"name - {newCat.name}, loves milk - {newCat.lovesMilk}, fur color - {newCat.furColor}");
            newCat.AnimalNoise();
            
            //Animal newDog = new Animal();
            newDog.AnimalNoise();

            Console.ReadKey();
        }
    }
}
