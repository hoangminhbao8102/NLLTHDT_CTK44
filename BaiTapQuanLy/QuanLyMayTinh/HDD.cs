using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class HDD : CPU
    {
        public HDD() { }

        public HDD(string line) : base(line) { }

        public override string ToString()
        {
            return "HDD hãng " + HangSX + " giá = " + Gia;
        }
    }
}
