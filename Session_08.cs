using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Session_08
    {
        public static void Main()
        {
            string input = EnterString();
            Console.WriteLine($"Chuoi vua nhap la: {input}");

            int length = FindLength(input);
            Console.WriteLine($"Do dai cua chuoi la : {length}");

            Console.WriteLine("Cac ky tu trong chuoi vua nhap la: ");
            CutString(input);

            Console.Write("Cac ky tu trong chuoi vua nhap dao nguoc lai la: ");
            Reverse(input);

            int count = CountWord(input);
            Console.Write($"So luong khoang trang trong chuoi la: {count}");
            Console.WriteLine();

            Console.Write(" Nhap chuoi thu nhat: ");
            string input1 = Console.ReadLine();
            Console.Write(" Nhap chuoi thu hai: ");
            string input2 = Console.ReadLine();

            int sosanh = CompareStrings(input1, input2);
            if (sosanh == 0)
                Console.WriteLine("Do dai chuoi thu nhat bang do dai chuoi thu hai");
            else if (sosanh == 1)
                Console.WriteLine("Do dai chuoi thu nhat lon hon do dai chuoi thu hai");
            else
                Console.WriteLine("Do dai chuoi thu nhat be hon do dai chuoi thu hai");

            Console.Write("Nhap mot chuoi de dem ne ma: ");
            string chuoivuanhap = Console.ReadLine();
            int alpha, digit, spechar;
            CountMore(chuoivuanhap, out alpha, out digit, out spechar);
            Console.WriteLine($"So luong chu cai trong chuoi: {alpha}");
            Console.WriteLine($"So luong chu so trong chuoi la {digit}");
            Console.WriteLine($"So luong cac ky tu dac biet trong chuoi la: {spechar}");

            int vowel, cosonant;
            MoreAndMore(chuoivuanhap, out vowel, out cosonant);
            Console.WriteLine($"So luong nguyen am trong chuoi {vowel}");
            Console.WriteLine($"So luong phu am trong chuoi {cosonant}");

            Console.Write("Nhap mot chuoi con de kiem tra");
            string nhapne = Console.ReadLine();

            Console.Write("Nhap chuoi con de kiem tra: ");
            nhapne = Console.ReadLine();

            if (CheckSubstring(chuoivuanhap, nhapne))
                Console.WriteLine("Chuoi con co trong chuoi chinh.");
            else
                Console.WriteLine("Chuoi con khong co trong chuoi chinh.");

            int position = SearchSubstringPosition(chuoivuanhap, nhapne);
            if (position != -1)
                Console.WriteLine($"Chuoi con xuat hien tai vi tri: {position}");
            else
                Console.WriteLine("Chuoi con khong xuat hien trong chuoi chinh.");

            Console.Write("Nhap ky tu can kiem tra: ");
            char character = Console.ReadLine()[0];
            IsAlphabet(character);

            int occurrences = CountSubstringOccurrences(chuoivuanhap, nhapne);
            Console.WriteLine($"Chuoi con xuat hien {occurrences} lan trong chuoi chinh.");

            Console.Write("Nhap chuoi con de chen truoc lan xuat hien dau tien: ");
            string insertSub = Console.ReadLine();
            string updatedString = InsertSubstring(chuoivuanhap, nhapne, insertSub);
            Console.WriteLine($"Chuoi sau khi chen: {updatedString}");


        }

        static string EnterString()
        {
            Console.Write("Nhap mot chuoi bat ky: ");
            return Console.ReadLine();


        }


        static int FindLength(string input)
        {
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }
            return length;
        }

        static void CutString(string input)
        {
            foreach (char c in input)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

        }

        static void Reverse(string input)
        {
            for (int i = input.Length -1 ; i>= 0; i--)
            {
                Console.Write(input[i]+ " ");

            }
            Console.WriteLine();
        }

        // chua xong
        static int CountWord (string input)
        {
            int count = 0;
            bool dem = false;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    count++;
                    dem = true;
                }
                else
                    dem = false;
                
            }
            return count;
        }

        static int CompareStrings(string input1, string input2)
        {
            int length1 = 0;
          
            foreach (char c in input1)
            {
                length1 ++;
            }
            Console.WriteLine($"Do dai chuoi thu nhat: {length1}");

            int length2 = 0;
            foreach (char c in input2)
            {
                length2++;
            }
            Console.WriteLine($"Do dai chuoi thu hai: {length2}");

            if (length1 == length2)
                return 0;
            else if (length1 > length2)
                return 1;
            else
                return -1;
       
        }

        static void CountMore(string chuoivuanhap, out int alpha, out int digit, out int spechar)
        {
            alpha = 0;
            digit = 0;
            spechar = 0;

            foreach (char c in chuoivuanhap)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                    alpha++;
                else if (c >= '1' && c <= '9')
                    digit++;
                else
                    spechar++;
            }

        }

        static void MoreAndMore(string chuoivuanhap, out int vowel, out int cosonant)
        {
            vowel = 0;
            cosonant = 0;
            foreach(char c in chuoivuanhap)
            {
                if (c >= 'a' && c <= 'z')
                    vowel++;
                else
                    cosonant++;
            }    
        }

        static bool CheckSubstring(string chuoivuanhap, string nhapne)
        {
            return chuoivuanhap.Contains(nhapne);
        }

        static int SearchSubstringPosition(string chuoivuanhap, string nhapne)
        {
            return chuoivuanhap.IndexOf(nhapne);
        }

        static bool IsAlphabet(char c)
        {
            if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
            {
                Console.WriteLine($"Ky tu '{c}' la chu cai.");
                if (char.IsUpper(c))
                    Console.WriteLine("Chu cai nay la chu hoa.");
                else
                    Console.WriteLine("Chu cai nay la chu thuong.");
                return true;
            }
            else
            {
                Console.WriteLine($"Ky tu '{c}' khong phai chu cai.");
                return false;
            }
        }

        static int CountSubstringOccurrences(string chuoivuanhap, string nhapne)
        {
            int count = 0;
            int index = 0;

            while ((index = chuoivuanhap.IndexOf(nhapne, index)) != -1)
            {
                count++;
                index += nhapne.Length;
            }

            return count;
        }

        static string InsertSubstring(string chuoivuanhap, string nhapne, string insertSub)
        {
            int index = chuoivuanhap.IndexOf(nhapne);
            if (index != -1)
            {
                return chuoivuanhap.Insert(index, insertSub);
            }
            else
            {
                Console.WriteLine("Khong tim thay chuoi con trong chuoi chinh.");
                return chuoivuanhap;
            }
        }

    }
}
