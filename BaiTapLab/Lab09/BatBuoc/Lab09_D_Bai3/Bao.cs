using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai3
{
    public class Bao
    {
        private int _giaBan;
        private DateTime _ngayPhatHanh;
        private string _noiDung;
        private int _so;

        public int GiaBan
        {
            get { return _giaBan; }
            set { _giaBan = value; }
        }
        public DateTime NgayPhatHanh
        {
            get { return _ngayPhatHanh; }
            set { _ngayPhatHanh = value; }
        }
        public string NoiDung
        { 
            get { return _noiDung; }
            set { _noiDung = value; }
        }
        public int SoBao
        {
            get { return _so; }
            set { _so = value; }
        }

        public Bao()
        {
            _giaBan = 0;
            _ngayPhatHanh = DateTime.Now;  // Đặt ngày phát hành mặc định là ngày hiện tại
            _noiDung = "Chưa có nội dung";
            _so = 0;
        }

        // Constructor có tham số để tạo một số báo với các thuộc tính cụ thể
        public Bao(int giaBan, DateTime ngayPhatHanh, string noiDung, int so)
        {
            _giaBan = giaBan;
            _ngayPhatHanh = ngayPhatHanh;
            _noiDung = noiDung;
            _so = so;
        }

        public override string ToString()
        {
            return $"Số báo: {_so}, Ngày phát hành: {_ngayPhatHanh.ToShortDateString()}, Giá bán: {_giaBan} VND, Nội dung: {_noiDung}";
        }
    }
}
