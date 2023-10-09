using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai04_KeThuaGiaoDien
{
    public interface IBienDoi : IHinhHoc
    {
        void ThuPhong(double tyLe);

        void TinhTien(double dx, double dy);
    }
}
