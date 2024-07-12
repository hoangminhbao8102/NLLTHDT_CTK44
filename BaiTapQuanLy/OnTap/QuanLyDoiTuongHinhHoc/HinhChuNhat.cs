using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    public class HinhChuNhat : HinhHoc
    {
        private float _chieuDai;
        private float _chieuRong;

        public float ChieuDai
        {
            get { return _chieuDai; }
            set { _chieuDai = value >= 0 ? value : throw new ArgumentException("Chiều dài phải lớn hơn hoặc bằng 0"); }
        }

        public float ChieuRong
        {
            get { return _chieuRong; }
            set { _chieuRong = value >= 0 ? value : throw new ArgumentException("Chiều rộng phải lớn hơn hoặc bằng 0"); }
        }

        public HinhChuNhat(float dai, float rong, string mauSac = "Trắng") : base(mauSac)
        {
            ChieuDai = dai;
            ChieuRong = rong;
        }

        public override float TinhDT()
        {
            return ChieuDai * ChieuRong;
        }

        public override float TinhCV()
        {
            return 2 * (ChieuDai + ChieuRong);
        }

        public override string ToString()
        {
            return $"Hình chữ nhật chiều dài {ChieuDai}, chiều rộng {ChieuRong}, màu sắc {MauSac}, diện tích {TinhDT():N2}, chu vi {TinhCV():N2}";
        }
    }
}
