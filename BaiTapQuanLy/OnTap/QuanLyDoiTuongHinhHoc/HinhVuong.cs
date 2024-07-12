using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    public class HinhVuong : HinhHoc
    {
        private float _canh;

        public float Canh
        {
            get { return _canh; }
            set { _canh = value >= 0 ? value : throw new ArgumentException("Cạnh phải lớn hơn hoặc bằng 0"); }
        }

        public HinhVuong(float canh = 1.0f, string mauSac = "Trắng") : base(mauSac)
        {
            Canh = canh;
        }

        public override float TinhDT()
        {
            return Canh * Canh;
        }

        public override float TinhCV()
        {
            return Canh * 4;
        }

        public override string ToString()
        {
            return $"Hình vuông cạnh {Canh}, màu sắc {MauSac}, diện tích {TinhDT():N2}, chu vi {TinhCV():N2}";
        }
    }
}
