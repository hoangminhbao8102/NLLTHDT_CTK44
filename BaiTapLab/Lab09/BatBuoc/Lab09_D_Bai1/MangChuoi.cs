using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai1
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

        public bool KiemTraTrung(string chuoi)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] == chuoi)
                {
                    return true;
                }
            }
            return false;
        }

        public void Them(string chuoi) 
        {
            if (!KiemTraTrung(chuoi))
            {
                danhSach[soLuong] = chuoi;
                soLuong++;
            }
        }

        public override string ToString() 
        {
            return string.Join(", ", danhSach, 0, soLuong);
        }
    }
}
