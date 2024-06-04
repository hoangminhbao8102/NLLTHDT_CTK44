using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai2
{
    public class NgayThang
    {
        private int _ngay;
        private int _thang;
        private int _nam;

        public int Ngay 
        {
            get { return _ngay; }
            set { _ngay = value; }
        }
        public int Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }
        public int Nam 
        { 
            get { return (_nam == 0) ? 0 : _nam; }
            set { _nam = value; }
        }

        public NgayThang()
        {
            _ngay = 0;
            _thang = 0;
            _nam = 0;
        }

        public NgayThang(int ngay, int thang, int nam)
        {
            _ngay = ngay;
            _thang = thang;
            _nam = nam;
        }

        public override string ToString()
        {
            return $"{_ngay}/{_thang}/{_nam}";
        }
    }
}
