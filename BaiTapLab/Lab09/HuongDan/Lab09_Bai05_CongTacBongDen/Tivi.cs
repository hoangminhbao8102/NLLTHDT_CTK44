using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai05_CongTacBongDen
{
    public class Tivi
    {
        public Tivi(CongTac c)
        {
            c.BatTat += ChuyenTrangThai;
        }

        private void ChuyenTrangThai(object sender, EventArgs e) 
        {
            CongTac cauDao = sender as CongTac;

            if (cauDao.TrangThai) 
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
