namespace ConsoleApp5
{
    internal class Program
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            Question_10();



            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        public static void Question_01()
        {
            Console.Write("Nhap so a= ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b= ");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;
            int d = a * b;

            Console.WriteLine($" {a} + {b} = {c}");
            Console.WriteLine($" {a} * {b} = {d}");

        }

        public static void Question_02()
        {
            Console.Write("Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Truoc khi bien doi a ={a}, b={b} ");

            int c = a;
            a = b; b = c;

            Console.WriteLine($"Sau khi bien doi a={a}, b={b}");


        }

        public static void Question_03()
        {
            Console.Write("Nhap so a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b= ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;

            Console.WriteLine($" Ket qua la {a} * {b} = {c}");
        }

        public static void Question_04()
        {
            const double feetTometer = 0.3048;
            Console.Write("Nhap gia tri tinh bang feet= ");
            double feet = double.Parse(Console.ReadLine());
            double meter = feet * feetTometer;
            Console.WriteLine($"{feet} feet bang {meter} met.");
        }

        public static void Question_05()

        {
            Console.WriteLine($"Nhap {1}: neu muon chuyen tu C sang F");
            Console.WriteLine($"Nhap {2}: neu muon chuyen tu F sang C");
            int option = int.Parse(Console.ReadLine());
            if (option == 1)
            {
                Console.Write("Nhap gia tri tinh bang C= ");
                double C = double.Parse(Console.ReadLine());
                double F = C * 9 / 5 + 32;
                Console.WriteLine($"Gia tri chuyen tu C sang F = {F}");
            }
            else
            {
                Console.WriteLine("Nhap gia tri tinh bang F= ");
                double F = double.Parse(Console.ReadLine());
                double C = (F - 32) * 5 / 9;
                Console.WriteLine($"Gia tri chuyen tu F sang C = {C}");
            }
        }

        public static void Question_06()
        {
            Console.WriteLine("Size of int: " + sizeof(int) + " bytes");
            Console.WriteLine("Size of double: " + sizeof(double) + " bytes");
            Console.WriteLine("Size of float: " + sizeof(float) + " bytes");
            Console.WriteLine("Size of char: " + sizeof(char) + " bytes");
            Console.WriteLine("Size of bool: " + sizeof(bool) + " bytes");
            Console.WriteLine("Size of long: " + sizeof(long) + " bytes");
            Console.WriteLine("Size of short: " + sizeof(short) + " bytes");
        }

        public static void Question_07()
        {
            Console.Write("Nhap mot ky tu: ");
            char character = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int asciiValue = (int)character;
            Console.WriteLine($"Gia tri ASCII cua ky tu {character} la {asciiValue}");
        }

        public static void Question_08()
        {
            const double soPi = 3.14;
            Console.Write("Tinh dien tich hinh tron");
            Console.ReadLine();
            Console.Write("Nhap ban kinh hinh tron r= ");
            double r = double.Parse(Console.ReadLine());
            double area = soPi * r * r;
            Console.WriteLine($"Dien tich hinh tron la {area}");
        }

        public static void Question_09()
        {
            Console.WriteLine("Tinh dien tich hinh vuong");
            Console.ReadLine();
            Console.Write("Nhap do dai canh hinh vuong= ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;
            Console.WriteLine($"Dien tich hinh vuong la {area}");
        }

        public static void Question_10()
        {
            Console.WriteLine("Nhap so ngay");
            int soNgay = int.Parse(Console.ReadLine());

            int years = soNgay / 365;
            int weeks = soNgay % 365 / 7;
            int days = soNgay % 365 % 7;
            Console.WriteLine($"ket qua: {years} nam, {weeks} tuan,  {days} ngay");

        }
    }
}
