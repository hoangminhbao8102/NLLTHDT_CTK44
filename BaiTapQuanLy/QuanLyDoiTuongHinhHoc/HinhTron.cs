using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class HinhTron : HinhHoc
    {
        public float banKinh;
        public HinhTron() { }
        public HinhTron(float r)
        {
            banKinh = r;
        }
        public override float TinhDT()
        {
            return (float)Math.Round(Math.PI * banKinh * banKinh, 0);
        }
        public override float TinhCV()
        {
            return (float)Math.Round(2 * Math.PI * banKinh, 0);
        }
        public override string ToString()
        {
            return "Hình tròn bán kính " + banKinh + " diện tích " + TinhDT() + " chu vi " + TinhCV();
        }
    }
}
