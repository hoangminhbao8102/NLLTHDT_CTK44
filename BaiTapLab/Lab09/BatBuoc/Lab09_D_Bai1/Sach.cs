using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai1
{
    public class Sach
    {
        private string _tuaDe;
        private string _tacGia;
        private int _soTrang;
        private decimal _gia;

        public int SoTrang
        {
            get { return _soTrang; }
            set { _soTrang = value; }
        }
        public string TuaDe
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }
        public string TacGia
        {
            get { return _tacGia; }
            set { _tacGia = value; }
        }
        public decimal GiaBan
        {
            get { return _gia; }
            set { _gia = value; }
        }

        public Sach() 
        {
            _tuaDe = string.Empty;
            _tacGia = string.Empty;
            _soTrang = 0;
            _gia = 0.0m;
        }

        public Sach(string tuaDe, string tacGia, int soTrang, decimal gia)
        {
            _tuaDe = tuaDe;
            _tacGia = tacGia;
            _soTrang = soTrang;
            _gia = gia;
        }
    }
}
