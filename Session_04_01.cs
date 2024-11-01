using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Session_04_01
    {
        public static void Main3(string[] args)
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();

        }

        public static void Question_01()
        {
            /*Write a C# Sharp program that takes two numbers as input and
performs an operation (+,-,*,x,/) on them and displays the result of that
operation.*/

            Console.Write("Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"a + b = {a + b}");
            Console.WriteLine($"a - b = {a - b}");
            Console.WriteLine($"a * b = {a * b}");
            Console.WriteLine($"a / b = {a / b}");
        }

        public static void Question_02()
        {
            /* Write a C# Sharp program to display certain values of the function x = y2
 + 2y + 1(using integer numbers for y, ranging from - 5 to + 5).*/

            Console.WriteLine("Tinh toan ham x = y^2 + 2 * y + 1");
            for (int y = -5; y <= 5; y++)
            {
                double x = Math.Pow(y, 2) + 2 * y + 1;
                Console.WriteLine($"Gia tri cua ham x can tinh cho y = {y} la = {x}");
            }

        }

        public static void Question_03()
        {
            /* . Write a C# Sharp program that takes distance and time (hours, minutes,
 seconds) as input and displays speed in kilometers per hour(km / h) and
 miles per hour(miles/ h).*/

            Console.Write("Nhap quang duong distance in kilo can tinh = ");
            float distanceInkilo = float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian hours can tinh = ");
            float hours = float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian minutes can tinh = ");
            float minutes = float.Parse(Console.ReadLine());
            Console.Write("Nhap thoi gian seconds can tinh = ");
            float seconds = float.Parse(Console.ReadLine());

            float timeInhours = hours + minutes / 60 + seconds / 3600;

            Console.WriteLine($"Speed in Kilometers per hour = {distanceInkilo / timeInhours:F2} km/h");

            float distanceInmile = distanceInkilo * 1000;

            Console.WriteLine($"Speed in Miles per hour = {distanceInmile / timeInhours:F2} km/h");

        }

        public static void Question_04()
        {
            /*Write a C# Sharp program that takes the radius of a sphere as input and
calculates and displays the surface and volume of the sphere.V =
4 / 3 * π * r*/
            const double pi = Math.PI;
            Console.Write("Nhap ban kinh hinh cau radius = ");
            double radius = float.Parse(Console.ReadLine());

            /*surface= 4 * pi * radius squared
- volume= 4 / 3 * pi * radius cubed*/
            double surface = 4 * pi * Math.Pow(radius, 2);
            double volume = 4 / 3 * pi * Math.Pow(radius, 3);

            Console.WriteLine($"Dien tich hinh cau la = {surface:F2}");
            Console.WriteLine($"The tich hinh cau la = {volume:F2}");
            
        }

        public static void Question_05()

        /*Write a C# Sharp program that takes a character as input and checks if it
is a vowel, a digit, or any other symbol.*/
        {
            Console.WriteLine("Nhap mot ki tu character");
            char inPut = Console.ReadKey().KeyChar;
            Console.WriteLine();

       

        }
        



    }
}
