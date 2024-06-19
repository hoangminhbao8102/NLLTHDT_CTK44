using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai4
{
    public class PhanVung : IEntry
    {
        private string _ten;
        private char _letter;
        private int _soLuong;
        private IEntry[] _tepVaTMuc;

        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }

        public char Letter
        {
            get { return _letter; }
            set { _letter = value; }
        }

        public PhanVung(string ten, char letter)
        {
            _ten = ten;
            _letter = letter;
            _tepVaTMuc = new IEntry[10];  // Initial size of 10, can be adjusted as needed
            _soLuong = 0;
        }

        public void HienThiNoiDung()
        {
            Console.WriteLine($"Partition: {_letter} - {_ten}");
            for (int i = 0; i < _soLuong; i++)
            {
                if (_tepVaTMuc[i] != null)
                    _tepVaTMuc[i].HienThiNoiDung();
            }
        }

        public double TinhDungLuong()
        {
            double totalSize = 0;
            for (int i = 0; i < _soLuong; i++)
            {
                if (_tepVaTMuc[i] != null)
                    totalSize += _tepVaTMuc[i].TinhDungLuong();
            }
            return totalSize;
        }

        public void Them(IEntry entry)
        {
            if (_soLuong >= _tepVaTMuc.Length)
            {
                IEntry[] newTepVaTMuc = new IEntry[_soLuong + 10];
                _tepVaTMuc.CopyTo(newTepVaTMuc, 0);
                _tepVaTMuc = newTepVaTMuc;
            }
            _tepVaTMuc[_soLuong++] = entry;
        }
    }
}
