using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai05_QuanLyHinhHoc
{
    public class SoSanhTheoDienTich : ISoSanhHinhHoc
    {
        public int SoSanh(IHinhHoc truoc, IHinhHoc sau)
        {
            double x = truoc.TinhDienTich();
            double y = sau.TinhDienTich();

            return x.CompareTo(y);
        }
    }
}
