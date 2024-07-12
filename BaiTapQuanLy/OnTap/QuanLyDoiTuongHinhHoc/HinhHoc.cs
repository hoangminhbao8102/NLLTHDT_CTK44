using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    public abstract class HinhHoc
    {
        // Các thuộc tính chung cho mọi hình học
        public string MauSac { get; set; }

        // Constructor để thiết lập các thuộc tính mặc định
        protected HinhHoc(string mauSac)
        {
            MauSac = mauSac;
        }

        // Các phương thức abstract bắt buộc phải được cài đặt bởi lớp con
        public abstract float TinhDT();
        public abstract float TinhCV();

        // Phương thức để in thông tin cơ bản về hình học
        public virtual void InThongTin()
        {
            Console.WriteLine($"Màu sắc: {MauSac}");
        }
    }
}
