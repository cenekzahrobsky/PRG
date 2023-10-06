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

            while (true) //cyklus
            {
                int operace = ZvoleniOperace(); //zavolani funkce, která načte od uživatele, kterou operaci chce provadet
                if (operace == -1) //když uživatel vybere operaci, ktera neexistuje, vyhodi mu to hlasku
                {
                    Console.WriteLine("Zvolená operace neexistuje");
                    continue;
                }

                float vysledek = ProvedeniOperace(operace); //deklaruje promennou vysledek, pro kterou zavola funkci, která provede vybranou operaci
                ZobrazitVysledek(operace, vysledek); //zavola funkci pro zobrazeni vysledku

                Console.WriteLine("Chcete pokračovat? (y/n)"); //zepta se uzivatele, jestli chce pokracovat, pokud ano cyklus se opakuje, pokud ne, cyklus skonci
                string pokracovat = Console.ReadLine();
                if (pokracovat != "y")
                {
                    break;
                }
            }

            Console.ReadKey(); //ceka nez uzivatel stiskne jakoukoliv klavesu, potom se aplikace vypne
        }

        static int ZvoleniOperace() //funkce pro nacteni zvolene operace uzivatelem
        {
            Console.WriteLine("Vyber operaci:"); //zepta se jakou operaci chce
            Console.WriteLine("1 - Sčítání, 2 - Odčítání, 3 - Násobení, 4 - Dělení, 5 - Exponenciály, 6 - Logaritmus, 7 - Převod soustav, 8 - Na druhou, 9 - Odmocnina");

            if (int.TryParse(Console.ReadLine(), out int operace)) //pokud je operace vybrana z rozsahu, ulozi se do promenne "operace"
            {
                if (operace >= 1 && operace <= 9)
                {
                    return operace;

                }
            }
            return -1; //pokud ne, vrati to "-1", coz mu na radku 19 vyhodi hlasku
        }

        static float ProvedeniOperace(int operace) //funkce pro provedeni zvolene operace
        {
            if (operace == 6) //pokud je zvolena operace "6" (logaritmus), napise uzivateli, jak cisla do logaritmu zadat
            { 
                Console.WriteLine("Logaritmus o základu a s argumentem b");
            }

            Console.WriteLine("Zadej 'a':"); //napise uzivateli, aby zadal "a"
            float a = float.Parse(Console.ReadLine()); //promennou "a" nacte a konvertuje ji do floatu

            float b = 0; //deklaruje promennou b

            if (operace < 7) //pokud jsou zvoleny operace vetsi nez 7, neni na ne potreba druha promenna
            {
                Console.WriteLine("Zadej 'b':"); //pokud ano, napise uzivateli, aby ji zadal
                b = float.Parse(Console.ReadLine()); //vstup konvertuje a ulozi do "b"
            }

            switch (operace) //switch - podle toho jaka operace byla zvolena, takovy case se provede
            {
                case 1:
                    return a + b; //scitani

                case 2:
                    return a - b; //odcitani

                case 3:
                    return a * b; //nasobeni

                case 4:
                    if (b == 0) 
                    {
                        Console.WriteLine("Nulou nelze dělit"); //ochrana pred deleni nulou
                        return float.NaN; //pokud uzivatel vydeli nulou, vrati to necislo
                    }
                    return a / b; //deleni

                case 5:
                    return (float)Math.Pow(a, b); //expo
                
                case 6:
                    return (float)Math.Log(b, a); //log

                case 7:
                    Console.WriteLine("Zvol soustavu (2,8,16)"); //zepta se uzivatele na kterou soustavu chce prevadet
                    int soustava = int.Parse(Console.ReadLine()); //tuto informaci nacte do promenne "soustava"
                    return float.Parse(Convert.ToString(Convert.ToInt64(a), soustava)); //prevod soustav (chatgpt potahal)

                case 8:
                    return a * a; //na druhou

                case 9:
                    return (float)Math.Sqrt(a); //odmocnina

                default:  
                    Console.WriteLine("Zvolená operace neexistuje."); //pokud uzivatel zvoli neco jine nez 1-9 (rozsah operaci me kalkulacky), hodi mu to hlasku
                    return float.NaN; //vrati to necislo
            }
        }

        static void ZobrazitVysledek(int operace, float vysledek) //funkce pro zobrazeni vysledku
        {
            if (float.IsNaN(vysledek)) //pokud je vysledek necislo, vysledek se nezobrazi
            {
                return;
            }

            if (operace == 7) //pokud je operace "7" (prevod soustav), zobrazi se vysledek jinak formulovan
            {
                Console.WriteLine("Číslo ve vybrané soustavě: "+ vysledek);
            }
            else //jinak se vysledek zobrazi normalne
            {
                Console.WriteLine("Výsledek: "+ vysledek);
            }
        }
    }
}


