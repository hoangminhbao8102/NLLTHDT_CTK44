using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai06_Lab02_D_Bai05_P2__
{
    public class Program
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
            for (int i = 0; i < SoLuong; i++)
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

        // Xóa phần tử x trong danh sách
        static void XoaPhanTuX(int x)
        {
            int j = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] != x)
                {
                    mang[j++] = mang[i];
                }
            }
            SoLuong = j;
        }

        // Xóa phần tử theo vị trí
        static void XoaPhanTuTaiViTri(int index)
        {
            for (int i = index; i < SoLuong - 1; i++)
            {
                mang[i] = mang[i + 1];
            }
            SoLuong--;
        }

        // Xóa tất cả phần tử x trong danh sách
        static void XoaTatCaPhanTuX(int x)
        {
            XoaPhanTuX(x); // Re-use the function as it already does what's required
        }

        // Xóa tất cả số âm trong danh sách
        static void XoaSoAm()
        {
            int j = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] >= 0)
                {
                    mang[j++] = mang[i];
                }
            }
            SoLuong = j;
        }

        // Tìm phần tử lớn nhất trong mảng
        static int TimPhanTuLonNhat()
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

        // Tìm vị trí đầu tiên của phần tử lớn nhất trong mảng
        static int TimViTriDauTienPhanTuLonNhat()
        {
            int max = TimPhanTuLonNhat();
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] == max) return i;
            }
            return -1; // Trường hợp không tìm thấy
        }

        // Xóa tất cả phần tử lớn nhất trong mảng
        static void XoaTatCaPhanTuLonNhat()
        {
            int max = TimPhanTuLonNhat();
            XoaPhanTuX(max);
        }

        // Tìm tất cả vị trí của phần tử lớn nhất trong mảng
        static int[] TimTatCaViTriPhanTuLonNhat()
        {
            int max = TimPhanTuLonNhat();
            int count = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] == max) count++;
            }

            int[] positions = new int[count];
            int j = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] == max)
                {
                    positions[j++] = i;
                }
            }
            return positions;
        }

        // Thay thế phần tử x bằng phần tử y trong danh sách
        static void ThayThePhanTuXBangY(int x, int y)
        {
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] == x) mang[i] = y;
            }
        }

        // Chèn một phần tử vào trong danh sách tại vị trí bất kỳ
        static void ChenPhanTu(int x, int viTri)
        {
            if (SoLuong >= mang.Length) return; // Kiểm tra nếu mảng đã đầy

            for (int i = SoLuong; i > viTri; i--)
            {
                mang[i] = mang[i - 1];
            }
            mang[viTri] = x;
            SoLuong++;
        }

        // Chèn một phần tử x vào trước phần tử y trong danh sách
        static void ChenXTruocY(int x, int y)
        {
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] == y)
                {
                    ChenPhanTu(x, i);
                    return;
                }
            }
        }

        // Chèn một phần tử x vào sau phần tử y trong danh sách
        static void ChenXSauY(int x, int y)
        {
            for (int i = 0; i < SoLuong; i++)
            {
                if (mang[i] == y)
                {
                    ChenPhanTu(x, i + 1);
                    return;
                }
            }
        }

        // Đảo ngược danh sách
        static void DaoNguocDanhSach()
        {
            for (int i = 0; i < SoLuong / 2; i++)
            {
                int temp = mang[i];
                mang[i] = mang[SoLuong - 1 - i];
                mang[SoLuong - 1 - i] = temp;
            }
        }

        // Đếm số phần tử không tính trùng nhau trong danh sách
        static int DemPhanTuKhongTrung()
        {
            int count = 0;
            bool[] isVisited = new bool[SoLuong];

            for (int i = 0; i < SoLuong; i++)
            {
                if (!isVisited[i])
                {
                    count++;
                    for (int j = i + 1; j < SoLuong; j++)
                    {
                        if (mang[i] == mang[j])
                        {
                            isVisited[j] = true;
                        }
                    }
                }
            }

            return count;
        }

        // Xóa tất cả phần tử trùng nhau trong danh sách
        static void XoaPhanTuTrung()
        {
            int j = 0;
            bool[] isVisited = new bool[SoLuong];

            for (int i = 0; i < SoLuong; i++)
            {
                if (!isVisited[i])
                {
                    mang[j++] = mang[i];
                    for (int k = i + 1; k < SoLuong; k++)
                    {
                        if (mang[i] == mang[k])
                        {
                            isVisited[k] = true;
                        }
                    }
                }
            }
            SoLuong = j;
        }

        // Tính trung bình cộng các phần tử trong mảng
        static double TinhTrungBinhCong()
        {
            int sum = 0;
            for (int i = 0; i < SoLuong; i++)
            {
                sum += mang[i];
            }
            return (double)sum / SoLuong;
        }

        // Tính tổng các phần tử chỉ xuất hiện một lần trong mảng
        static int TinhTongPhanTuXuatHienMotLan()
        {
            int sum = 0;
            bool[] isCounted = new bool[SoLuong];

            for (int i = 0; i < SoLuong; i++)
            {
                if (!isCounted[i])
                {
                    bool isUnique = true;
                    for (int j = 0; j < SoLuong; j++)
                    {
                        if (i != j && mang[i] == mang[j])
                        {
                            isUnique = false;
                            isCounted[j] = true;
                        }
                    }
                    if (isUnique)
                    {
                        sum += mang[i];
                    }
                    isCounted[i] = true;
                }
            }

            return sum;
        }

        static void InMenu()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập mảng bằng tay", (int)ThucDon.NhapMangBangTay);
            Console.WriteLine("{0}. Nhập mảng ngẫu nhiên", (int)ThucDon.NhapNgauNhien);
            Console.WriteLine("{0}. Xuất các phần tử của mảng", (int)ThucDon.XuatMang);
            Console.WriteLine("{0}. Xóa phần tử x đầu tiên", (int)ThucDon.XoaPhanTuDauTienX);
            Console.WriteLine("{0}. Xóa phần tử tại vị trí cho trước", (int)ThucDon.XoaPhanTuTaiViTri);
            Console.WriteLine("{0}. Xóa tất cả phần tử x", (int)ThucDon.XoaTatCaPhanTuX);
            Console.WriteLine("{0}. Xóa tất cả số âm", (int)ThucDon.XoaTatCaSoAm);
            Console.WriteLine("{0}. Tìm phần tử lớn nhất", (int)ThucDon.TimPhanTuLonNhat);
            Console.WriteLine("{0}. Tìm vị trí đầu tiên của phần tử lớn nhất", (int)ThucDon.TimViTriPhanTuLonNhat);
            Console.WriteLine("{0}. Tìm tất cả vị trí của phần tử lớn nhất", (int)ThucDon.TimTatCaViTriPhanTuLonNhat);
            Console.WriteLine("{0}. Xóa tất cả phần tử lớn nhất", (int)ThucDon.XoaTatCaPhanTuLonNhat);
            Console.WriteLine("{0}. Thay thế phần tử x bằng y", (int)ThucDon.ThayThePhanTuXBangY);
            Console.WriteLine("{0}. Chèn phần tử tại vị trí bất kỳ", (int)ThucDon.ChenPhanTuTaiViTriBatKy);
            Console.WriteLine("{0}. Chèn phần tử x trước y", (int)ThucDon.ChenPhanTuXTruocY);
            Console.WriteLine("{0}. Chèn phần tử x sau y", (int)ThucDon.ChenPhanTuXSauY);
            Console.WriteLine("{0}. Đảo ngược danh sách", (int)ThucDon.DaoNguocDanhSach);
            Console.WriteLine("{0}. Đếm số phần tử không trùng nhau", (int)ThucDon.DemSoPhanTuKhongTrungNhau);
            Console.WriteLine("{0}. Xóa tất cả phần tử trùng nhau", (int)ThucDon.XoaTatCaPhanTuTrungNhau);
            Console.WriteLine("{0}. Tính trung bình cộng các phần tử", (int)ThucDon.TinhTrungBinhCongCacPhanTu);
            Console.WriteLine("{0}. Tính tổng các phần tử chỉ xuất hiện một lần", (int)ThucDon.TinhTongCacPhanTuChiXuatHienMotLan);
            Console.WriteLine("{0}. Thoát", (int)ThucDon.Thoat);
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
                case ThucDon.NhapMangBangTay:
                    NhapMang();
                    break;
                case ThucDon.NhapNgauNhien:
                    NhapNgauNhien();
                    break;
                case ThucDon.XuatMang:
                    XuatMang();
                    break;
                case ThucDon.XoaPhanTuDauTienX:
                    Console.Write("Nhap gia tri phan tu can xoa: ");
                    int xoaDauTien = int.Parse(Console.ReadLine());
                    XoaPhanTuX(xoaDauTien);
                    break;
                case ThucDon.XoaPhanTuTaiViTri:
                    Console.Write("Nhap vi tri phan tu can xoa: ");
                    int viTri = int.Parse(Console.ReadLine());
                    XoaPhanTuTaiViTri(viTri);
                    break;
                case ThucDon.XoaTatCaPhanTuX:
                    Console.Write("Nhap gia tri phan tu can xoa: ");
                    int xoaTatCa = int.Parse(Console.ReadLine());
                    XoaTatCaPhanTuX(xoaTatCa);
                    break;
                case ThucDon.XoaTatCaSoAm:
                    XoaSoAm();
                    break;
                case ThucDon.TimPhanTuLonNhat:
                    int max = TimPhanTuLonNhat();
                    Console.WriteLine("Phan tu lon nhat trong mang la: " + max);
                    break;
                case ThucDon.TimViTriPhanTuLonNhat:
                    int viTriMax = TimViTriDauTienPhanTuLonNhat();
                    Console.WriteLine("Vi tri dau tien cua phan tu lon nhat la: " + viTriMax);
                    break;
                case ThucDon.XoaTatCaPhanTuLonNhat:
                    XoaTatCaPhanTuLonNhat();
                    break;
                case ThucDon.ThayThePhanTuXBangY:
                    Console.Write("Nhap gia tri can thay the: ");
                    int x = int.Parse(Console.ReadLine());
                    Console.Write("Nhap gia tri moi: ");
                    int y = int.Parse(Console.ReadLine());
                    ThayThePhanTuXBangY(x, y);
                    break;
                case ThucDon.ChenPhanTuTaiViTriBatKy:
                    Console.Write("Nhap gia tri can chen: ");
                    int giaTriChen = int.Parse(Console.ReadLine());
                    Console.Write("Nhap vi tri can chen: ");
                    int viTriChen = int.Parse(Console.ReadLine());
                    ChenPhanTu(giaTriChen, viTriChen);
                    break;
                case ThucDon.ChenPhanTuXTruocY:
                    Console.Write("Nhap gia tri can chen: ");
                    int giaTriXTruocY = int.Parse(Console.ReadLine());
                    Console.Write("Nhap gia tri y: ");
                    int giaTriYTruocY = int.Parse(Console.ReadLine());
                    ChenXTruocY(giaTriXTruocY, giaTriYTruocY);
                    break;
                case ThucDon.ChenPhanTuXSauY:
                    Console.Write("Nhap gia tri can chen: ");
                    int giaTriXSauY = int.Parse(Console.ReadLine());
                    Console.Write("Nhap gia tri y: ");
                    int giaTriYSauY = int.Parse(Console.ReadLine());
                    ChenXSauY(giaTriXSauY, giaTriYSauY);
                    break;
                case ThucDon.DaoNguocDanhSach:
                    DaoNguocDanhSach();
                    break;
                case ThucDon.DemSoPhanTuKhongTrungNhau:
                    int soPhanTuKhongTrung = DemPhanTuKhongTrung();
                    Console.WriteLine("So phan tu khong trung nhau la: " + soPhanTuKhongTrung);
                    break;
                case ThucDon.XoaTatCaPhanTuTrungNhau:
                    XoaPhanTuTrung();
                    break;
                case ThucDon.TinhTrungBinhCongCacPhanTu:
                    double trungBinhCong = TinhTrungBinhCong();
                    Console.WriteLine("Trung binh cong cac phan tu la: " + trungBinhCong);
                    break;
                case ThucDon.TinhTongCacPhanTuChiXuatHienMotLan:
                    int tongPhanTuXuatHienMotLan = TinhTongPhanTuXuatHienMotLan();
                    Console.WriteLine("Tong cac phan tu chi xuat hien mot lan la: " + tongPhanTuXuatHienMotLan);
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
