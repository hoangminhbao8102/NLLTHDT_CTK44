using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai06_SuDungEventHandler
{
    public class StatusEventArgs : EventArgs
    {
        private bool trangThai = false;

        public bool TrangThai
        { 
            get { return trangThai; }
        }

        public StatusEventArgs(bool trangThai)
        {
            this.trangThai = trangThai;
        }
    }
}
