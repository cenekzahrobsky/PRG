using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        public string name;
        int age;
        public float height;
        public float weight;
        public string hairColor;
        public string eyeColor;
        
        public Human(string name, int age, float height, float weight, string hairColor, string eyeColor)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
            this.hairColor = hairColor;
            this.eyeColor = eyeColor;
        }

        public Human(string name, int age, float height, float weight)
        {
            this.name = name;
            this.age = age;
            this.height = height;
            this.weight = weight;
        }

        public float BMI()
        {
            float heightForCalculation = height / 100f;
            float bmi = weight / (heightForCalculation * heightForCalculation);
            return bmi;
        }
        public int GetAge()
        {
            return age;
        }

        public void SetAge(int age) 
        {
            if (age < 0 || age > 120) Console.WriteLine("Tento věk není možné zadat");
            else 
            { 
                this.age = age;
                Console.WriteLine($"Věk změněn na: {age}");
            }
        }

        public void SetAge(string age)
        {
            bool isNumber = int.TryParse(age, out int ageNumber);
            if (isNumber)
            { 
                SetAge(ageNumber);
                Console.WriteLine($"Věk změněn na: {age}");
            }
            else Console.WriteLine("Zadej cislo more");
        }

        public void PrintCharacteristics()
        {
            string printedHairColor = hairColor;
            if (printedHairColor == null) printedHairColor = "Neznámá";
            string printedEyeColor = eyeColor;
            if (printedEyeColor == null) printedEyeColor = "Neznámá";

            Console.WriteLine($"{name} je starý/á {age} let, měří {height} centimetrů, váží {weight} kilogramů, barva vlasů je: {printedHairColor}, barva očí je: {printedEyeColor}");
        }
    }
    
}
