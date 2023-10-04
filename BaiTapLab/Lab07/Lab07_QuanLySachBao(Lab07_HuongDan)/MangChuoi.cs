using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public class MangChuoi
    {
        private string[] danhSach;
        private int soLuong;

        public int SoLuong
        { 
            get { return soLuong; } 
        }

        public string this[int index]
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }

        public bool ChuaChuoi(string giaTri)
        {
            return true;
        }

        public static implicit operator MangChuoi(string[] cacChuoi)
        {
            return new MangChuoi();
        }

        public MangChuoi() 
        {
            danhSach = new string[100];
            soLuong = 0;
        }

        public MangChuoi(string[] cacChuoi)
        {
            danhSach = cacChuoi;
            soLuong = 0;
        }

        public void Them(string chuoi)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
