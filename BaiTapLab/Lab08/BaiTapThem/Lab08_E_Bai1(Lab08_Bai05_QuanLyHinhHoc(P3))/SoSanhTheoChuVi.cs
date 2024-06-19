using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai1_Lab08_Bai05_QuanLyHinhHoc_P3__
{
    public class SoSanhTheoChuVi : ISoSanhHinhHoc
    {
        public int SoSanh(IHinhHoc truoc, IHinhHoc sau)
        {
            return truoc.TinhChuVi().CompareTo(sau.TinhChuVi());
        }
    }
}
