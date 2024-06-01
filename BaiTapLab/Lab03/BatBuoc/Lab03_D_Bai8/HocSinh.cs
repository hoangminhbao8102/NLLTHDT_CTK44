using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai8
{
    public class HocSinh
    {
        private float _diemHoa;
        private float _diemLy;
        private float _diemToan;
        private string _hoTen;
        private string _lop;
        private NgayThang _ngaySinh;
        private int _viThu;
        private XepLoai _xepLoai;

        public float DiemHoa
        {
            get { return _diemHoa; }
            set { _diemHoa = value; }
        }

        public float DiemLy
        {
            get { return _diemLy; }
            set { _diemLy = value; }
        }

        public float DiemTB
        {
            get
            {
                return (DiemToan * 2 + DiemLy + DiemHoa) / 4;
            }
            set
            {
                // Giả sử bạn có một lý do đặc biệt để đặt điểm TB này.
                // Ví dụ: bạn có thể muốn điều chỉnh điểm dựa trên một số điều chỉnh ngoại lai.
                // Lưu ý: Cách tiếp cận này không được khuyến nghị vì nó có thể gây nhầm lẫn.
                // Đảm bảo bạn hiểu rõ lý do tại sao bạn lại cần đến điều này.
                throw new InvalidOperationException("Không thể trực tiếp thiết lập điểm trung bình. Điểm trung bình phải được tính từ các điểm thành phần.");
            }
        }

        public float DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }

        public string HoVaTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public string Lop
        {
            get { return _lop; }
            set { _lop = value; }
        }

        public NgayThang NgaySinh
        {
            get { return _ngaySinh; }
            set { _ngaySinh = value; }
        }

        public int ViThu
        {
            get { return _viThu; }
            set { _viThu = value; }
        }

        public XepLoai XepLoai
        {
            get { return _xepLoai; }
            set { _xepLoai = value; }
        }

        public HocSinh()
        {
            _hoTen = "";
            _lop = "";
            _ngaySinh = new NgayThang(1, 1, 2000); // Giả định ngày sinh mặc định
            _diemToan = 0;
            _diemLy = 0;
            _diemHoa = 0;
            _xepLoai = XepLoai.Kem; // Mặc định xếp loại là Kem
            _viThu = 0;
        }

        public HocSinh(string hoTen, string lop, NgayThang ngaySinh, float diemToan, float diemLy, float diemHoa)
        {
            _hoTen = hoTen;
            _lop = lop;
            _ngaySinh = ngaySinh;
            _diemToan = diemToan;
            _diemLy = diemLy;
            _diemHoa = diemHoa;
            _xepLoai = XepLoai; // Xếp loại có thể được tính toán dựa trên điểm TB
            _viThu = 0; // Giá trị mặc định, có thể được cập nhật sau
        }

        public override string ToString()
        {
            return $"Họ tên: {HoVaTen}, Lớp: {Lop}, Ngày sinh: {NgaySinh}, Điểm Toán: {DiemToan}, Điểm Lý: {DiemLy}, Điểm Hóa: {DiemHoa}, Điểm TB: {DiemTB}, Xếp loại: {XepLoai}";
        }
    }
}
