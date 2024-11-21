using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Session_07
    {
        public static void Mainne()
        {
            Question_01();
            
        }

        public static void Question_01()
        {
            Console.Write("Nhap so dong cua mang n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua mang m = ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = random.Next(0, 100);
                    Console.Write($"{matrix[i, j]}\t");

                }
                Console.WriteLine();
            }

            //print ith
            Console.Write("Nhap so thu tu cua dong ma ban muon in ra ith = ");
            int ith = int.Parse(Console.ReadLine());

            if (ith >= 0 || ith < n)

            {
                Console.Write($"Dong thu {ith} cua ma tran la:");
                for (int j = 0; j < m; j++)
                {
                    Console.Write($" {matrix[ith, j]}");
                }
            }
            else
                Console.WriteLine("So dong vua nhap khong hop le");
            Console.WriteLine();

            //tim maxValue
            int maxValue = matrix[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] > maxValue)
                        maxValue = matrix[i, j];

                }

            }
            Console.WriteLine($"Gia tri lon nhat trong ma tran la: {maxValue}");

            //tim minValue cua ith 
            Console.Write("Nhap so thu tu cua dong ma ban muon tim minValue trong do ithh = ");
            int ithh = int.Parse(Console.ReadLine());

            if (ithh >= 0 || ithh < n)
            {
                int minValue = matrix[ithh, 0];
                for (int j = 0; j < m; j++)
                {
                    if (minValue > matrix[ithh, 0])
                    {
                        minValue = matrix[ithh, 0];
                    }

                }
                Console.WriteLine($"Gia tri nho nhat trong dong ithh = {minValue}");

            }
            else
                Console.WriteLine("So dong nhap khong hop le");
            Console.WriteLine();

            //transpose the matrix
            Console.WriteLine("\nChuong trinh chuyen vi:");

             int[,] transposeMatrix = new int[m, n];
             Console.WriteLine("\nMa tran chuyen vi:");

             for (int i = 0; i < n; i++) 
             {
                 for (int j = 0; j < m; j++)
                 {
                     transposeMatrix[i, j] = matrix[j, i];
                     Console.Write($"{transposeMatrix[i, j]}\t");

                 }

                Console.WriteLine();
            }
            

            //Diagno
            Console.Write("Duong cheo phu cua ma tran: ");
             for (int i = 0; i < n; i ++)
            {
                for (int j =0; j < m; j++)
                {
                    if (i + j == n - 1)
                        Console.Write(matrix[i, j] + "\t");
                }
            }
            Console.WriteLine();
            Console.Write("Duong cheo chinh cua ma tran: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j)
                        Console.Write(matrix[i, j] + "\t");
                }
            }
       }

        
    }
}
