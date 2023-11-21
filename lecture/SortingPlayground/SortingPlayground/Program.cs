using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace SortingPlayground
{
    internal class Program
    {
        //Pokud si nejsi jistý/á, co dělat, podívej se do prezentace, na videa na YT, co jsem doporučoval, googluj a nebo mě zavolej a já ti poradím.

        static int[] BubbleSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            //TODO: Naimplementuj bubble sort.
            for (int i = 0; i < sortedArray.Length; i++)
            {
                for (int j = 0; j < sortedArray.Length - i-1; j++)
                {
                    if (sortedArray[j] > sortedArray[j + 1])
                    {
                        int tmp;
                        tmp = sortedArray[j];
                        sortedArray[j] = sortedArray[j + 1];
                        sortedArray[j + 1] = tmp;
                    }
                }
            }
            return sortedArray;
        }

        static int[] SelectionSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.                                          //TODO: Naimplementuj selection sort.
            for (int i = 0; i < sortedArray.Length; i++)
            {
                int min = i;
                for (int j = i; j < sortedArray.Length; j++)
                {
                    if (sortedArray[min] > sortedArray[j])
                        min = j;
                }
                int tmp = sortedArray[i];
                    sortedArray[i] = sortedArray[min];
                    sortedArray[min] = tmp;
            }
            return sortedArray;
        }

        static int[] InsertionSort(int[] array)
        {
            int[] sortedArray = (int[])array.Clone(); // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            //TODO: Naimplementuj insertion sort.
            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                int j = i + 1;
                int temp = sortedArray[j];
                while (j > 0 && temp < sortedArray[j - 1])
                {
                    sortedArray[j] = sortedArray[j - 1];
                    j--;
                }
                sortedArray[j] = temp;
            }
            return sortedArray;
        }

        static int[] Sort(int[] array, int start, int end)
        {
            int[] sortedArray = (int[])array.Clone();
            if (end > start)
            {
                int middle = (start + end) / 2;
                Sort(array, start, middle);
                Sort(array, middle + 1, end);
                sortedArray = MergeSort(array, start, middle, end);
            }
            return sortedArray;
        }

        static int[] MergeSort(int[] array, int start, int middle, int end)
        {
             // Řaď v tomto poli, ve kterém je výchoze zkopírováno všechno ze vstupního pole.
            int nl = middle - start + 1;
            int nr = end - middle;

            int[] tmpL = new int[nl];
            int[] tmpR = new int[nr];
            int i, j;

            for (i = 0; i < nl; i++)
                tmpL[i] = array[start + i];
            for (j = 0; j < nr; j++)
                tmpR[j] = array[middle + j + 1];

            i = 0;
            j = 0;
            int k = start;
            while (i < nl && j < nr)
            {
                if (tmpL[i] < tmpR[j])
                {
                    array[k] = tmpL[i];
                    i++;
                }
                else
                {
                    array[k] = tmpR[j];
                    j++;
                }
                k++;
            }
            while (i < nl)
            {
                array[k] = tmpL[i];
                i++;
                k++;
            }
            while (j < nr)
            {
                array[k] = tmpR[j];
                j++;
                k++;
            }
            return array;
        }

        //Naplní pole náhodnými čísly mezi 1 a velikostí pole.
        static void FillArray(int[] array)
        {
            Random rng = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rng.Next(1, array.Length + 1);
            }
        }

        //Vypíše pole do konzole.
        static void WriteArrayToConsole(int[] array, string arrayName)
        {
            Console.Write(arrayName + " = [");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]\n\n");
        }

        //Zavolá postupně Bubble sort, Selection sort a Insertion sort pro zadané pole (a vypíše jeho jméno pro přehlednost)
        static void SortArray(int[] array, string arrayName)
        {
            Console.WriteLine($"Řadím {arrayName}:");
            int[] sortedArray;

            sortedArray = BubbleSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Bubble sortem");

            sortedArray = SelectionSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Selection sortem");

            sortedArray = InsertionSort(array);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Insertion sortem");

            sortedArray = Sort(array, 0, array.Length - 1);
            WriteArrayToConsole(sortedArray, arrayName + " seřazené Merge sortem");

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int[] smallArray = new int[10];
            FillArray(smallArray);

            int[] mediumArray = new int[100];
            FillArray(mediumArray);

            int[] largeArray = new int[1000];
            FillArray(largeArray);

            WriteArrayToConsole(smallArray, "Malé pole");
            SortArray(smallArray, "Malé pole");

            WriteArrayToConsole(mediumArray, "Střední pole");
            SortArray(mediumArray, "Střední pole");

            WriteArrayToConsole(largeArray, "Velké pole");
            SortArray(largeArray, "Velké pole");

            Console.ReadKey();
        }
    }
}
