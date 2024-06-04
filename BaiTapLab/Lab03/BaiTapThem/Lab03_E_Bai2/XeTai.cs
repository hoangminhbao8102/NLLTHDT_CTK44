using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai2
{
    public class XeTai
    {
        public string _bienSo;
        public string _hangSx;
        public int _namSx;
        public NgayThang _ngayDk;
        public float _tocDoToiDa;
        public float _trongTai;

        public XeTai() 
        {
            _bienSo = string.Empty;
            _hangSx = string.Empty;
            _namSx = 0;
            _ngayDk = new NgayThang();
            _tocDoToiDa = 0;
            _trongTai = 0;
        }

        public int TinhSoNamHoatDong()
        {
            return DateTime.Now.Year - _namSx;
        }

        public int TinhTuoiTho(float giaToc)
        {
            return (int)(_trongTai / giaToc);
        }
    }
}
