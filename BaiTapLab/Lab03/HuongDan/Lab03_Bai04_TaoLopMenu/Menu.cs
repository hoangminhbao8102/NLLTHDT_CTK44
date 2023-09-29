using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai04_TaoLopMenu
{
    class Menu
    {
        private MangSoNguyen MangNguyen;

        public Menu()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhap mang bang tay", (int)ChucNang.NhapMang);
            Console.WriteLine("{0}. Nhap ngau nhien", (int)ChucNang.NhapNgauNhien);
            Console.WriteLine("{0}. Xuat cac phan tu cua mang", (int)ChucNang.XuatMang);
            Console.WriteLine("{0}. Tinh tong cac phan tu", (int)ChucNang.TinhTong);
            Console.WriteLine("{0}. Tim phan tu lon nhat", (int)ChucNang.TimMax);
            Console.WriteLine("{0}. Tim vi tri cua phan tu X", (int)ChucNang.TimViTri);
            Console.WriteLine("{0}. Tim vi tri phan tu lon nhat", (int)ChucNang.TimViTriMax);
            Console.WriteLine("{0}. Xoa phan tu tai vi tri cho truoc", (int)ChucNang.XoaTaiViTri);
            Console.WriteLine("{0}. Xoa phan tu X khoi mang", (int)ChucNang.XoaPhanTuX);
            Console.WriteLine("{0}. Thoat", (int)ChucNang.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNang Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNang)).Length;

            int menu = 0;

            do
            {
                this.Show();
                Console.Write("Nhap so de chon menu (0..{0}) : ", SoMenu);
            } while (menu < 0 || menu >= SoMenu);

            return (ChucNang)menu;
        }

        private void Process(ChucNang menu)
        {
            int tong, x, max, viTri;

            switch (menu) 
            {
                case ChucNang.Thoat:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
                case ChucNang.NhapMang:
                    MangNguyen.NhapMang();
                    break;
                case ChucNang.NhapNgauNhien:
                    MangNguyen.NhapNgauNhien();
                    Console.WriteLine("Da nhap xong, chon chuc nang 3 de xem");
                    break;
                case ChucNang.XuatMang:
                    MangNguyen.XuatMang();
                    break;
                case ChucNang.TinhTong:
                    tong = MangNguyen.TinhTong();
                    Console.WriteLine("Tong cac phan tu cua mang la : {0}", tong);
                    break;
                case ChucNang.TimMax:
                    max = MangNguyen.TimSoLonNhat();
                    Console.WriteLine("So lon nhat trong mang la : {0}", max);
                    break;
                case ChucNang.TimViTri:
                    Console.WriteLine("Nhap gia tri muon tim vi tri: ");
                    x = int.Parse(Console.ReadLine());
                    viTri = MangNguyen.TimViTri(x);
                    Console.WriteLine("Vi tri cua {0} trong mang la : {1}", x, viTri);
                    break;
                case ChucNang.TimViTriMax:
                    int ViTriMax = MangNguyen.TimViTriMax();
                    Console.WriteLine("Vi tri dau tien cua so lon nhat trong mang la : {0}", ViTriMax);
                    break;
                case ChucNang.XoaTaiViTri:
                    Console.WriteLine("Nhap vi tri muon xoa: ");
                    int ViTriXoa = int.Parse(Console.ReadLine());
                    MangNguyen.XoaTaiViTri(ViTriXoa);
                    break;
                case ChucNang.XoaPhanTuX:
                    Console.WriteLine("Nhap gia tri muon xoa: ");
                    int XoaX = int.Parse(Console.ReadLine());
                    bool DaXoa = MangNguyen.XoaPhanTuX(XoaX);
                    if (DaXoa)
                    {
                        Console.WriteLine("Da xoa phan tu {0} khoi mang", XoaX);
                    }
                    else
                    {
                        Console.WriteLine("Khong tim thay phan tu {0} trong mang", XoaX);
                    }
                    break;
                default:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
            }
        }

        public void Run()
        {
            ChucNang menu = ChucNang.Thoat;
            do
            {
                menu = this.Select();
                this.Process(menu);
            } while (menu != ChucNang.Thoat);
        }
    }
}
