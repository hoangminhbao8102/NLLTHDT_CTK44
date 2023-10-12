using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai04_SuKienPhucTap
{
    public delegate void XuLyCongTac(object sender, EventArgs e);

    public class CongTac
    {
        public event XuLyCongTac BatTat;

        private bool trangThai = false;

        public bool TrangThai
        {
            get { return trangThai; }
        }

        public void NhanCongTac()
        {
            trangThai = !trangThai;

            PhatSinhSuKienBatTat();
        }

        protected virtual void PhatSinhSuKienBatTat()
        {
            if (BatTat!=null)
            {
                EventArgs ea = new EventArgs();

                BatTat(this, ea);
            }
        }
    }
}
