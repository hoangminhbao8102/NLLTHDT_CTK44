using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai02_ThucThiNhieuGiaoDien
{
    public class Program
    {
        static void Main(string[] args)
        {
            HinhTron tron = new HinhTron(2, 5, 10);
            HinhChuNhat chuNhat = new HinhChuNhat(3, 1, 10, 7);

            IBienDoi tronBd = tron, chuNhatBd = chuNhat;

            IHinhHoc hinhTron = tron, hinhCn = chuNhat;

            Console.WriteLine("====================================================");
            Console.WriteLine("Truoc khi phong to");
            Console.WriteLine();

            Console.WriteLine(tronBd);
            Console.WriteLine("Chu vi hinh tron    : {0}", hinhTron.TinhChuVi());
            Console.WriteLine("Dien tich hinh tron : {0}",hinhTron.TinhDienTich());
            Console.WriteLine();

            Console.WriteLine(chuNhatBd);
            Console.WriteLine("Chu vi hinh chu nhat    : {0}", hinhCn.TinhChuVi());
            Console.WriteLine("Dien tich hinh chu nhat : {0}", hinhCn.TinhDienTich());
            Console.WriteLine();

            tronBd.ThuPhong(2);
            chuNhatBd.ThuPhong(2);

            Console.WriteLine("====================================================");
            Console.WriteLine("Sau khi phong to");
            Console.WriteLine();

            Console.WriteLine(tronBd);
            Console.WriteLine("Chu vi hinh tron    : {0}", hinhTron.TinhChuVi());
            Console.WriteLine("Dien tich hinh tron : {0}", hinhTron.TinhDienTich());
            Console.WriteLine();

            Console.WriteLine(chuNhatBd);
            Console.WriteLine("Chu vi hinh chu nhat    : {0}", hinhCn.TinhChuVi());
            Console.WriteLine("Dien tich hinh chu nhat : {0}", hinhCn.TinhDienTich());
            Console.WriteLine();

            tronBd.TinhTien(-5, 19);
            chuNhatBd.TinhTien(-5, 19);

            Console.WriteLine("====================================================");
            Console.WriteLine("Sau khi tinh tien");
            Console.WriteLine();

            Console.WriteLine(tronBd);
            Console.WriteLine("Chu vi hinh tron    : {0}", hinhTron.TinhChuVi());
            Console.WriteLine("Dien tich hinh tron : {0}", hinhTron.TinhDienTich());
            Console.WriteLine();

            Console.WriteLine(chuNhatBd);
            Console.WriteLine("Chu vi hinh chu nhat    : {0}", hinhCn.TinhChuVi());
            Console.WriteLine("Dien tich hinh chu nhat : {0}", hinhCn.TinhDienTich());
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
