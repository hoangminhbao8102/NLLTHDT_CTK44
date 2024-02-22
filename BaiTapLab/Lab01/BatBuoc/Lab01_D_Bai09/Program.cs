using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập số phần tử của mảng từ bàn phím
            Console.Write("Nhập số phần tử của mảng: ");
            int n = int.Parse(Console.ReadLine());

            // Khai báo mảng
            double[] arr = new double[n];

            // Nhập các phần tử của mảng từ bàn phím
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                arr[i] = double.Parse(Console.ReadLine());
            }

            // Tìm và xuất các phần tử trong khoảng (min, max)
            Console.Write("Nhập giá trị min: ");
            double min = double.Parse(Console.ReadLine());
            Console.Write("Nhập giá trị max: ");
            double max = double.Parse(Console.ReadLine());
            Console.WriteLine($"Các phần tử trong khoảng ({min}, {max}):");
            foreach (var num in arr)
            {
                if (num > min && num < max)
                {
                    Console.WriteLine(num);
                }
            }

            // Tìm vị trí của tất cả các số âm và nằm ở vị trí lẻ
            Console.WriteLine("Vị trí của các số âm và nằm ở vị trí lẻ:");
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0 && i % 2 != 0)
                {
                    Console.WriteLine($"Số âm {arr[i]} ở vị trí {i}");
                }
            }

            // Tính tổng tất cả các số nằm ở vị trí chia hết cho 3
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 3 == 0)
                {
                    sum += arr[i];
                }
            }
            Console.WriteLine($"Tổng các số nằm ở vị trí chia hết cho 3: {sum}");

            // Tính trung bình cộng của các số trong mảng
            sum = 0;
            foreach (var num in arr)
            {
                sum += num;
            }
            double average = sum / arr.Length;
            Console.WriteLine($"Trung bình cộng của các số trong mảng: {average}");

            // Xuất ra k số lớn nhất trong mảng
            Console.Write("Nhập số lượng số lớn nhất cần xuất: ");
            int k = int.Parse(Console.ReadLine());
            Array.Sort(arr);
            Console.WriteLine($"{k} số lớn nhất trong mảng:");
            for (int i = arr.Length - 1; i >= arr.Length - k; i--)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadKey();
        }
    }
}
