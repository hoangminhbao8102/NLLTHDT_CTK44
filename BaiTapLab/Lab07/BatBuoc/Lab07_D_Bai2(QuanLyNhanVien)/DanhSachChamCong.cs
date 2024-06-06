using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class DanhSachChamCong
    {
        private ChamCong[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public ChamCong this[int index]
        {
            get { return danhSach[index]; }
        }

        public DanhSachChamCong()
        {
            danhSach = new ChamCong[10]; // Gán một kích thước ban đầu cho mảng, ví dụ là 10
            soLuong = 0; // Ban đầu không có phần tử nào trong danh sách
        }

        public void Them(ChamCong cc)
        {
            if (soLuong == danhSach.Length) // Kiểm tra xem mảng đã đầy chưa
            {
                // Nếu mảng đã đầy, tăng kích thước mảng
                Array.Resize(ref danhSach, danhSach.Length * 2);
            }
            danhSach[soLuong++] = cc; // Thêm ChamCong vào mảng và tăng số lượng
        }

        public ChamCong TimTheoThang(int thang)
        {
            for (int i = 0; i < soLuong; i++) // Duyệt qua mảng
            {
                if (danhSach[i].Thang == thang) // Kiểm tra tháng
                {
                    return danhSach[i]; // Trả về đối tượng ChamCong nếu tìm thấy
                }
            }
            return null; // Trả về null nếu không tìm thấy
        }
    }
}
