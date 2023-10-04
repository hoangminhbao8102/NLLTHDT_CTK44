using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public class DanhSachTaiLieu
    {
        private TaiLieu[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; } 
        }

        public TaiLieu this[int index] 
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }

        public DanhSachTaiLieu()
        {
            danhSach = new TaiLieu[100];
            soLuong = 0;
        }

        public void Them(TaiLieu taiLieu)
        {
            danhSach[soLuong] = taiLieu;
            soLuong++;
        }

        public int TimViTriTaiLieu(string maSoTL)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == maSoTL)
                {
                    return i;
                }
            }
            return -1;
        }

        public int TimViTriTaiLieu(TaiLieu taiLieu)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] == taiLieu)
                {
                    return i;
                }
            }
            return -1;
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
