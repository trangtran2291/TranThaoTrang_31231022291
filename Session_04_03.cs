using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Session_04_03
    {
        public static void Main4(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            Question_07();


        }

        public static void Question_01()
        {
            /*Write a program to check whether a triangle is Equilateral, Isosceles or
Scalene*/
            Console.Write("Nhap do dai canh thu nhat a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh thu hai b= ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap do dai canh thu ba c= ");
            int c = int.Parse(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("The Triangle is a Equilateral");
            }

            else if (a == b && a != c)
            {
                Console.WriteLine("The Triangle is a Isoceles");

            }

            else
            {
                Console.WriteLine("The Triangle is a Scalene");
            }
        }

        public static void Question_02()
        {
            /*Write a program to read 10 numbers and find their average and sum.*/

            int number;
            int sum = 0;
            double average;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Nhap so number thu {i} = ");
                number = int.Parse(Console.ReadLine());
                sum += number;

            }

            Console.WriteLine($"Tong cua cac so la {sum}");

            average = sum / 10;
            Console.Write($"Trung binh cac so vua nhap la {average:F2}");

        }

        public static void Question_03()
        {
            /*Write a program to display the multiplication table of a given integer.*/

            Console.Write("Nhap mot so tu nhien bat ky = ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine($"Bang nhan cho so tu nhien {number}");
            for (int multi = 1; multi <= 10; multi++)
            {
                int ketqua = number * multi;
                Console.WriteLine($"{number} x {multi} = {ketqua}");

            }
        }

        public static void Question_04()
        {
            Console.Write("Nhap so luong hang n= ");
            int n = int.Parse(Console.ReadLine());

            //tam gia 1
            /*for (int i = 1; i <=n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);

                }

               Console.WriteLine();
            }
           */

            //tam giac 2
            /*int number = 1;
            int row = 1;

            while (number <= 10)
            {
                for (int j = 0; j < row; j++)
                {
                    if (number > 10) break;
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
                row++;
            }*/


            // tam giac 3
            int number = 1;
            int row = 1;
            int maxRows = 4; 
            int maxWidth = maxRows * 2 - 1;

            while (row <= maxRows && number <= 10)
            {
                int spaces = (maxWidth - (row * 2 - 1)) / 2;

               
                Console.Write(new string(' ', spaces));

                for (int j = 0; j < row; j++)
                {
                    if (number > 10) break; 
                    Console.Write(number + " ");
                    number++;
                }

                Console.WriteLine();
                row++;
            }

        }

        public static void Question_05()
        {
            Console.Write($"Nhap so luong so hang n = ");
            int n = int.Parse(Console.ReadLine());

            double sum = 0.0;

            Console.Write($"Chuoi dieu hoa voi {n} so hang = ");
            for (int i = 1; i <=n; i++)
            {
                Console.Write($"1/{i}");
                if( i < n )
                { 
                    Console.Write(" + ");
                }
                else
                {
                    Console.WriteLine(" ");
                }
                sum += 1.0 / i;

            }

            Console.WriteLine($"Tong cua chuoi dieu hoa la: {sum:F2}");
        }

        public static void Question_06()
        {
            Console.Write("Nhap so bat dau cua khoang: ");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Nhap so ket thuc cua khoang: ");
            int end = int.Parse(Console.ReadLine());

            Console.Write("So hoan hao trong khoang tu " + start + " den " + end + ":");

            for (int num = start; num <= end; num++)
            {
                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0) sum += i; 
                }
                if (sum == num) Console.WriteLine(num); 
            }
        }

        public static void Question_07()
        {
            Console.Write("Nhap vao so can kiem tra: ");
            int number = int.Parse(Console.ReadLine());

            bool isPrime = true;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break; 
                }
            }

            if (isPrime)
                Console.WriteLine(number + " la so nguyen to.");
            else
                Console.WriteLine(number + " khong la so nguyen to.");
        }
    }
}
