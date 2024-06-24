using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai3
{
    public class DanhSachDocGia
    {
        private int soLuong;
        private DocGia[] danhSach;

        public int SoLuong
        { 
            get { return soLuong; } 
        }
        public DocGia this[int index] 
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }

        public DanhSachDocGia()
        {
            danhSach = new DocGia[10];
            soLuong = 0;
        }

        public void Them(DocGia dg)
        {
            if (soLuong == danhSach.Length)
            {
                // Mở rộng mảng khi không còn chỗ trống
                DocGia[] temp = new DocGia[danhSach.Length * 2];
                danhSach.CopyTo(temp, 0);
                danhSach = temp;
            }

            // Kiểm tra độc giả đã có trong danh sách chưa
            bool alreadyExists = false;
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == dg.MaSo)
                {
                    alreadyExists = true;
                    break;
                }
            }

            if (!alreadyExists)
            {
                danhSach[soLuong++] = dg;
            }
        }

        public int TimTheoMa(int maSo)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == maSo)
                    return i;
            }
            return -1;
        }

        public void Xoa(int maSo)
        {
            int index = TimTheoMa(maSo);
            if (index != -1)
            {
                for (int i = index; i < soLuong - 1; i++)
                {
                    danhSach[i] = danhSach[i + 1];
                }
                danhSach[--soLuong] = null;
            }
        }

        public void Xoa(DocGia dg) 
        {
            Xoa(dg.MaSo);
        }

        public override string ToString() 
        {
            var result = new StringBuilder();
            for (int i = 0; i < soLuong; i++)
            {
                result.AppendLine(danhSach[i].ToString());
            }
            return result.ToString();
        }
    }
}
