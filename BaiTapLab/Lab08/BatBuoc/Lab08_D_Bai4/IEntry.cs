using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai4
{
    public interface IEntry
    {
        string Ten { get; set; }

        double TinhDungLuong();
        void HienThiNoiDung();
    }
}
