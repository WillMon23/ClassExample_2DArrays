using System;

namespace Excersise_2
{
    class Program
    {
        static void Main(string[] args)
        {

                                                        /* 0  1  2 */
            int[,] array2DExample = new int[3, 3] { /*0*/{ 1, 2, 3 }, 
                                                    /*1*/{ 4, 5, 6, }, 
                                                    /*2*/{ 7, 8, 9 } };
                                            /* 0  1  3*/
            int[,] array2DExample2 = {  /*0*/{ 1, 2, 3 }, 
                                        /*1*/{ 4, 5, 6, }, 
                                        /*2*/{ 7, 8, 9 }, 
                                        /*3*/{ 10, 11, 12 } };

            TwoDPrinter(array2DExample2);

            for (int i = 0; 1 < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(array2DExample[i, j]);
                }
            }

            int[] TwoDPrinter(int[,] arr)
            {
                int[] addedValues = new int[arr.GetLength(0)];
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    int total = 0;
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        total += arr[i, j];
                    }
                    addedValues[i] = total;
                    Console.WriteLine(total);

                }
                return addedValues;
            }
        }
    }
}
