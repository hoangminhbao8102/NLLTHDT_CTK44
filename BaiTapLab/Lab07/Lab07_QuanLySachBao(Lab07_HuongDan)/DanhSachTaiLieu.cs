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

        }

        public int TimViTriTaiLieu(string maSoTL)
        {
            return soLuong;
        }

        public int TimViTriTaiLieu(TaiLieu taiLieu)
        {
            return soLuong;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
