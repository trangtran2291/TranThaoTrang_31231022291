using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Session_05
    {
        public static void Main(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            Question_06();
        }

        public static void Question_01()
        {
            //Write a C# function to find the maximum of three numbers.
            static int Add(int a, int b, int c)
            {
                return Math.Max(Math.Max(a, b), c);

            }

            Console.Write("Nhap so can so sanh thu nhat x= ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap so can so sanh thu hai y= ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Nhap so can so sanh thu ba z= ");
            int z = int.Parse(Console.ReadLine());

            int largest = Add(x, y, z);
            Console.WriteLine($"So lon nhat trong 3 so vua nhap la: {largest}");

        }

        public static void Question_02()

        {
            static long Factorial(long a)
            {
                if (a == 0 || a == 1)
                {
                    return 1;
                }
                else
                {
                    return a * Factorial(a - 1);
                }
            }

            Console.Write("Nhap so can tinh giai thua x = ");
            long x = long.Parse(Console.ReadLine());

            long result = Factorial(x);
            Console.WriteLine($"Giai thua cua {x} vua nhap la {result}!");
        }

        public static void Question_03()
        {
            static bool Prime(int a)
            {
                if (a <= 1)
                    return false;

                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                        return false;
                }

                return true;
            }

            Console.Write("Nhap so can kiem tra co phai so nguyen to hay x =");
            int x = int.Parse(Console.ReadLine());

            if (Prime(x))
                Console.WriteLine($"{x} la mot so nguyen to");
            else
                Console.WriteLine($"{x} khong la so nguyen to");
        }

        public static void Question_04()
        {

            Console.Write("Nhap mot so nguyen bat ki n = ");
            int n = int.Parse(Console.ReadLine());

            static bool Prime(int a)
            {
                if (a <= 1)
                    return false;
                for (int i = 2; i < a; i++)
                {
                    if (a % i == 0)
                        return false;
                }
                return true;
            }

            Console.Write($"Cac so nguyen to nho hon {n} la: ");
            for (int x = 2; x < n; x++)
            {
                if (Prime(x))
                {
                    Console.WriteLine(x + " ");
                }
            }

            
            Console.Write("Nhap mot so N bat ki de in ra N so nguyen to dau tien, N = ");
            int N = int.Parse(Console.ReadLine());

            Console.Write($"{N} so nguyen to dau tien la: ");

            int count = 0; // Count of found prime numbers
            int num = 2;   // Start checking from the first prime number

            while (count < N)
            {
                if (Prime(num))
                {
                    Console.Write(num + " ");
                    count++;
                }
                num++;
            }

        }

        public static void Question_05()
        {
            static bool IsPerfectNumber(int number)
            {
                int sum = 0;

                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }

                return sum == number;
            }

            Console.WriteLine("Tat ca cac so hoan hao nho hon 1000 la:");

            for (int i = 1; i < 1000; i++)
            {
                if (IsPerfectNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static void Question_06()
        {
            Console.Write("Nhap mot chuoi kiem tra pangram: ");
            string input = Console.ReadLine();

            static bool IsPangram(string str)
            {
                str = str.ToLower();

                for (char c = 'a'; c <= 'z'; c++)
                {
                    if (!str.Contains(c))
                    {
                        return false; 
                    }
                }

                return true; 
            }

            if (IsPangram(input))
            {
                Console.WriteLine("Chuoi tren la mot pangram.");
            }
            else
            {
                Console.WriteLine("Chuoi tren khong phai la mot pangram.");
            }
        }
    }
}
