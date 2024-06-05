using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_E_Bai1
{
    public class HamSo
    {
        private string _ten;

        public string Ten
        {
            get { return _ten; }
        }

        protected HamSo(string ten)
        {
            _ten = ten;
        }

        public virtual double TinhGiaTri(double x)
        {
            return 0;
        }

        public virtual void Xuat()
        {
            // This method will be overridden in derived classes.
        }
    }
}
