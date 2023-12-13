using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class Program
    {
        static int[] a = new int[100];
        static int length = 0;
        static void Main(string[] args)
        {
            //Nhap();
            NhapNgauNhien();
            Xuat();
            Console.WriteLine("Tong cac phan tu la " + TinhTongCacSoNguyen());
            int y = 0;
            y = int.Parse(Console.ReadLine());
            int vt = TimViTriDauTien(y);
            Console.WriteLine("Vi tri cua {0} la {1} ", y, vt);
            XoaPhanTuDauTien(y);
            Xuat();
            Console.ReadKey();
        }
        static void Nhap()
        {
            Console.Write("Nhap vao so phan tu cua mang");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++) 
            {
                Console.Write(" a[{0}] = ", i);
                a[i] = int.Parse(Console.ReadLine());
            }
        }
        static void XoaPhanTuDauTien(int x)
        {
            XoaPhanTuTaiViTri(TimViTriDauTien(x));
        }
        static int TimViTriDauTien(int x)
        {
            for (int i = 0; i < x; i++) 
            {
                if (a[i] == x) 
                {
                    return i;
                }
            }
            return -1;
        }
        static void XoaPhanTuTaiViTri(int vt)
        {
            for (int i = vt; i < length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            length--;
        }
        static int TimViTriCuoiCung(int x)
        {
            for (int i = length - 1; i >= 0; i--)  
            {
                if (a[i] == x) return i;
            }
            return -1;
        }
        static void NhapNgauNhien()
        {
            Console.Write("Nhap vao so phan tu cua mang ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++) 
            {
                a[i] = r.Next(100);
            }
        }
        static int TinhTongCacSoNguyen()
        {
            int tong = 0;
            for (int i = 0; i < length; i++) 
            {
                tong += a[i];
            }
            return tong;
        }
        static void Xuat()
        {
            Console.WriteLine("Mang vua nhap la ");
            for (int i = 0;i < length; i++)
            {
                Console.Write("\t " + a[i]);
            }
        }
    }
}
