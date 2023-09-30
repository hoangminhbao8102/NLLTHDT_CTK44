using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai04_CacThaoTacMang
{
    class Program
    {
        static int[] mang = new int[1000];

        static int SoLuong = 0;

        static void NhapMang()
        {
            Console.Write("Nhap so luong phan tu cua mang : ");
            SoLuong = int.Parse(Console.ReadLine());

            for (int i = 0; i < SoLuong; i++)
            {
                Console.Write("Mang[{0}] = ", i);
                mang[i] = int.Parse(Console.ReadLine());
            }
        }

        static void XuatMang()
        {
            Console.WriteLine("Cac phan tu cua mang : ");
            for (int i = 0;i < SoLuong; i++) 
            {
                Console.Write("{0}\t", mang[i]);
            }
            Console.WriteLine();
        }

        static void NhapNgauNhien()
        {
            Console.Write("Nhap so luong phan tu cua mang : ");
            SoLuong = int.Parse(Console.ReadLine());

            Random rd = new Random();

            for (int i = 0; i < SoLuong; i++)
            {
                mang[i] = rd.Next(1000);
            }
        }

        static int TinhTong()
        {
            int sum = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                sum += mang[i];
            }
            return sum;
        }

        static int TimSoLonNhat()
        {
            int max = mang[0];
            for (int i = 1; i < SoLuong; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
            }
            return max;
        }

        static int TimViTri(int x)
        {
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        static int TimViTriMax()
        {
            int max = TimSoLonNhat();
            return TimViTri(max);
        }

        static void XoaTaiViTri(int ViTri)
        {
            if (ViTri < 0 || ViTri >= SoLuong)
            {
                return; // Không làm gì nếu vị trí không hợp lệ
            }

            for (int i = ViTri; i < SoLuong - 1; i++)
            {
                mang[i] = mang[i + 1];
            }

            SoLuong--;
        }

        static bool XoaPhanTuX(int x)
        {
            int viTriX = TimViTri(x);
            if (viTriX == -1)
            {
                return false; // Trả về false nếu không tìm thấy x trong mảng
            }

            XoaTaiViTri(viTriX);
            return true;
        }

        static void InMenu()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhap mang bang tay", (int)ThucDon.NhapMang);
            Console.WriteLine("{0}. Nhap ngau nhien", (int)ThucDon.NhapNgauNhien);
            Console.WriteLine("{0}. Xuat cac phan tu cua mang", (int)ThucDon.XuatMang);
            Console.WriteLine("{0}. Tinh tong cac phan tu", (int)ThucDon.TinhTong);
            Console.WriteLine("{0}. Tim phan tu lon nhat", (int)ThucDon.TimMax);
            Console.WriteLine("{0}. Tim vi tri cua phan tu X", (int)ThucDon.TimViTri);
            Console.WriteLine("{0}. Tim vi tri phan tu lon nhat", (int)ThucDon.TimViTriMax);
            Console.WriteLine("{0}. Xoa phan tu tai vi tri cho truoc", (int)ThucDon.XoaTaiViTri);
            Console.WriteLine("{0}. Xoa phan tu X khoi mang", (int)ThucDon.XoaPhanTuX);
            Console.WriteLine("{0}. Thoat", (int)ThucDon.Thoat);
            Console.WriteLine("==================================================");
        }

        static ThucDon ChonMenu()
        {
            int SoMenu = Enum.GetNames(typeof(ThucDon)).Length;

            int menu = 0;
            do
            {
                InMenu();
                Console.Write("Nhap so de chon menu (0..{0}) : ", SoMenu);

                menu = int.Parse(Console.ReadLine());
            } while (menu < 0 || menu >= SoMenu);

            return (ThucDon)menu;
        }

        static void XuLy(ThucDon menu)
        {
            switch (menu)
            {
                case ThucDon.Thoat:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
                case ThucDon.NhapMang:
                    NhapMang();
                    break;
                case ThucDon.NhapNgauNhien:
                    NhapNgauNhien();
                    break;
                case ThucDon.XuatMang:
                    XuatMang();
                    break;
                case ThucDon.TinhTong:
                    int Tong = TinhTong();
                    Console.WriteLine("Tong cac phan tu cua mang la : {0}", Tong);
                    break;
                case ThucDon.TimMax:
                    int Max = TimSoLonNhat();
                    Console.WriteLine("So lon nhat trong mang la : {0}", Max);
                    break;
                case ThucDon.TimViTri:
                    Console.WriteLine("Nhap gia tri muon tim vi tri: ");
                    int x = int.Parse(Console.ReadLine());
                    int ViTri = TimViTri(x);
                    Console.WriteLine("Vi tri cua {0} trong mang la : {1}", x, ViTri);
                    break;
                case ThucDon.TimViTriMax:
                    int ViTriMax = TimViTriMax();
                    Console.WriteLine("Vi tri dau tien cua so lon nhat trong mang la : {0}", ViTriMax);
                    break;
                case ThucDon.XoaTaiViTri:
                    Console.WriteLine("Nhap vi tri muon xoa: ");
                    int ViTriXoa = int.Parse(Console.ReadLine());
                    XoaTaiViTri(ViTriXoa);
                    break;
                case ThucDon.XoaPhanTuX:
                    Console.WriteLine("Nhap gia tri muon xoa: ");
                    int XoaX = int.Parse(Console.ReadLine());
                    bool DaXoa = XoaPhanTuX(XoaX);
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
                    Console.WriteLine("Loi nhap menu! Vui long nhap lai");
                    break;
            }
        }

        static void ChayChuongTrinh()
        {
            ThucDon menu = ThucDon.Thoat;
            do
            {
                menu = ChonMenu();
                XuLy(menu);
            } while (menu != ThucDon.Thoat);
        }

        static void Main(string[] args)
        {
            ChayChuongTrinh();
            Console.ReadKey();
        }
    }
}
