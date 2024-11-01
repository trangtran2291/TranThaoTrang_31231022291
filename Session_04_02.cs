using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Session_04_02
    {
        public static void Main(string[] args)
        {
            //Question_01();
            //Question_02();
            Question_03();

        }

        public static void Question_01()
        {
            Console.Write("Nhap so can kiem tra a = ");
            int a = int.Parse(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("a la so chan ");
            }

            else
            {
                Console.WriteLine("a la so le ");
            }
        }

        public static void Question_02()
        {
            Console.Write("Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c = ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"So lon nhat la : {max3nums(a, b, c)}");

            int max2nums(int a, int b)
            {
                return a > b ? a : b;
            }

            int max3nums(int a, int b, int c)
            {
                return max2nums(a, max2nums(b, c));

            }
        }

        public static void Question_03()
        {
            Console.Write("Nhap vao toa do X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Nhap vao toa do Y: ");
            double y = double.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Diem nam trong goc I.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Diem nam trong goc II.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Diem nam trong goc III.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Diem nam trong goc IV.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("Diem nam tai goc toa do.");
            }
            else if (x == 0)
            {
                Console.WriteLine("Diem nam tren trục Y.");
            }
            else
            {
                Console.WriteLine("Diem nam tren trục X.");
            }
        }

    }
}
