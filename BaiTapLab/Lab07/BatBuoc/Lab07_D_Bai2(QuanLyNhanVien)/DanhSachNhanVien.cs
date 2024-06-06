using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class DanhSachNhanVien
    {
        private NhanVien[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public NhanVien this[int index]
        {
            get { return danhSach[index]; }
        }

        public DanhSachNhanVien()
        {
            danhSach = new NhanVien[10]; // Giả sử bắt đầu với kích thước mảng là 10
            soLuong = 0;
        }

        public void Them(NhanVien nv)
        {
            if (soLuong == danhSach.Length)
            {
                // Mở rộng mảng nếu cần
                Array.Resize(ref danhSach, soLuong * 2);
            }
            danhSach[soLuong++] = nv;
        }

        public NhanVien TimTheoMa(int maNV)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == maNV)
                {
                    return danhSach[i];
                }
            }
            return null; // Trả về null nếu không tìm thấy
        }

        public int TimViTri(int maNV)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == maNV)
                {
                    return i;
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy
        }

        public void Xuat()
        {
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine(danhSach[i].ToString()); // Gọi phương thức ToString() đã được ghi đè
            }
        }
    }
}
