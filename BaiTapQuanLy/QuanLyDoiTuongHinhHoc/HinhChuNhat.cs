using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class HinhChuNhat : HinhHoc
    {
        public float chieuDai;
        public float chieuRong;

        public HinhChuNhat() { }

        public HinhChuNhat(float dai, float rong)
        {
            chieuDai = dai;
            chieuRong = rong;
        }

        public override float TinhDT()
        {
            return (float)Math.Round(chieuDai * chieuRong, 0);
        }

        public override float TinhCV()
        {
            return (float)Math.Round(2 * (chieuDai + chieuRong), 0);
        }

        public override string ToString()
        {
            return "Hình chữ nhật chiều dài " + chieuDai + ", chiều rộng " + chieuRong +
                   ", diện tích " + TinhDT() + ", chu vi " + TinhCV();
        }
    }
}
