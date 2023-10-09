using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai04_KeThuaGiaoDien
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
            Console.WriteLine("Dien tich hinh tron : {0}", hinhTron.TinhDienTich());
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

            IComparable tronKhac = new HinhTron(2, 5, 10);
            IComparable chuNhatKhac = new HinhChuNhat(3, 1, 15, 8);

            Console.WriteLine("Dien tich hinh tron     : {0}",((IHinhHoc)tronKhac).TinhDienTich());
            Console.WriteLine("Dien tich hinh chu nhat : {0}", ((IHinhHoc)chuNhatKhac).TinhDienTich());

            int ketQua = tronKhac.CompareTo(chuNhatKhac);

            switch (ketQua)
            {
                case -1:
                    Console.WriteLine("Hinh tron co dien tich nho hon");
                    break;
                case 0:
                    Console.WriteLine("Hai hinh co dien tich bang nhau");
                    break;
                case 1:
                    Console.WriteLine("Hinh tron co dien tich lon hon");
                    break;
            }

            HinhTron hinhTron1 = new HinhTron(0, 0, 5);
            Console.WriteLine("Hinh tron ban dau:");
            Console.WriteLine(hinhTron1.ToString());

            HinhTron hinhTron2 = (HinhTron)hinhTron1.Clone();
            Console.WriteLine("Hinh tron sao chep:");
            Console.WriteLine(hinhTron2.ToString());

            hinhTron1.TinhTien(3, 2);
            Console.WriteLine("Hinh tron sau khi tinh tien:");
            Console.WriteLine(hinhTron1.ToString());

            hinhTron2.ThuPhong(2);
            Console.WriteLine("Hinh tron sao chep sau khi thu phong:");
            Console.WriteLine(hinhTron2.ToString());

            Console.WriteLine();

            HinhChuNhat hinhChuNhat1 = new HinhChuNhat(0, 0, 3, 4);
            Console.WriteLine("Hinh chu nhat ban dau:");
            Console.WriteLine(hinhChuNhat1.ToString());

            HinhChuNhat hinhChuNhat2 = (HinhChuNhat)hinhChuNhat1.Clone();
            Console.WriteLine("Hinh chu nhat sao chep:");
            Console.WriteLine(hinhChuNhat2.ToString());

            hinhChuNhat1.TinhTien(1, 1);
            Console.WriteLine("Hinh chu nhat sau khi tinh tien:");
            Console.WriteLine(hinhChuNhat1.ToString());

            hinhChuNhat2.ThuPhong(2);
            Console.WriteLine("Hinh chu nhat sao chep sau khi thu phong:");
            Console.WriteLine(hinhChuNhat2.ToString());

            Console.ReadKey();
        }
    }
}
