using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
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
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] == giaTri)
                {
                    return true;
                }
            }
            return false;
        }

        public static implicit operator MangChuoi(string[] cacChuoi)
        {
            MangChuoi mang = new MangChuoi(cacChuoi);
            for (int i = 0; i < cacChuoi.Length; i++)
            {
                mang[i] = cacChuoi[i];
            }
            return mang;
        }

        public MangChuoi()
        {
            danhSach = new string[100];
            soLuong = 0;
        }

        public MangChuoi(string[] cacChuoi)
        {
            danhSach = new string[cacChuoi.Length];
            soLuong = cacChuoi.Length;
            for (int i = 0; i < cacChuoi.Length; i++)
            {
                danhSach[i] = cacChuoi[i];
            }
        }

        public void Them(string chuoi)
        {
            Array.Resize(ref danhSach, soLuong + 1);
            danhSach[soLuong] = chuoi;
            soLuong++;
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < soLuong; i++)
            {
                result += danhSach[i] + " ";
            }
            return result.Trim();
        }
    }
}
