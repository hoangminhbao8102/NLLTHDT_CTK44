using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    public class MangSoNguyen
    {
        private List<int> a;
        private int length;

        public int Length
        { 
            get { return length; }
            set { length = value; }
        }

        public MangSoNguyen()
        {
            a = new List<int>();
            length = 0;
        }

        public void Nhap()
        {
            Console.Write("Nhập vào số phần tử của mảng: ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                Console.Write($"a[{i}] = ");
                a.Add(int.Parse(Console.ReadLine()));
            }
        }

        public void XoaPhanTuDauTien(int x)
        {
            int index = a.IndexOf(x);
            if (index != -1) a.RemoveAt(index);
        }

        public int TimViTriDauTien(int x)
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

        public void XoaPhanTuTaiViTri(int vt)
        {
            for (int i = vt; i < length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            length--;
        }

        public int TimViTriCuoiCung(int x)
        {
            for (int i = length - 1; i >= 0; i--)
            {
                if (a[i] == x) return i;
            }
            return -1;
        }

        public void NhapNgauNhien()
        {
            Console.Write("Nhập vào số phần tử của mảng: ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                a.Add(r.Next(100));
            }
        }

        public int TinhTongCacSoNguyen()
        {
            int tong = 0;
            for (int i = 0; i < length; i++)
            {
                tong += a[i];
            }
            return tong;
        }

        public void Xuat()
        {
            Console.WriteLine("Mảng vừa nhập là: ");
            for (int i = 0; i < length; i++)
            {
                Console.Write("\t " + a[i]);
            }
        }

        public void XuatMang(int[] arr, int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("\t " + arr[i]);
            }
        }

        public int TimPhanTuLonNhat()
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

        public int TimPhanTuNhoNhat()
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

        public int[] TimTatCaCacSoAm(ref int lengthkq)
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

        public int[] TimTatCaCacSoDuong(ref int lengthkq)
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

        public int[] TimTatCaCacSoChan(ref int lengthkq)
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

        public int[] TimTatCaCacSoLe(ref int lengthkq)
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

        public bool KiemTra(int x)
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

        public int[] TimTatCaCacSoNguyenTo(ref int lengthkq)
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

        public int[] TimPhanTuXuatHienNhieuNhat(ref int lengthkq)
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

        public int[] TimPhanTuXuatHienItNhat(ref int lengthkq)
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

        public int[] TimTatCaPhanTuLonHon(ref int lengthkq, int x)
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

        public int[] TimTatCaPhanTuNhoHon(ref int lengthkq, int x)
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

        public int[] TimTatCaPhanTuViTri(ref int lengthkq, int vt, int soLuong)
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

        public bool ThemPhanTuTaiViTri(int x, int vt)
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

        public bool ThemPhanTuDauDanhSach(int x)
        {
            return ThemPhanTuTaiViTri(x, 0);
        }

        public bool ThemPhanTuCuoiDanhSach(int x)
        {
            return ThemPhanTuTaiViTri(x, length);
        }

        public bool ThemMotMangVaoDanhSachTaiViTri(int[] b, int lengthb, int vt)
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

        public bool ThemMotMangVaoDauDanhSach(int[] b, int lengthb)
        {
            return ThemMotMangVaoDanhSachTaiViTri(b, lengthb, 0);
        }

        public bool ThemMotMangVaoCuoiDanhSach(int[] b, int lengthb)
        {
            return ThemMotMangVaoDanhSachTaiViTri(b, lengthb, length);
        }

        public bool XoaPhanTuDau(int vt)
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

        public bool XoaPhanTuCuoi(int vt)
        {
            if (vt < 0 || vt >= length)
                return false;
            length--;
            return true;
        }

        public bool XoaPhanTuCoTrongMang(int[] b, int lengthb)
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

        public bool XoaTatCaPhanTu()
        {
            length = 0;
            return true;
        }

        public bool XoaTatCaSoAm()
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

        public bool XoaTatCaSoDuong()
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

        public bool XoaTatCaSoChan()
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

        public bool XoaTatCaSoLe()
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

        public bool XoaTatCaSoNguyenTo()
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

        public bool XoaTatCaPhanTuTrungNhau()
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

        public bool XoaPhanTuXuatHienNhieuNhat()
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

        public bool XoaPhanTuXuatHienItNhat()
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

        public bool ThayThePhanTu(int cu, int moi)
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

        public int DemSoLanXuatHienCuaPhanTu(int x)
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

        public int DemSoDuong()
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

        public int DemSoAm()
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

        public int DemSoNguyenTo()
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

        public int DemSoChan()
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

        public int DemSoLe()
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

        public void SapXepTang()
        {
            a.Sort();
        }

        public void SapXepGiam()
        {
            a.Sort();
            a.Reverse();
        }

        public void DaoNguocMang()
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
