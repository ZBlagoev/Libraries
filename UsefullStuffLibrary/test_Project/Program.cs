using System;
using UsefullStuffLibrary;

namespace test_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            
            //int[,] leshta = Matrixes.MakeSqrMatrix(n);

            int[,] leshta = Matrixes.MakeRecMatrix(n, m);

            Matrixes.PrintMatrix(leshta);


            int[,] matrix = new int[1, 5];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            Console.WriteLine(matrix[0,4]);

            */

            /*
            // test filling a matrix
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");

                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // test printing matrix
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0, 4}", matrix[i, j]);
                }

                Console.WriteLine();
            }

            */

            // test filling a jagged array
            int row = int.Parse(Console.ReadLine());

            string[][] jagged = new string[row][];

            for (int i = 0; i < row; i++)
            {
                string line = Console.ReadLine();

                string[] arrStrings = line.Split(',');

                jagged[i] = arrStrings;
            }

            // test print a jagged array
            for (int i = 0; i < jagged.Length; i++)
            {
                Console.WriteLine(string.Join(",", jagged[i]));
            }


        }
    }
}
