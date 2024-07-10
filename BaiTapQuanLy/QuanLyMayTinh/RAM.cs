using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class RAM : CPU
    {
        public RAM() { }

        public RAM(string line) : base(line) { }

        public override string ToString()
        {
            return "RAM hãng " + HangSX + " giá = " + Gia;
        }
    }
}
