using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Session_03
    {
        public static void Main(string[] args)
        {
            //Question_01();
            //Question_02();
            Question_03();

        }
        public static void Question_01()
        {
            Console.Write("Enter temperature in degree Celsius = ");
            double C = double.Parse(Console.ReadLine());
            double K = C + 273;
            double F = C * 18 / 10 + 32;
            string output = $@"The temperature in degree Kelvin is = {K}
The temperature in degree Fahrenheit is = {F}";
            Console.WriteLine(output);
        }
        public static void Question_02()
        {
            const double pi = Math.PI;
            Console.Write("Enter the radius of the sphere = ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * pi * Math.Pow(radius, 2);
            double volume = 4 / 3 * pi * Math.Pow(radius, 3);
            string output = $@"The surface of the sphere has the value = {surface:F2}
The volume of the sphere has the value = {volume:F1}";
            Console.WriteLine(output);
        }

        public static void Question_03()
        {
            Console.Write("Enter number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b = ");
            int b = int.Parse(Console.ReadLine());

            int adding = a + b;
            int subtracting = a - b;
            int multiplying = a * b;
            int dividing = a / b;
            int modulus = a % b;

            string output = $@"{a} + {b} = {adding}
{a} - {b} = {subtracting}
{a} * {b} = {multiplying}
{a} / {b} = {dividing}
{a} mod {b} = {modulus}";

            Console.WriteLine(output);
        }
    }
}
