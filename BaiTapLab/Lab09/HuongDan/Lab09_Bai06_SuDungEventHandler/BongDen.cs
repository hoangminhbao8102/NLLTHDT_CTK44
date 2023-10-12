using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai06_SuDungEventHandler
{
    public class BongDen
    {
        public BongDen(CongTac c)
        {
            c.BatTat += XemTrangThai;
        }

        private void XemTrangThai(object sender, EventArgs e)
        {
            StatusEventArgs sea = (StatusEventArgs)e;

            if (sea.TrangThai)
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
