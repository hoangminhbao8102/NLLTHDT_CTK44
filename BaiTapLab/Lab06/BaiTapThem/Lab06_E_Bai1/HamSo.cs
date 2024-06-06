using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai1
{
    abstract class HamSo
    {
        private string ten;

        public string Ten
        { 
            get { return ten; } 
        }

        protected HamSo(string ten)
        {
            this.ten = ten;
        }

        public abstract double TinhGiaTri(double x);
        public abstract void Xuat();
    }
}
