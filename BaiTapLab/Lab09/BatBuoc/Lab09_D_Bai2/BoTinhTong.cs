using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai2
{
    public class BoTinhTong
    {
        private double _tong;
        private int _demSo;

        public int SoLuong
        {
            get { return _demSo; }
        }
        public double TongCong
        { 
            get { return _tong; } 
        }

        public BoTinhTong()
        {
            // Khởi tạo giá trị ban đầu
            _tong = 0.0;
            _demSo = 0;
        }

        public void CongThem(string chuoiSo)
        {
            // Kiểm tra và cộng giá trị số vào tổng
            if (double.TryParse(chuoiSo, out double so))
            {
                _tong += so;
                _demSo++;  // Tăng đếm số lượng số hợp lệ
            }
        }
    }
}
