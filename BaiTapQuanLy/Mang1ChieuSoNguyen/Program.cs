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

            Console.WriteLine("Phan tu lon nhat la " + TimPhanTuLonNhat());
            Console.WriteLine("Phan tu nho nhat la " + TimPhanTuNhoNhat());

            int lengthkq = 0; // Khởi tạo lengthkq với giá trị mặc định là 0

            int[] ketqua;

            ketqua = TimTatCaCacSoAm(ref lengthkq);
            Console.WriteLine("Cac so am trong mang la: ");
            XuatMang(ketqua, lengthkq);

            ketqua = TimTatCaCacSoDuong(ref lengthkq);
            Console.WriteLine("Cac so duong trong mang la: ");
            XuatMang(ketqua, lengthkq);

            ketqua = TimTatCaCacSoChan(ref lengthkq);
            Console.WriteLine("Cac so chan trong mang la: ");
            XuatMang(ketqua, lengthkq);

            ketqua = TimTatCaCacSoLe(ref lengthkq);
            Console.WriteLine("Cac so le trong mang la: ");
            XuatMang(ketqua, lengthkq);

            ketqua = TimTatCaCacSoNguyenTo(ref lengthkq);
            Console.WriteLine("Cac so nguyen to trong mang la: ");
            XuatMang(ketqua, lengthkq);

            ketqua = TimPhanTuXuatHienNhieuNhat(ref lengthkq);
            Console.WriteLine("Cac phan tu xuat hien nhieu nhat trong mang la: ");
            XuatMang(ketqua, lengthkq);

            ketqua = TimPhanTuXuatHienItNhat(ref lengthkq);
            Console.WriteLine("Cac phan tu xuat hien it nhat trong mang la: ");
            XuatMang(ketqua, lengthkq);

            ketqua = TimTatCaPhanTuLonHon(ref lengthkq, y);
            Console.WriteLine("Cac phan tu lon hon {0} la: ", y);
            XuatMang(ketqua, lengthkq);

            ketqua = TimTatCaPhanTuNhoHon(ref lengthkq, y);
            Console.WriteLine("Cac phan tu nho hon {0} la: ", y);
            XuatMang(ketqua, lengthkq);

            int vt2 = 0;
            ketqua = TimTatCaPhanTuViTri(ref lengthkq, vt2, 5);
            Console.WriteLine("Cac phan tu tu vi tri {0} la: ", vt2);
            XuatMang(ketqua, lengthkq);

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

        static void XuatMang(int[] arr, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("\t " + arr[i]);
            }
        }

        static int TimPhanTuLonNhat()
        {
            int max = a[0];
            for (int i = 1; i < length; i++)
            {
                if (a[i] > max) 
                {
                    max = a[i];
                }
            }
            return max;
        }

        static int TimPhanTuNhoNhat()
        {
            int min = a[0];
            for (int i = 1; i < length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        static int[] TimTatCaCacSoAm(ref int lengthkq)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] < 0)
                {
                    kq[lengthkq] = a[i];
                    lengthkq++;
                }
            }
            return kq;
        }

        static int[] TimTatCaCacSoDuong(ref int lengthkq)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] > 0)
                {
                    kq[lengthkq] = a[i];
                    lengthkq++;
                }
            }
            return kq;
        }

        static int[] TimTatCaCacSoChan(ref int lengthkq)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 == 0) 
                {
                    kq[lengthkq] = a[i];
                    lengthkq++;
                }
            }
            return kq;
        }

        static int[] TimTatCaCacSoLe(ref int lengthkq)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 != 0) 
                {
                    kq[lengthkq] = a[i];
                    lengthkq++;
                }
            }
            return kq;
        }

        static bool KiemTra(int x)
        {
            if (x <= 1)
                return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        static int[] TimTatCaCacSoNguyenTo(ref int lengthkq)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = 0; i < length; i++)
            {
                if (KiemTra(a[i]))
                {
                    kq[lengthkq] = a[i];
                    lengthkq++;
                }
            }
            return kq;
        }

        static int[] TimPhanTuXuatHienNhieuNhat(ref int lengthkq)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in a)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            int maxFrequency = frequencyMap.Values.Max();

            int[] mostFrequentElements = new int[length];
            int count = 0;
            foreach (var entry in frequencyMap)
            {
                if (entry.Value == maxFrequency)
                {
                    mostFrequentElements[count++] = entry.Key;
                }
            }

            lengthkq = count;

            return mostFrequentElements;
        }

        static int[] TimPhanTuXuatHienItNhat(ref int lengthkq)
        {
            Dictionary<int, int> frequencyMap = new Dictionary<int, int>();

            foreach (int num in a)
            {
                if (frequencyMap.ContainsKey(num))
                {
                    frequencyMap[num]++;
                }
                else
                {
                    frequencyMap[num] = 1;
                }
            }

            int minFrequency = frequencyMap.Values.Min();

            int[] leastFrequentElements = new int[length];
            int count = 0;
            foreach (var entry in frequencyMap)
            {
                if (entry.Value == minFrequency)
                {
                    leastFrequentElements[count++] = entry.Key;
                }
            }

            lengthkq = count;

            return leastFrequentElements;
        }

        static int[] TimTatCaPhanTuLonHon(ref int lengthkq, int x)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] > x)
                {
                    kq[lengthkq] = a[i];
                    lengthkq++;
                }
            }
            return kq;
        }

        static int[] TimTatCaPhanTuNhoHon(ref int lengthkq, int x)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] < x)
                {
                    kq[lengthkq] = a[i];
                    lengthkq++;
                }
            }
            return kq;
        }

        static int[] TimTatCaPhanTuViTri(ref int lengthkq, int vt, int soLuong)
        {
            int[] kq = new int[100];
            lengthkq = 0;
            for (int i = vt; i < vt + soLuong && i < length; i++)
            {
                kq[lengthkq] = a[i];
                lengthkq++;
            }
            return kq;
        }

        static bool ThemPhanTuTaiViTri(int x, int vt)
        {
            if (vt < 0 || vt > length)
                return false;
            for (int i = length; i > vt; i--)
            {
                a[i] = a[i - 1];
            }
            a[vt] = x;
            length++;
            return true;
        }

        static bool ThemPhanTuDauDanhSach(int x)
        {
            return ThemPhanTuTaiViTri(x, 0);
        }

        static bool ThemPhanTuCuoiDanhSach(int x)
        {
            return ThemPhanTuTaiViTri(x, length);
        }

        static bool ThemMotMangVaoDanhSachTaiViTri(int[] b, int lengthb, int vt)
        {
            if (vt < 0 || vt > length)
                return false;
            for (int i = length - 1; i >= vt; i--)
            {
                a[i + lengthb] = a[i];
            }
            for (int i = 0; i < lengthb; i++)
            {
                a[vt + i] = b[i];
            }
            length += lengthb;
            return true;
        }

        static bool ThemMotMangVaoDauDanhSach(int[] b, int lengthb)
        {
            return ThemMotMangVaoDanhSachTaiViTri(b, lengthb, 0);
        }

        static bool ThemMotMangVaoCuoiDanhSach(int[] b, int lengthb)
        {
            return ThemMotMangVaoDanhSachTaiViTri(b, lengthb, length);
        }

        static bool XoaPhanTuDau(int vt)
        {
            XoaPhanTuTaiViTri(vt);
            if (a[vt] == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool XoaPhanTuCuoi(int vt)
        {
            if (vt < 0 || vt >= length)
                return false;
            length--;
            return true;
        }

        static bool XoaPhanTuCoTrongMang(int[] b, int lengthb)
        {
            bool deleted = false;
            for (int i = 0; i < lengthb; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (a[j] == b[i])
                    {
                        XoaPhanTuTaiViTri(j);
                        deleted = true;
                        break;
                    }
                }
            }
            return deleted;
        }

        static bool XoaTatCaPhanTu()
        {
            length = 0;
            return true;
        }

        static bool XoaTatCaSoAm()
        {
            bool deleted = false;
            for (int i = 0; i < length; i++)
            {
                if (a[i] < 0)
                {
                    XoaPhanTuTaiViTri(i);
                    i--;
                    deleted = true;
                }
            }
            return deleted;
        }

        static bool XoaTatCaSoDuong()
        {
            bool deleted = false;
            for (int i = 0; i < length; i++)
            {
                if (a[i] > 0)
                {
                    XoaPhanTuTaiViTri(i);
                    i--;
                    deleted = true;
                }
            }
            return deleted;
        }

        static bool XoaTatCaSoChan()
        {
            bool deleted = false;
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    XoaPhanTuTaiViTri(i);
                    i--;
                    deleted = true;
                }
            }
            return deleted;
        }

        static bool XoaTatCaSoLe()
        {
            bool deleted = false;
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    XoaPhanTuTaiViTri(i);
                    i--;
                    deleted = true;
                }
            }
            return deleted;
        }

        static bool XoaTatCaSoNguyenTo()
        {
            bool deleted = false;
            for (int i = 0; i < length; i++)
            {
                if (KiemTra(a[i]))
                {
                    XoaPhanTuTaiViTri(i);
                    i--;
                    deleted = true;
                }
            }
            return deleted;
        }

        static bool XoaTatCaPhanTuTrungNhau()
        {
            bool deleted = false;
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (a[i] == a[j])
                    {
                        XoaPhanTuTaiViTri(j);
                        j--;
                        deleted = true;
                    }
                }
            }
            return deleted;
        }

        static bool XoaPhanTuXuatHienNhieuNhat()
        {
            int lengthkq = 0; 
            int[] mostFrequentElements = TimPhanTuXuatHienNhieuNhat(ref lengthkq);

            if (lengthkq > 0)
            {
                foreach (int num in mostFrequentElements)
                {
                    while (TimViTriDauTien(num) != -1)
                    {
                        XoaPhanTuDauTien(num);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool XoaPhanTuXuatHienItNhat()
        {
            int lengthkq = 0;
            int[] leastFrequentElements = TimPhanTuXuatHienItNhat(ref lengthkq);

            if (lengthkq > 0)
            {
                foreach (int num in leastFrequentElements)
                {
                    while (TimViTriDauTien(num) != -1)
                    {
                        XoaPhanTuDauTien(num);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool ThayThePhanTu(int cu, int moi)
        {
            bool replaced = false;
            for (int i = 0; i < length; i++)
            {
                if (a[i] == cu)
                {
                    a[i] = moi;
                    replaced = true;
                }
            }
            return replaced;
        }

        static int DemSoLanXuatHienCuaPhanTu(int x)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] == x)
                {
                    count++;
                }
            }
            return count;
        }

        static int DemSoDuong()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] > 0)
                {
                    count++;
                }
            }
            return count;
        }

        static int DemSoAm()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] < 0)
                {
                    count++;
                }
            }
            return count;
        }

        static int DemSoNguyenTo()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (KiemTra(a[i]))
                {
                    count++;
                }
            }
            return count;
        }

        static int DemSoChan()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }

        static int DemSoLe()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i] % 2 != 0)
                {
                    count++;
                }
            }
            return count;
        }

        static void SapXepTang()
        {
            Array.Sort(a, 0, length);
        }

        static void SapXepGiam()
        {
            Array.Sort(a, 0, length);
            Array.Reverse(a, 0, length);
        }

        static void DaoNguocMang()
        {
            for (int i = 0; i < length / 2; i++)
            {
                int temp = a[i];
                a[i] = a[length - 1 - i];
                a[length - 1 - i] = temp;
            }
        }
    }
}
