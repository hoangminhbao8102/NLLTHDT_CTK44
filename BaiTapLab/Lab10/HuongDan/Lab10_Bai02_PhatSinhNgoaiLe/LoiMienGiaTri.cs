using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai02_PhatSinhNgoaiLe
{
    public class LoiMienGiaTri : Exception
    {
        public LoiMienGiaTri() : base("Gia tri khong hop le")
        {
        }

        public LoiMienGiaTri(string message) : base(message)
        {
        }
    }
}
