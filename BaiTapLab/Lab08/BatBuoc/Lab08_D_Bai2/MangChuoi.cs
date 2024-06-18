using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai2
{
    class MangChuoi
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

        public MangChuoi()
        {
            danhSach = new string[10];
            soLuong = 0;
        }

        public MangChuoi(string[] duLieu)
        {
            danhSach = new string[duLieu.Length];
            for (int i = 0; i < duLieu.Length; i++)
            {
                danhSach[i] = duLieu[i];
            }
            soLuong = duLieu.Length;
        }

        public bool Them(string chuoi)
        {
            if (soLuong >= danhSach.Length)
            {
                try
                {
                    Array.Resize(ref danhSach, danhSach.Length * 2);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            danhSach[soLuong++] = chuoi;
            return true;
        }

        public override string ToString() 
        {
            return string.Join(", ", danhSach.Take(soLuong));
        }
    }
}
