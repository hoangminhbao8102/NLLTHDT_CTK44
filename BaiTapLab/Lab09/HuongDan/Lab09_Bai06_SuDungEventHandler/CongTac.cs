using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai06_SuDungEventHandler
{
    public class CongTac
    {
        public event EventHandler BatTat;

        private bool trangThai = false;

        public void NhanCongTac()
        {
            trangThai = !trangThai;

            PhatSinhSuKienBatTat();
        }

        protected virtual void PhatSinhSuKienBatTat()
        {
            if (BatTat != null) 
            {
                EventArgs ea = new EventArgs();

                BatTat(this, ea);
            }
        }
    }
}
