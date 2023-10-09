using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai05_QuanLyHinhHoc
{
    public interface ISoSanhHinhHoc
    {
        int SoSanh(IHinhHoc truoc, IHinhHoc sau);
    }
}
