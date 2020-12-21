using System;
using System.Collections.Generic;
using System.Text;

namespace UsefullStuffLibrary
{
    class Print
    {
        /******************************************************************************************************/
        // methods for printing matrix
        /******************************************************************************************************/

        // matrix - int
        public static void Matrix(int[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        // matrix - decimal
        public static void Matrix(decimal[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        // matrix - double
        public static void Matrix(double[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        // matrix - string
        public static void Matrix(string[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        // matrix - long
        public static void Matrix(long[,] input)
        {
            for (int i = 0; i < input.GetLength(0); i++)
            {
                for (int j = 0; j < input.GetLength(1); j++)
                {
                    Console.Write($"{input[i, j]}\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        /******************************************************************************************************/
        // methods for printing dictionary
        /******************************************************************************************************/

        // dictionary - int, int
        static void Dict(Dictionary<int, int> dictionary)
        {
            foreach (KeyValuePair<int, int> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - int, string
        static void Dict(Dictionary<int, string> dictionary)
        {
            foreach (KeyValuePair<int, string> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - string, int
        static void Dict(Dictionary<string, int> dictionary)
        {
            foreach (KeyValuePair<string, int> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - string, string
        static void Dict(Dictionary<string, string> dictionary)
        {
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - decimal, string
        static void Dict(Dictionary<decimal, string> dictionary)
        {
            foreach (KeyValuePair<decimal, string> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - decimal, decimal
        static void Dict(Dictionary<decimal, decimal> dictionary)
        {
            foreach (KeyValuePair<decimal, decimal> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - string, decimal
        static void Dict(Dictionary<string, decimal> dictionary)
        {
            foreach (KeyValuePair<string, decimal> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - double, double
        static void Dict(Dictionary<double, double> dictionary)
        {
            foreach (KeyValuePair<double, double> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - double, string
        static void Dict(Dictionary<double, string> dictionary)
        {
            foreach (KeyValuePair<double, string> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - string, double
        static void Dict(Dictionary<string, double> dictionary)
        {
            foreach (KeyValuePair<string, double> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - int, double
        static void Dict(Dictionary<int, double> dictionary)
        {
            foreach (KeyValuePair<int, double> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }
        // dictionary - double, int
        static void Dict(Dictionary<double, int> dictionary)
        {
            foreach (KeyValuePair<double, int> kvp in dictionary)
            {
                Console.WriteLine(string.Format($"Key = {kvp.Key}, Value = {kvp.Value}"));
            }
        }







    }
}
