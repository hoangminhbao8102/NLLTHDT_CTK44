using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class HinhVuong : HinhHoc
    {
        public float canh;
        public HinhVuong() { }
        public HinhVuong(float c)
        {
            canh = c;
        }
        public override float TinhDT()
        {
            return (float)Math.Round(canh * canh, 0);
        }
        public override float TinhCV()
        {
            return (float)Math.Round(canh * 4, 0);
        }
        public override string ToString()
        {
            return "Hình vuông cạnh " + canh + " diện tích " + TinhDT() + " chu vi " + TinhCV();
        }
    }
}
