using System;
using System.Globalization;
using System.Collections.Generic;


namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];


            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            Console.WriteLine("Main value: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(mat[i, i] + " ");
            }
            Console.WriteLine("Negative numbers: ");
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }

    }

}
