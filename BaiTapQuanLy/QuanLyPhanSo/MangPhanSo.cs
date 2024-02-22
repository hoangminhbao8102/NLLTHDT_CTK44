using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MangPhanSo
    {
        public PhanSo[] a = new PhanSo[100];
        public int length = 0;
        public void Nhap()
        {
            Console.Write("Nhap vao chieu dai mang ");
            length = int.Parse(Console.ReadLine());
            for (int i = 0; i < length; i++)
            {
                a[i] = new PhanSo();
                a[i].Nhap();
            }
        }
        public void Xuat()
        {
            for (int i = 0; i < length; i++)
            {
                a[i].Xuat();
            }
        }
        public void Them(PhanSo x)
        {
            a[length] = x;
            length++;
        }
        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string s = "";
            while ((s = sr.ReadLine()) != null) 
            {
                string[] tam = s.Split('/');
                int tu = int.Parse(tam[0]);
                int mau = int.Parse(tam[1]);
                Them(new PhanSo(tu, mau));
            }
        }
        public void NhapNgauNhien()
        {
            Console.Write("Nhap vao chieu dai mang ");
            length = int.Parse(Console.ReadLine());
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                a[i] = new PhanSo(r.Next(10), r.Next(10));
            }
        }
        public PhanSo TimMax()
        {
            PhanSo max = new PhanSo(int.MinValue, 1);
            for (int i = 0; i < length; i++)
            {
                float x = a[i].tu / a[i].mau;
                float y = max.tu / max.mau;
                if (x > y) 
                {
                    max = a[i];
                }
            }
            return max;
        }
        public MangPhanSo TimPhanSoCoMauLa(int x)
        {
            MangPhanSo kq = new MangPhanSo();
            for (int i = 0; i < length; i++)
            {
                if (a[i].mau == x) 
                {
                    kq.Them(a[i]);
                }
            }
            return kq;
        }
        //1. Đếm số phân số âm trong mảng
        public int DemPhanSoAm()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0)
                {
                    count++;
                }
            }
            return count;
        }
        //2. Đếm số phân số dương trong mảng
        public int DemPhanSoDuong()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu > 0)
                {
                    count++;
                }
            }
            return count;
        }
        //3. Đếm phân số có tử là x trong mảng
        public int DemPhanSoCoTuLa(int x)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == x)
                {
                    count++;
                }
            }
            return count;
        }
        //4. Đếm phân số có mẫu là x trong mảng
        public int DemPhanSoCoMauLa(int x)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].mau == x)
                {
                    count++;
                }
            }
            return count;
        }
        //5. Tìm phân số âm lớn nhất
        public PhanSo TimPhanSoAmLonNhat()
        {
            PhanSo max = null;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0 && (max == null || a[i].tu > max.tu))
                {
                    max = a[i];
                }
            }
            return max;
        }
        //6. Tìm phân số âm nhỏ nhất
        public PhanSo TimPhanSoAmNhoNhat()
        {
            PhanSo min = null;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0 && (min == null || a[i].tu < min.tu))
                {
                    min = a[i];
                }
            }
            return min;
        }
        //7. Tìm phân số dương lớn nhất
        public PhanSo TimPhanSoDuongLonNhat()
        {
            PhanSo max = null;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu > 0 && (max == null || a[i].tu > max.tu))
                {
                    max = a[i];
                }
            }
            return max;
        }
        //8. Tìm phân số dương nhỏ nhất
        public PhanSo TimPhanSoDuongNhoNhat()
        {
            PhanSo min = null;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu > 0 && (min == null || a[i].tu < min.tu))
                {
                    min = a[i];
                }
            }
            return min;
        }
        //9. Tìm tất cả các phân số âm trong mảng
        public MangPhanSo TimTatCaPhanSoAm()
        {
            MangPhanSo kq = new MangPhanSo();
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0)
                {
                    kq.Them(a[i]);
                }
            }
            return kq;
        }
        //10.Tìm tất cả các phân số dương trong mảng
        public MangPhanSo TimTatCaPhanSoDuong()
        {
            MangPhanSo kq = new MangPhanSo();
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu > 0)
                {
                    kq.Them(a[i]);
                }
            }
            return kq;
        }
        //11.Tìm tất cả vị trí của phân số x trong mảng
        public int[] TimViTriCuaPhanSo(int x)
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == x)
                {
                    count++;
                }
            }
            int[] positions = new int[count];
            count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == x)
                {
                    positions[count] = i;
                    count++;
                }
            }
            return positions;
        }
        //12.Tìm tất cả vị trí của phân số âm, dương trong mảng
        public int[] TimViTriCuaPhanSoAmDuong()
        {
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0 || a[i].tu > 0)
                {
                    count++;
                }
            }
            int[] positions = new int[count];
            count = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0 || a[i].tu > 0)
                {
                    positions[count] = i;
                    count++;
                }
            }
            return positions;
        }
        //13.Tổng tất cả các phân số âm trong mảng
        public int TinhTongTatCaPhanSoAm()
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0)
                {
                    sum += a[i].tu;
                }
            }
            return sum;
        }
        //14.Tổng các phân số dương trong mảng
        public int TinhTongTatCaPhanSoDuong()
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu > 0)
                {
                    sum += a[i].tu;
                }
            }
            return sum;
        }
        //15.Tổng tất cả phân số có tử là x
        public int TinhTongTatCaPhanSoCoTuLa(int x)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == x)
                {
                    sum += a[i].tu;
                }
            }
            return sum;
        }
        //16.Tổng tất cả phân số có mẫu là x
        public int TinhTongTatCaPhanSoCoMauLa(int x)
        {
            int sum = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].mau == x)
                {
                    sum += a[i].tu;
                }
            }
            return sum;
        }
        //17.Xóa một phân số tại vị trí vt trong mảng
        public void XoaPhanSoTaiViTri(int vt)
        {
            if (vt >= 0 && vt < length)
            {
                for (int i = vt; i < length - 1; i++)
                {
                    a[i] = a[i + 1];
                }
                length--;
            }
        }
        //18.Xóa phân số đầu tiên trong mảng
        public void XoaPhanSoDauTien()
        {
            XoaPhanSoTaiViTri(0);
        }
        //19.Xóa phân số cuối cùng trong mảng
        public void XoaPhanSoCuoiCung()
        {
            XoaPhanSoTaiViTri(length - 1);
        }
        //20.Xóa phân số x trong mảng
        public void XoaPhanSoX(int tuX, int mauX)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == tuX && a[i].mau == mauX)
                {
                    XoaPhanSoTaiViTri(i);
                    i--;
                }
            }
        }
        //21.Xóa tất cả phân số có tử là x
        public void XoaPhanSoCoTuLa(int x)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu == x)
                {
                    XoaPhanSoTaiViTri(i);
                    i--;
                }
            }
        }
        //22.Xóa tất cả phân số có mẫu là x
        public void XoaPhanSoCoMauLa(int x)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].mau == x)
                {
                    XoaPhanSoTaiViTri(i);
                    i--;
                }
            }
        }
        //23.Xóa tất cả phân số có giá trị giống phân số đầu tiên trong mảng.
        public void XoaPhanSoGiongPhanSoDauTien()
        {
            if (length > 0)
            {
                int tuDau = a[0].tu;
                int mauDau = a[0].mau;
                for (int i = 1; i < length; i++)
                {
                    if (a[i].tu == tuDau && a[i].mau == mauDau)
                    {
                        XoaPhanSoTaiViTri(i);
                        i--;
                    }
                }
            }
        }
        //24.Xóa tất cả phân số có giá trị giống phân số cuối cùng trong mảng.
        public void XoaPhanSoGiongPhanSoCuoiCung()
        {
            if (length > 0)
            {
                int tuCuoi = a[length - 1].tu;
                int mauCuoi = a[length - 1].mau;
                for (int i = length - 2; i >= 0; i--)
                {
                    if (a[i].tu == tuCuoi && a[i].mau == mauCuoi)
                    {
                        XoaPhanSoTaiViTri(i);
                    }
                }
            }
        }
        //25.Xóa tất cả các phân số nhỏ nhất 
        public void XoaTatCaPhanSoNhoNhat()
        {
            PhanSo min = TimPhanSoAmNhoNhat();
            if (min == null)
            {
                min = TimPhanSoDuongNhoNhat();
            }
            if (min != null)
            {
                for (int i = 0; i < length; i++)
                {
                    if (a[i].tu == min.tu && a[i].mau == min.mau)
                    {
                        XoaPhanSoTaiViTri(i);
                        i--;
                    }
                }
            }
        }
        //26.Xóa các phần tử tại các vị trí(vị trí được lưu trong mảng)
        public void XoaTaiCacViTri(int[] viTri)
        {
            Array.Sort(viTri);
            int shift = 0;
            foreach (int vt in viTri)
            {
                XoaPhanSoTaiViTri(vt - shift);
                shift++;
            }
        }
        //27.Thêm một phân số tại vị trí vt trong mảng
        public void ThemPhanSoTaiViTri(PhanSo x, int vt)
        {
            if (vt >= 0 && vt <= length)
            {
                for (int i = length; i > vt; i--)
                {
                    a[i] = a[i - 1];
                }
                a[vt] = x;
                length++;
            }
        }
        //28.Thêm phân số đầu tiên trong mảng
        public void ThemPhanSoDauTien(PhanSo x)
        {
            ThemPhanSoTaiViTri(x, 0);
        }
        //29.Xóa tất cả phân số âm trong mảng
        public void XoaTatCaPhanSoAm()
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu < 0)
                {
                    XoaPhanSoTaiViTri(i);
                    i--;
                }
            }
        }
        //30.Xóa tất cả phân số dương trong mảng
        public void XoaTatCaPhanSoDuong()
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].tu > 0)
                {
                    XoaPhanSoTaiViTri(i);
                    i--;
                }
            }
        }
        //31. Sắp xếp phân số theo chiều tăng, giảm, tăng theo mẫu, tử, giảm theo mẫu tử
        public void SapXepTang()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    float x = (float)a[i].tu / a[i].mau;
                    float y = (float)a[j].tu / a[j].mau;
                    if (x > y)
                    {
                        PhanSo temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public void SapXepGiam()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    float x = (float)a[i].tu / a[i].mau;
                    float y = (float)a[j].tu / a[j].mau;
                    if (x < y)
                    {
                        PhanSo temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public void SapXepTangTheoTu()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (a[i].tu > a[j].tu)
                    {
                        PhanSo temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public void SapXepGiamTheoTu()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (a[i].tu < a[j].tu)
                    {
                        PhanSo temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public void SapXepTangTheoMau()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (a[i].mau > a[j].mau)
                    {
                        PhanSo temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }

        public void SapXepGiamTheoMau()
        {
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (a[i].mau < a[j].mau)
                    {
                        PhanSo temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
        }
    }
}
