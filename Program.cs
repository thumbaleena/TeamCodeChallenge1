using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How big is the array?");
            int size = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[,] arraytoCheck = new int[size, size];
 //           Console.WriteLine(CheckDiagArray(size, arraytoCheck));

            for (int row = 0; row < size; row++)
            {
                Console.WriteLine("Enter values for row {0}:", row+1);
                for (int column = 0; column < size; column++)
                {
                    inputDataToArray(row, column, arraytoCheck);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Is the array symmetrical?");
            Console.WriteLine(CheckDiagArray(size, arraytoCheck));
        }

        private static void inputDataToArray(int row, int column,int[,] array) // this method gets the input from the user (array size)
        {
            array[row, column] = int.Parse(Console.ReadLine());
        }



        private static bool CheckDiagArray(int size, int[,] arraytoCheck)  // this method iterates through all the values in the array, using the "size" to set row/column size
        {
            for (int row = 0; row < size; row++)
            {
                for (int column = 0; column < size; column++)
                {
                    if (!(GetDiagEquals(arraytoCheck, row, column))) return false;
                }
            }
            return true;
        }

        static bool GetDiagEquals(int[,] array, int rowToCheck, int columnToCheck)  // this method checks the numbers against each other - it just flips the (x,y) values to get the opposite, to check if they are the same number
        {
            if (array[rowToCheck, columnToCheck] == array[columnToCheck, rowToCheck])
            {
                return true;
            }
            else return false;
        }



    }
}
