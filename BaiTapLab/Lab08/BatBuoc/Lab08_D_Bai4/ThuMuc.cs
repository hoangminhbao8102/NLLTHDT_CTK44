using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai4
{
    public class ThuMuc : IEntry
    {
        private string _ten;
        private IEntry[] _tepVaTMuc;
        private int _soLuong;
        private IEntry _cha;

        public IEntry Cha 
        { 
            get { return _cha; } 
            set { _cha = value; }
        }
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public ThuMuc()
        {
            _tepVaTMuc = new IEntry[10]; // Initialize the array with a fixed size
            _soLuong = 0;  // Start with zero entries
        }

        // Constructor to initialize directory name
        public ThuMuc(string ten)
        {
            Ten = ten;
        }

        public void Them(IEntry entry)
        {
            if (_soLuong >= _tepVaTMuc.Length)
            {
                // Increase array size when needed
                int newSize = _soLuong + 10; // Increase by 10, for example
                IEntry[] newTepVaTMuc = new IEntry[newSize];
                _tepVaTMuc.CopyTo(newTepVaTMuc, 0);
                _tepVaTMuc = newTepVaTMuc;
            }
            _tepVaTMuc[_soLuong] = entry;
            _soLuong++;
        }

        public void HienThiNoiDung()
        {
            Console.WriteLine($"Directory: {_ten}");
            foreach (var entry in _tepVaTMuc)
            {
                entry.HienThiNoiDung();
            }
        }

        public double TinhDungLuong()
        {
            double totalSize = 0;
            foreach (var entry in _tepVaTMuc)
            {
                totalSize += entry.TinhDungLuong();
            }
            return totalSize;
        }
    }
}
