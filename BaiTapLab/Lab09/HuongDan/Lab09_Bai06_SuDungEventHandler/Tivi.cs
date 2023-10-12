using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai06_SuDungEventHandler
{
    public class Tivi
    {
        public Tivi(CongTac c)
        {
            c.BatTat += XemTrangThai;
        }

        private void XemTrangThai(object sender, EventArgs e)
        {
            StatusEventArgs sea = (StatusEventArgs)e;

            if (sea.TrangThai)
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
