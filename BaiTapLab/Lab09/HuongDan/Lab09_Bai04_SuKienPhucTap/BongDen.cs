using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai04_SuKienPhucTap
{
    public class BongDen
    {
        public void ChuyenTrangThai(bool trangThai)
        {
            if (trangThai)
            {
                Console.WriteLine("Bong den dang sang");
            }
            else
            {
                Console.WriteLine("Bong den da tat");
            }
        }
    }
}
