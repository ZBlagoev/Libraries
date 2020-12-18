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

            */
            int[,] matrix = new int[1, 5];

            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            Console.WriteLine(matrix[0,4]);
        }
    }
}
