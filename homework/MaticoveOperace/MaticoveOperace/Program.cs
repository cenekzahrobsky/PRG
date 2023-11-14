using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MaticoveOperace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] resultArray;

            // Main loop for array operations
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Kolik chces radku pro prvni matici?");
            int row1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Kolik chces sloupcu pro prvni matici?");
            int col1 = int.Parse(Console.ReadLine());
            int[,] array1 = CreateArray(row1, col1);

            Console.WriteLine("Prvni matice:");
            PrintArray(array1);
            Console.Write("\n");

            while (true)
            {
                

                int operation = OperationChoice();
                if (operation == -1)
                {
                    Console.WriteLine("Vybrana operace neexistuje");
                    continue;
                }

                // Perform the chosen operation
                resultArray = DoOperation(operation, array1);

                Console.WriteLine("Vysledna matice:");
                PrintArray(resultArray);

                Console.WriteLine("Chces pokracovat? (y/n)");
                string continueOption = Console.ReadLine();
                if (continueOption != "y")
                {
                    break;
                }
            }
            Console.ReadKey();
        }

        // Function to create an array based on user input
        static int[,] CreateArray(int rows, int cols)
        {
            int[,] array = new int[rows, cols];
            Console.WriteLine("Vyber zpusob vyplneni matice:");
            Console.WriteLine("1: postupka od 1 do x*y (1,2,3,...)");
            Console.WriteLine("2: nahodna cisla");
            int typeOfArray = int.Parse(Console.ReadLine());

            switch (typeOfArray)
            {
                case 1:
                    int numToAdd = 1;
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array[i, j] = numToAdd;
                            numToAdd++;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("Vyber horni hranici generovani cisel 'x'");
                    Console.WriteLine("(Nahodna cisla se vygeneruji z intervalu 1 az x)");
                    int x = int.Parse(Console.ReadLine());
                    Random rnd = new Random();
                    for (int i = 0; i < array.GetLength(0); i++)
                    {
                        for (int j = 0; j < array.GetLength(1); j++)
                        {
                            array[i, j] = rnd.Next(1, x);
                        }
                    }
                    break;
            }
            return array;
        }

        // Function to prompt the user to choose an array operation
        static int OperationChoice()
        {
            Console.WriteLine("Vyber operaci:");
            Console.WriteLine("1: Vymena dvou prvku");
            Console.WriteLine("2: Vymena dvou radku");
            Console.WriteLine("3: Vymena dvou sloupcu");
            Console.WriteLine("4: Vynasobeni matice cislem");
            Console.WriteLine("5: Otoceni poradi prvku diagonaly");
            Console.WriteLine("6: Transpozice");
            Console.WriteLine("7: Secteni dvou matic");
            Console.WriteLine("8: Odecteni dvou matic");
            Console.WriteLine("9: Vynasobeni dvou matic");

            if (int.TryParse(Console.ReadLine(), out int operation))
            {
                if (operation >= 1 && operation <= 9)
                {
                    return operation;
                }
            }
            return -1;
        }

        // Function to print an array
        static void PrintArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Function to perform the chosen array operation
        static int[,] DoOperation(int operation, int[,] array1)
        {
            int[,] resultArray;
            int diagonal;
            int[,] array2;

            switch (operation)
            {
                case 1:
                    resultArray = ElementSwap(array1);
                    break;
                case 2:
                    resultArray = RowSwap(array1);
                    break;
                case 3:
                    resultArray = ColumnSwap(array1);
                    break;
                case 4:
                    resultArray = MultiplyArray(array1);
                    break;
                case 5:
                    diagonal = DiagonalChoice();
                    resultArray = ReverseDiagonals(array1, diagonal);
                    break;
                case 6:
                    resultArray = TransposeArray(array1);
                    break;
                case 7:
                    array2 = CreateArray(array1.GetLength(0), array1.GetLength(1));
                    Console.WriteLine("Druha matice:");
                    PrintArray(array2);
                    Console.Write("\n");
                    resultArray = AddArrays(array1, array2);
                    break;
                case 8:
                    array2 = CreateArray(array1.GetLength(0), array1.GetLength(1));
                    Console.WriteLine("Druha matice:");
                    PrintArray(array2);
                    Console.Write("\n");
                    resultArray = SubtractArrays(array1, array2);
                    break;
                case 9:
                    array2 = CreateArray(array1.GetLength(0), array1.GetLength(1));
                    Console.WriteLine("Druha matice:");
                    PrintArray(array2);
                    Console.Write("\n");
                    resultArray = MultiplyArrays(array1, array2);
                    break;
                default:
                    return array1;
            }
            return resultArray;
        }

        // Function to swap two elements in the array
        static int[,] ElementSwap(int[,] array)
        {
            Console.WriteLine("Zadej souradnice prvniho z prvku, ktere chces prohodit, soradnice zadavej po jednom (prvni prvek je 1,1):");
            int xFirst = int.Parse(Console.ReadLine()) - 1;
            int yFirst = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Zadej souradnice druheho z prvku, ktere chces prohodit, soradnice zadavej po jednom (prvni prvek je 1,1):");
            int xSecond = int.Parse(Console.ReadLine()) - 1;
            int ySecond = int.Parse(Console.ReadLine()) - 1;

            int temp = array[xFirst, yFirst];
            array[xFirst, yFirst] = array[xSecond, ySecond];
            array[xSecond, ySecond] = temp;
            return array;
        }

        // Function to swap two rows in the array
        static int[,] RowSwap(int[,] array)
        {
            Console.WriteLine("Zadej souradnice prvniho z radku, ktere chces prohodit:");
            int nRowSwap = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Zadej souradnice druheho z radku, ktere chces prohodit:");
            int mRowSwap = int.Parse(Console.ReadLine()) - 1;

            int[] tempArrrayR = new int[array.GetLength(1)];

            for (int j = 0; j < array.GetLength(1); j++)
            {
                tempArrrayR[j] = array[nRowSwap, j];
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[nRowSwap, j] = array[mRowSwap, j];
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[mRowSwap, j] = tempArrrayR[j];
            }
            return array;
        }

        // Function to swap two columns in the array
        static int[,] ColumnSwap(int[,] array)
        {
            Console.WriteLine("Zadej souradnice prvniho ze sloupcu, ktere chces prohodit:");
            int nColSwap = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Zadej souradnice druheho ze sloupcu, ktere chces prohodit:");
            int mColSwap = int.Parse(Console.ReadLine()) - 1;

            int[] tempArrrayC = new int[array.GetLength(0)];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                tempArrrayC[i] = array[i, nColSwap];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, nColSwap] = array[i, mColSwap];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                array[i, mColSwap] = tempArrrayC[i];
            }
            return array;
        }

        // Function to multiply the array by a chosen number
        static int[,] MultiplyArray(int[,] array)
        {
            Console.WriteLine("Zadej cislo, kterym chces matici nasobit:");
            int multiplier = int.Parse(Console.ReadLine());
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] resultArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultArray[i, j] = array[i, j] * multiplier;
                }
            } 
            return resultArray;
        }

        // Function to prompt the user to choose a diagonal
        static int DiagonalChoice()
        {
            Console.WriteLine("Vyber diagonalu:");
            Console.WriteLine("1 - Hlavni diagonala, 2 - Vedlejsi diagonala");
            int diagonal = int.Parse(Console.ReadLine());

            if (diagonal >= 1 && diagonal <= 2)
            {
                return diagonal;
            }
            return -1;
        }

        // Function to reverse the order of elements on the main or secondary diagonal
        static int[,] ReverseDiagonals(int[,] array, int diagonal)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] resultArray = new int[rows, cols];

            // Copy unchanged elements from the initial array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultArray[i, j] = array[i, j];
                }
            }

            // Reverse the main diagonal
            if (diagonal == 1)
            {
                for (int i = 0; i < rows; i++)
                {
                    resultArray[i, i] = array[rows - 1 - i, rows - 1 - i];
                }
            }

            // Reverse the secondary diagonal
            if (diagonal == 2)
            {
                for (int i = 0; i < rows; i++)
                {
                    resultArray[i, rows - 1 - i] = array[rows - 1 - i, i];
                }
            }
            return resultArray;
        }

        // Function to transpose the array
        static int[,] TransposeArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            int[,] resultArray = new int[cols, rows];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    resultArray[i, j] = array[j, i];
                }
            }
            return resultArray;
        }

        // Function to multiply two arrays
        static int[,] MultiplyArrays(int[,] array1, int[,] array2)
        {
            int rows = array1.GetLength(0);
            int cols = array1.GetLength(1);

            int[,] resultArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    for (int k = 0; k < cols; k++)
                    {
                        resultArray[i, j] += array1[i, k] * array2[k, j];
                    }
                }
            }
            return resultArray;
        }

        // Function to add two arrays
        static int[,] AddArrays(int[,] array1, int[,] array2)
        {
            int rows = array1.GetLength(0);
            int cols = array1.GetLength(1);

            int[,] resultArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultArray[i, j] = array1[i, j] + array2[i, j];
                }
            }
            return resultArray;
        }

        // Function to subtract two arrays
        static int[,] SubtractArrays(int[,] array1, int[,] array2)
        {
            int rows = array1.GetLength(0);
            int cols = array1.GetLength(1);

            int[,] resultArray = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    resultArray[i, j] = array1[i, j] - array2[i, j];
                }
            }
            return resultArray;
        }
    }
}     
