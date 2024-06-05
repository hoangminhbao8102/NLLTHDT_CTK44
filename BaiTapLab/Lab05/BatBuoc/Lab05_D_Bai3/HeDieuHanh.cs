using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai3
{
    public class HeDieuHanh
    {
        protected float _giaBan;
        protected DateTime _ngayPhatHanh;
        protected string _phienBan;

        public float GiaBan
        {
            get { return _giaBan; }
        }
        public DateTime NgayPhatHanh
        {
            get { return _ngayPhatHanh; }
        }
        public string PhienBan
        {
            get { return _phienBan; }
        }

        protected HeDieuHanh(string phienBan, DateTime ngayPh, float gia)
        {
            this._phienBan = phienBan;
            this._ngayPhatHanh = ngayPh;
            this._giaBan = gia;
        }

        public virtual void XuatThongTin()
        {
            Console.WriteLine("Hệ điều hành: ");
            Console.WriteLine("Phiên bản: " + _phienBan);
            Console.WriteLine("Ngày phát hành: " + _ngayPhatHanh.ToShortDateString());
            Console.WriteLine("Giá bán: " + _giaBan + " VND");
        }
    }
}
