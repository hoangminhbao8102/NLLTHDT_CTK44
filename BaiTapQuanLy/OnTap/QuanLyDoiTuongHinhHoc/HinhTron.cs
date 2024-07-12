using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    public class HinhTron : HinhHoc
    {
        private float _banKinh;

        public float BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value >= 0 ? value : throw new ArgumentException("Bán kính phải lớn hơn hoặc bằng 0"); }
        }

        // Thêm một tham số cho màu sắc và truyền nó cho constructor của lớp cha
        public HinhTron(float banKinh = 1.0f, string mauSac = "Trắng") : base(mauSac) // Giá trị mặc định cho màu sắc là Trắng
        {
            BanKinh = banKinh;
        }

        public override float TinhDT()
        {
            return (float)(Math.PI * BanKinh * BanKinh);
        }

        public override float TinhCV()
        {
            return (float)(2 * Math.PI * BanKinh);
        }

        public override string ToString()
        {
            return $"Hình tròn bán kính {BanKinh}, màu sắc {MauSac}, diện tích {TinhDT():N2}, chu vi {TinhCV():N2}";
        }
    }
}
