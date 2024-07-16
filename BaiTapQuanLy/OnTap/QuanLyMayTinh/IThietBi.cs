using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public interface IThietBi
    {
        float Gia { get; set; }
        string HangSX { get; set; }
        string Model { get; set; }
        int NamSanXuat { get; set; }
    }
}
