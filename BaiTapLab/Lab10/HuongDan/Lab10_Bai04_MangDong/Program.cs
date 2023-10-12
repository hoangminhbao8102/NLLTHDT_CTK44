using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai04_MangDong
{
    public class Program
    {
        static void Main(string[] args)
        {
            DynamicArray mang = new DynamicArray();

            for (int i = 0; i < 30; i++)
            {
                mang.Add(i);
            }
            Console.WriteLine(mang);
            Console.WriteLine("".PadRight(79, '='));

            Console.WriteLine("Count = {0}", mang.Count);
            Console.WriteLine("Capacity = {0}", mang.Capacity);
            Console.WriteLine("".PadRight(79, '='));

            mang.AddRange(new object[] { 123, 456, 789, 890, 312 });

            Console.WriteLine(mang);
            Console.WriteLine("Count = {0}", mang.Count);
            Console.WriteLine("Capacity = {0}", mang.Capacity);
            Console.WriteLine("".PadRight(79, '='));

            mang.RemoveAt(15);
            mang.RemoveAt(1);
            mang.RemoveAt(29);
            mang.RemoveAt(10);

            Console.WriteLine(mang);
            Console.WriteLine("Count = {0}", mang.Count);
            Console.WriteLine("Capacity = {0}", mang.Capacity);
            Console.WriteLine("".PadRight(79, '='));

            foreach (object phanTu in mang)
            {
                Console.Write("{0}\t", phanTu);
            }

            Console.WriteLine(mang);
            Console.WriteLine("Count = {0}", mang.Count);
            Console.WriteLine("Capacity = {0}", mang.Capacity);
            Console.WriteLine("".PadRight(79, '='));

            Console.ReadKey();
        }
    }
}
