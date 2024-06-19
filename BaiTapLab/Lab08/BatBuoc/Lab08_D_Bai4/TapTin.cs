using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai4
{
    public class TapTin : IEntry
    {
        private double _dungLuong;
        private string _ten;
        private string _noiDung;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public TapTin(string ten, double dluong, string noiDung)
        {
            _ten = ten;
            _dungLuong = dluong;
            _noiDung = noiDung;
        }

        public void HienThiNoiDung()
        {
            Console.WriteLine($"File: {_ten}");
            Console.WriteLine($"Size: {_dungLuong} bytes");
            Console.WriteLine("Content:");
            Console.WriteLine(_noiDung);
        }

        public double TinhDungLuong()
        {
            return _dungLuong;
        }
    }
}
