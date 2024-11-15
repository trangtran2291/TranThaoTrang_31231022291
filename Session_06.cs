using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp6
{
    internal class Session_06
    {
        public static void Main(string[] args)
        {

            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            Question_06();
            //Question_07();
        }
        public static void Question_01()
        {
            Console.Write("Nhap so luong phan tu ban muon in ra n = ");
            int n = int.Parse(Console.ReadLine());

            int[] mang = new int[n];

            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhap gia tri thu {i + 1} = ");
                mang[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Mang hien tai: ");
            foreach (int item in mang)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Cac phan tu trong mang sau khi tang 2: ");
            for (int i = 0; i < mang.Length; i++)
            {
                mang[i] += 2;
                Console.Write($"{mang[i]}  ");
            }
            Console.WriteLine();

            Console.Write("Tong cua cac phan tu trong mang = ");
            int tong = 0;
            foreach (int item in mang)
            {
                tong += item;

            }

            Console.WriteLine(tong);


            Console.WriteLine("Nhap cac gia tri can tinh trung binh, min, max vao");


            for (int i = 0; i < mang.Length; i++)
            {
                Console.Write($"Nhap gia tri thu {i + 1}: ");
                mang[i] = int.Parse(Console.ReadLine());
            }

            int total = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                total += mang[i];
            }

            double average = (double)total / mang.Length;
            Console.WriteLine($"Gia tri trung binh cua 5 so vua nhap la: {average}");



            int min = mang[0];
            int max = mang[0];

            foreach (int item in mang)
            {
                if (item < min) min = item;
                if (item > max) max = item;
            }
            Console.WriteLine($"Gia tri lon nhat cua cac so vua nhap la {max}");
            Console.Write($"Gia tri nho nhat cua cac so vua nhap la {min}");
        }

        public static void Question_02()
        {

            Console.Write("Nhap so luong phan tu muon in ra trong mang n = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, n);
            }


            Console.Write("Mang co gia tri la ");
            foreach (int item in array)
            {
                Console.Write(item + " ");

            }

            double CalculateAverage(int[] array)
            {
                Console.WriteLine();
                int sum = 0;
                foreach (int item in array)
                {
                    sum += item;
                }

                return (double)sum / n;


            }
            double average = CalculateAverage(array);
            Console.Write($"Gia tri trung binh cua cac phan tu trong mang la = {average}");
            Console.WriteLine();

            //2. Kiem tra mot gia tri co trong mang hay khong
            Console.Write("Nhap gia tri cu the can kiem tra = ");
            int giaTri = int.Parse(Console.ReadLine());

            bool CheckValue(int[] array, int giaTri)
            {
                foreach (int item in array)
                {
                    if (item == giaTri)
                        return true;
                }
                return false;
            }

            bool kiemTra = CheckValue(array, giaTri);
            Console.WriteLine(kiemTra ? "Mang co chua gia tri vua nhap" : "Mang khong co chua gia tri vua nhap");

            //3. to find the index of an array element.
            Console.Write("Nhap mot gia tri can tim chi so cua no trong mang = ");
            int gtIndex = int.Parse(Console.ReadLine());

            int FindIndex(int[] array, int gtIndex)
            {
                for (int i = 0; i < n; i++)
                {
                    if (array[i] == gtIndex)
                    {
                        return i;
                    }
                }
                return -1;
            }

            int timRa = FindIndex(array, gtIndex);
            if (timRa != -1)
                Console.WriteLine($"Chi so cua gia tri {gtIndex} trong mang la {timRa}");
            else
                Console.WriteLine($"Gia tri {gtIndex} khong co trong mang");

            //4. to remove a specific element from an array
            Console.Write("Nhap phan tu trong mang ma ban muon xoa = ");
            int muonXoa = int.Parse(Console.ReadLine());

            int[] RemoveElement(int[] array, int muonXoa)

            {
                int count = 0;
                foreach (int item in array)
                {
                    if (item != muonXoa)
                        count++;
                }

                int[] newArray = new int[count];
                int index = 0;
                foreach (int item in array)
                {
                    if (item != muonXoa)
                        newArray[index++] = item;
                }

                return newArray;
            }

            int[] mangMoi = RemoveElement(array, muonXoa);
            Console.WriteLine($"Mang moi sau khi xoa phan tu vua nhap la {string.Join(" ", mangMoi)}");
            Console.WriteLine();

            //5. to find the maximum and minimum value of an array.
            Console.WriteLine("Chuong trinh tim gia tri lon nhat, gia tri nho nhat cua mang");

            void FindMaxMin(int[] array, out int max, out int min)
            {
                max = array[0];
                min = array[0];

                foreach (int item in array)
                {
                    if (item > max)
                        max = item;
                    if (item < min)
                        min = item;
                }

            }
            FindMaxMin(array, out int max, out int min);
            Console.WriteLine($"Gia tri lon nhat trong mang la: {max}");
            Console.WriteLine($"Gia tri nho nhat trong mang la: {min}");
            Console.WriteLine();


            //6. to reverse an array of integer values.
            Console.WriteLine("Chuong trinh dao nguoc mang");
            Console.WriteLine($"Mang cu cua chuong trinh {string.Join(" ", array)}");

            void ReverseArray(int[] array)
            {
                int left = 0;
                int right = n - 1;

                while (left < right)
                {
                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;

                    left++;
                    right--;

                }
            }
            ReverseArray(array);
            Console.WriteLine($"Mang sau khi dao nguoc la {string.Join(" ", array)}");
            Console.WriteLine();

            //7. to find duplicate values in an array of values.
            Console.WriteLine("Chuong trinh tim cac phan tu trung lap");
            FindDuplicate(array);

            void FindDuplicate(int[] arrray)

            {
                bool foundDuplicate = false;
                for (int i = 0; i < n; i++)
                {
                    bool isDuplicate = false;

                    for (int j = 0; j < i; j++)
                    {
                        if (array[i] == array[j])
                            isDuplicate = true;
                        break;
                    }
                    if (!isDuplicate)
                    {
                        int count = 1;
                        for (int k = i + 1; k < n; k++)
                        {
                            if (array[i] == array[k])
                                count++;
                        }

                        if (count > 1)
                        {
                            Console.WriteLine($"{array[i]} xuat hien {count} lan");
                            foundDuplicate = true;
                        }

                    }

                }
                if (!foundDuplicate)
                    Console.WriteLine("Khong co phan tu trung lap trong mang");
            }

            //8. to remove duplicate elements from an array.
            Console.WriteLine("Chuong trinh loai bo phan tu trung lap ra khoi mang ");

            int RemoveDuplicate(int[] array, int n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (array[i] == array[j])
                        {
                            for (int k = j; k < n - 1; k++)
                            {
                                array[k] = array[k + 1];
                            }

                            n--;
                            j--;

                        }
                    }
                }
                return n;
            }
            n = RemoveDuplicate(array, n);
            Console.Write("Mang sau khi loai bo phan tu trung lap: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
        public static void Question_03()
        {
            Console.WriteLine("Nhap tu ban phim 10 so nguyen bat ky");
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {

                Console.Write($"Nhap so nguyen thu {i + 1} = ");
                array[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.Write("Mang hien tai: ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {

                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            Console.Write("Mang sau khi sap xep (Bubble Sort): ");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            Console.WriteLine("Nhap mot cau bat ky:");
            string sentence = Console.ReadLine();


            Console.WriteLine("Nhap mot tu de tim kiem trong cau tren:");
            string word = Console.ReadLine();


            bool found = false;
            string[] words = sentence.Split(' ');

            foreach (string w in words)
            {
                if (w.Equals(word, StringComparison.OrdinalIgnoreCase))
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.WriteLine($"Tu '{word}' xuat hien trong cau.");
            }
            else
            {
                Console.WriteLine($"Tu '{word}' khong xuat hien trong cau.");
            }



        }

        public static void Question_04()
        {
            int[][] jaggedArray = new int[4][];
            jaggedArray[0] = new int[] { 1, 1, 1, 1, 1 };
            jaggedArray[1] = new int[] { 2, 2 };
            jaggedArray[2] = new int[] { 3, 3, 3, 3 };
            jaggedArray[3] = new int[] { 4, 4 };

            Console.WriteLine("Hien thi mang lom chom:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void Question_05()
        {
            // Nhập số hàng của mảng
            Console.WriteLine("Nhap so hang cua mang:");
            int rows = int.Parse(Console.ReadLine());

            // Tạo mảng lởm chởm với số hàng đã nhập
            int[][] jaggedArray = new int[rows][];
            Random rand = new Random();

            // Nhập số cột cho từng hàng và khởi tạo giá trị ngẫu nhiên
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Nhap so cot cho hang {i + 1}:");
                int cols = int.Parse(Console.ReadLine());
                jaggedArray[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    jaggedArray[i][j] = rand.Next(1, 101); // Số ngẫu nhiên từ 1 đến 100
                }
            }

            // In mảng lởm chởm
            Console.WriteLine("Mang lom chom vua tao:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Tìm và in số lớn nhất của mỗi hàng và toàn bộ mảng
            int globalMax = int.MinValue;
            Console.WriteLine("So lon nhat cua moi hang:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                int rowMax = int.MinValue;
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] > rowMax)
                    {
                        rowMax = jaggedArray[i][j];
                    }
                    if (jaggedArray[i][j] > globalMax)
                    {
                        globalMax = jaggedArray[i][j];
                    }
                }
                Console.WriteLine($"Hang {i + 1}: {rowMax}");
            }
            Console.WriteLine($"So lon nhat cua ca mang: {globalMax}");

            // Sắp xếp từng hàng theo thứ tự tăng dần
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Array.Sort(jaggedArray[i]);
            }
            Console.WriteLine("Mang sau khi sap xep tang dan tung hang:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }

            // Hàm kiểm tra số nguyên tố (nằm bên trong Question_05)
            bool IsPrime(int num)
            {
                if (num <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0) return false;
                }
                return true;
            }

            // In các số nguyên tố trong mảng
            Console.WriteLine("Cac so nguyen to trong mang:");
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (IsPrime(jaggedArray[i][j]))
                    {
                        Console.Write(jaggedArray[i][j] + " ");
                    }
                }
            }
            Console.WriteLine();

            // Tìm và in tất cả các vị trí của một số nhập từ người dùng
            Console.WriteLine("Nhap mot so de tim kiem trong mang:");
            int searchNum = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    if (jaggedArray[i][j] == searchNum)
                    {
                        Console.WriteLine($"Tim thay {searchNum} o vi tri hang {i + 1}, cot {j + 1}");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine($"Khong tim thay {searchNum} trong mang");
            }
        }

        public static void Question_06()
        {
            // Khai báo mảng jagged để lưu trữ thông tin thành viên của 3 nhóm
            // Cấu trúc: id, name, tasks
            object[][] groups = new object[3][];
            groups[0] = new object[5][];  // Nhóm 1 có 5 thành viên
            groups[1] = new object[3][];  // Nhóm 2 có 3 thành viên
            groups[2] = new object[6][];  // Nhóm 3 có 6 thành viên

            // Nhập thông tin thành viên từ bàn phím
            for (int i = 0; i < groups.Length; i++)
            {
                Console.WriteLine($"\nNhập thông tin cho nhóm {i + 1}:");
                for (int j = 0; j < groups[i].Length; j++)
                {
                    groups[i][j] = new object[3];  // Mỗi thành viên có 3 phần tử: ID, Name, Tasks

                    Console.Write($"Nhập ID thành viên {j + 1}: ");
                    groups[i][j][0] = int.Parse(Console.ReadLine()); // ID

                    Console.Write("Nhập họ tên: ");
                    groups[i][j][1] = Console.ReadLine(); // Name

                    Console.Write("Nhập số công việc đã hoàn thành: ");
                    groups[i][j][2] = int.Parse(Console.ReadLine()); // Tasks
                }
            }

            // Menu để người dùng chọn tác vụ
            int task;
            do
            {
                Console.WriteLine("\nChọn tác vụ:");
                Console.WriteLine("1. In danh sách tất cả thành viên");
                Console.WriteLine("2. Tìm thành viên theo ID");
                Console.WriteLine("3. Tìm thành viên có số công việc hoàn thành nhiều nhất");
                Console.WriteLine("4. Thoát");
                Console.Write("Nhập số tác vụ: ");
                task = int.Parse(Console.ReadLine());

                switch (task)
                {
                    case 1:
                        // In danh sách tất cả thành viên
                        Console.WriteLine("\nDanh sách tất cả thành viên:");
                        foreach (var group in groups)
                        {
                            foreach (var member in group)
                            {
                                int id = (int)member[0];        // ID
                                string name = (string)member[1]; // Name
                                int tasks = (int)member[2];     // Tasks
                                Console.WriteLine($"ID: {id}, Tên: {name}, Công việc hoàn thành: {tasks}");
                            }
                        }
                        break;
                    case 2:
                        // Tìm thành viên theo ID
                        Console.Write("\nNhập ID để tìm thành viên: ");
                        int searchID = int.Parse(Console.ReadLine());
                        bool found = false;

                        foreach (var group in groups)
                        {
                            foreach (var member in group)
                            {
                                if ((int)member[0] == searchID) // Kiểm tra ID
                                {
                                    string name = (string)member[1]; // Name
                                    int tasks = (int)member[2];      // Tasks
                                    Console.WriteLine($"Thành viên: {name}, Công việc hoàn thành: {tasks}");
                                    found = true;
                                    break;
                                }
                            }
                        }

                        if (!found)
                        {
                            Console.WriteLine("Không tìm thấy thành viên với ID này.");
                        }
                        break;
                    case 3:
                        // Tìm thành viên có số công việc hoàn thành nhiều nhất
                        int maxTasks = 0;
                        object[] topMember = null;

                        foreach (var group in groups)
                        {
                            foreach (var member in group)
                            {
                                int tasks = (int)member[2]; // Tasks
                                if (tasks > maxTasks)
                                {
                                    maxTasks = tasks;
                                    topMember = member;
                                }
                            }
                        }

                        if (topMember != null)
                        {
                            string name = (string)topMember[1]; // Name
                            Console.WriteLine($"\nThành viên có số công việc hoàn thành nhiều nhất: {name} - {maxTasks} công việc.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Thoát chương trình.");
                        break;
                    default:
                        Console.WriteLine("Chọn tác vụ không hợp lệ.");
                        break;
                }
            } while (task != 4);
        }



    }
}
           





