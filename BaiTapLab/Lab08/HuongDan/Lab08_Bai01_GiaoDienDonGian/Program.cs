using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai01_GiaoDienDonGian
{
    public class Program
    {
        static void Main(string[] args)
        {
            IHinhHoc tron = new HinhTron(10);
            IHinhHoc chuNhat = new HinhChuNhat(15, 8);

            Console.WriteLine("Chu vi hinh tron     : {0}", tron.TinhChuVi());
            Console.WriteLine("Chu vi hinh chu nhat : {0}", chuNhat.TinhChuVi());

            Console.WriteLine("Dien tich hinh tron     : {0}", tron.TinhDienTich());
            Console.WriteLine("Dien tich hinh chu nhat : {0}", chuNhat.TinhDienTich());

            Console.ReadKey();
        }
    }
}
