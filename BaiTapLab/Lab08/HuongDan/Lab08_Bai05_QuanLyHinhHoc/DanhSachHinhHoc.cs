using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai05_QuanLyHinhHoc
{
    public class DanhSachHinhHoc
    {
        private IHinhHoc[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public IHinhHoc this[int index]
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }

        public DanhSachHinhHoc()
        {
            danhSach = new IHinhHoc[100];
            soLuong = 0;
        }

        public void NhapCoDinh()
        {
            Console.WriteLine("Nhap so luong hinh hoc co dinnh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap hinh hoc thu " + (i + 1) + ":");
                Console.WriteLine("1. Hinh tron");
                Console.WriteLine("2. Hinh vuong");
                Console.WriteLine("3. Hinh chu nhat");
                Console.WriteLine("Chọn loại hình: ");
                int loaiHinh = int.Parse(Console.ReadLine());
                LoaiHinh kieu = (LoaiHinh)loaiHinh;

                switch (kieu)
                {
                    case LoaiHinh.HinhChuNhat:
                        Console.WriteLine("Nhap chieu dai: ");
                        double chieuDai = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap chieu rong: ");
                        double chieuRong = double.Parse(Console.ReadLine());
                        danhSach[soLuong] = new HinhChuNhat(chieuDai, chieuRong);
                        soLuong++;
                        break;
                    case LoaiHinh.HinhVuong:
                        Console.WriteLine("Nhap canh a: ");
                        double a = double.Parse(Console.ReadLine());
                        danhSach[soLuong] = new HinhVuong(a);
                        soLuong++;
                        break;
                    case LoaiHinh.HinhTron:
                        Console.WriteLine("Nhap ban kinh: ");
                        double r = double.Parse(Console.ReadLine());
                        danhSach[soLuong] = new HinhTron(r);
                        soLuong++;
                        break;
                    default:
                        Console.WriteLine("Loai hinh khong hop le");
                        break;
                }
            }
        }

        public void SapXep(ISoSanhHinhHoc ham, ThuTu thuTu)
        {
            int chieu = (int)thuTu;

            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (ham.SoSanh(danhSach[i], danhSach[j])*chieu>0)
                    {
                        IHinhHoc tam = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = tam;
                    }
                }
            }
        }

        public void Them(IHinhHoc taiLieu)
        {
            danhSach[soLuong] = taiLieu;
            soLuong++;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < soLuong; i++)
            {
                result += danhSach[i].ToString() + "\n";
            }
            return result;
        }
    }
}
