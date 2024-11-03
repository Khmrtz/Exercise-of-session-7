using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program8
    {
        static void Main()
        {
            int[,] Matrix1 = new int[2, 2];
            int[,] Matrix2 = new int[2, 2];
            Console.WriteLine("Enter elements of first 2*2 matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Element [{i},{j}]");
                    Matrix1[i, j] = int.Parse(Console.ReadLine() ?? "");
                }
            }
            Console.WriteLine("\nEnter elements of second 2*2 matrix");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine($"Element [{i},{j}]");
                    Matrix2[i, j] = int.Parse(Console.ReadLine() ?? "");
                }
            }
            // Addition of Two matrices
            int[,] SumResult = MatrixOperations.AddMatrix(Matrix1, Matrix2);
            Console.WriteLine("\nSum of the matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(SumResult[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Multiplication of Two matrices
            int[,] ProductResult = MatrixOperations.MultiplyMatrices(Matrix1, Matrix2);
            Console.WriteLine("\nProduct of the matrices:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(ProductResult[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // sort arrays
            Console.WriteLine("Enter the number of element");
            int n=int.Parse(Console.ReadLine()??"");
            int[]numbers=new int[n];
            Console.WriteLine("Enter the numbers");
            for(int i = 0;i<n;i++)
            {
                Console.WriteLine($"Element {i + 1}:");
                numbers[i] = int.Parse(Console.ReadLine()??"");
            }
            //
            Array.Sort(numbers);
            Console.WriteLine("\nSorted numbers");
            foreach (int num in numbers)
            {
                Console.WriteLine(num + " ");
            }
        }
    }
}
