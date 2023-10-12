using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai04_SuKienPhucTap
{
    public class Tivi
    {
        public void ChuyenTrangThai(bool trangThai)
        {
            if (trangThai)
            {
                Console.WriteLine("Tivi dang bat");
            }
            else
            {
                Console.WriteLine("Tivi da tat");
            }
        }
    }
}
