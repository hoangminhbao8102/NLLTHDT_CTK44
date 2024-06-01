using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai8
{
    public class DanhSachHocSinh
    {
        private HocSinh[] _danhSach;
        private int _soLuong;

        public int SoLuong
        { 
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public DanhSachHocSinh()
        {
            _danhSach = new HocSinh[1000];
            _soLuong = 0;
        }

        public void NhapCoDinh()
        {
            HocSinh hs1 = new HocSinh("Nguyen Van A", "10A1", new NgayThang(15, 10, 2005), 8.5f, 7.5f, 6.0f);
            HocSinh hs2 = new HocSinh("Le Thi B", "10A2", new NgayThang(22, 8, 2005), 5.5f, 6.5f, 7.5f);
            Them(hs1);
            Them(hs2);
        }

        public void NhapTuBanPhim()
        {
            Console.WriteLine("Nhập họ tên:");
            string hoTen = Console.ReadLine();

            Console.WriteLine("Nhập lớp:");
            string lop = Console.ReadLine();

            Console.WriteLine("Nhập ngày sinh:");
            int ngay = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập tháng sinh:");
            int thang = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập năm sinh:");
            int nam = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm Toán:");
            float diemToan = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm Lý:");
            float diemLy = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhập điểm Hóa:");
            float diemHoa = float.Parse(Console.ReadLine());

            NgayThang ngaySinh = new NgayThang(ngay, thang, nam);
            HocSinh hs = new HocSinh(hoTen, lop, ngaySinh, diemToan, diemLy, diemHoa);
            Them(hs);
        }

        public void SapXep(KieuSapXep ksx)
        {
            Array.Sort(_danhSach, 0, _soLuong, Comparer<HocSinh>.Create((x, y) =>
            {
                if (x == null) return 1; // Hoặc -1 tuỳ thuộc vào bạn muốn null ở đầu hay cuối.
                if (y == null) return -1; // Hoặc 1 tuỳ thuộc vào bạn muốn null ở đầu hay cuối.

                switch (ksx)
                {
                    case KieuSapXep.GiamTheoDTB:
                        return y.DiemTB.CompareTo(x.DiemTB);
                    case KieuSapXep.TangTheoHoTen:
                        return x.HoVaTen.CompareTo(y.HoVaTen);
                    case KieuSapXep.TangTheoViThu:
                        return x.ViThu.CompareTo(y.ViThu);
                    case KieuSapXep.GiamTheoLop:
                        return y.Lop.CompareTo(x.Lop);
                    default:
                        throw new ArgumentException("Không hỗ trợ kiểu sắp xếp này");
                }
            }));
        }

        public void SoSanh(HocSinh a, HocSinh b, KieuSapXep ksx)
        {
            int result;
            switch (ksx)
            {
                case KieuSapXep.GiamTheoDTB:
                    result = b.DiemTB.CompareTo(a.DiemTB);
                    break;
                case KieuSapXep.TangTheoHoTen:
                    result = a.HoVaTen.CompareTo(b.HoVaTen);
                    break;
                case KieuSapXep.TangTheoViThu:
                    result = a.ViThu.CompareTo(b.ViThu);
                    break;
                case KieuSapXep.GiamTheoLop:
                    result = b.Lop.CompareTo(a.Lop);
                    break;
                default:
                    throw new ArgumentException("Kiểu sắp xếp không được hỗ trợ.");
            }

            // Thực hiện một hành động dựa trên kết quả, ví dụ như in ra console
            if (result < 0)
            {
                Console.WriteLine($"{a.HoVaTen} comes before {b.HoVaTen} based on {ksx}");
            }
            else if (result > 0)
            {
                Console.WriteLine($"{b.HoVaTen} comes before {a.HoVaTen} based on {ksx}");
            }
            else
            {
                Console.WriteLine($"{a.HoVaTen} and {b.HoVaTen} are equivalent based on {ksx}");
            }
        }

        public void Them(HocSinh hs)
        {
            if (_soLuong < _danhSach.Length)
            {
                _danhSach[_soLuong++] = hs;
            }
            else
            {
                Console.WriteLine("Danh sách đầy, không thể thêm mới");
            }
        }

        public MangChuoi TimDanhSachLop()
        {
            MangChuoi mangChuoi = new MangChuoi();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && !mangChuoi.KiemTraTrung(hs.Lop))
                {
                    mangChuoi.Them(hs.Lop);
                }
            }
            return mangChuoi;
        }

        public float TimDiemTBCaoNhat()
        {
            return _danhSach.Where(hs => hs != null).Max(hs => hs.DiemTB);
        }

        public DanhSachHocSinh TimHocSinhTheoLop(string lop)
        {
            DanhSachHocSinh dsMoi = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.Lop == lop)
                {
                    dsMoi.Them(hs);
                }
            }
            return dsMoi;
        }
        
        public DanhSachHocSinh TimHocSinhTheoXepLoai(XepLoai xepLoai)
        {
            DanhSachHocSinh dsMoi = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.XepLoai == xepLoai)
                {
                    dsMoi.Them(hs);
                }
            }
            return dsMoi;
        }
        
        public DanhSachHocSinh TimHocSinhCoDTBCaoNhat()
        {
            float maxDTB = TimDiemTBCaoNhat();
            DanhSachHocSinh dsMoi = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.DiemTB == maxDTB)
                {
                    dsMoi.Them(hs);
                }
            }
            return dsMoi;
        }
        
        public MangChuoi TimLopNhieuHSGioiNhat()
        {
            Dictionary<string, int> countMap = new Dictionary<string, int>();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.XepLoai == XepLoai.Gioi)
                {
                    if (!countMap.ContainsKey(hs.Lop))
                    {
                        countMap[hs.Lop] = 0;
                    }
                    countMap[hs.Lop]++;
                }
            }

            int maxCount = countMap.Values.Max();
            MangChuoi mangChuoi = new MangChuoi();
            foreach (var pair in countMap)
            {
                if (pair.Value == maxCount)
                {
                    mangChuoi.Them(pair.Key);
                }
            }

            return mangChuoi;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null)
                    sb.AppendLine(hs.ToString());
            }
            return sb.ToString();
        }
        
        public void XepViThu()
        {
            Array.Sort(_danhSach, 0, _soLuong, Comparer<HocSinh>.Create((x, y) => x.ViThu.CompareTo(y.ViThu)));
        }

        // Tìm danh sách học sinh thi lại môn toán theo lớp.
        public DanhSachHocSinh TimHocSinhThiLaiMonToanTheoLop(string lop)
        {
            DanhSachHocSinh dsMoi = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.Lop == lop && hs.DiemToan < 5)
                {
                    dsMoi.Them(hs);
                }
            }
            return dsMoi;
        }

        // Tìm tất cả học sinh không thi lại môn nào.
        public DanhSachHocSinh TimHocSinhKhongThiLai()
        {
            DanhSachHocSinh dsMoi = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.DiemToan >= 5 && hs.DiemLy >= 5 && hs.DiemHoa >= 5)
                {
                    dsMoi.Them(hs);
                }
            }
            return dsMoi;
        }

        // Tìm những học sinh có họ Nguyễn và đạt loại Khá.
        public DanhSachHocSinh TimHocSinhHoNguyenLoaiKha()
        {
            DanhSachHocSinh dsMoi = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.HoVaTen.StartsWith("Nguyễn") && hs.XepLoai == XepLoai.Kha)
                {
                    dsMoi.Them(hs);
                }
            }
            return dsMoi;
        }

        // Tính điểm trung bình chung của từng lớp.
        public Dictionary<string, float> TinhDiemTBTheoLop()
        {
            Dictionary<string, List<float>> diemTheoLop = new Dictionary<string, List<float>>();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null)
                {
                    if (!diemTheoLop.ContainsKey(hs.Lop))
                    {
                        diemTheoLop[hs.Lop] = new List<float>();
                    }
                    diemTheoLop[hs.Lop].Add(hs.DiemTB);
                }
            }

            Dictionary<string, float> tbTheoLop = new Dictionary<string, float>();
            foreach (var lop in diemTheoLop)
            {
                tbTheoLop[lop.Key] = lop.Value.Average();
            }

            return tbTheoLop;
        }

        // Xóa những học sinh có điểm trung bình dưới 2.
        public void XoaHocSinhDiemTBThap()
        {
            int i = 0;
            while (i < _soLuong)
            {
                if (_danhSach[i] != null && _danhSach[i].DiemTB < 2)
                {
                    for (int j = i; j < _soLuong - 1; j++)
                    {
                        _danhSach[j] = _danhSach[j + 1];
                    }
                    _danhSach[_soLuong - 1] = null;
                    _soLuong--;
                }
                else
                {
                    i++;
                }
            }
        }

        // Thống kê số lượng học sinh Xuất sắc, Giỏi, Khá, … theo từng lớp
        public Dictionary<string, Dictionary<XepLoai, int>> ThongKeHocSinhTheoXepLoai()
        {
            Dictionary<string, Dictionary<XepLoai, int>> thongKe = new Dictionary<string, Dictionary<XepLoai, int>>();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null)
                {
                    if (!thongKe.ContainsKey(hs.Lop))
                        thongKe[hs.Lop] = new Dictionary<XepLoai, int>();

                    if (!thongKe[hs.Lop].ContainsKey(hs.XepLoai))
                        thongKe[hs.Lop][hs.XepLoai] = 0;

                    thongKe[hs.Lop][hs.XepLoai]++;
                }
            }
            return thongKe;
        }

        // Tìm những học sinh lớn hơn 15 tuổi.
        public DanhSachHocSinh TimHocSinhLonHon15Tuoi()
        {
            DanhSachHocSinh ketQua = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && (DateTime.Now.Year - hs.NgaySinh.Nam) > 15)
                {
                    ketQua.Them(hs);
                }
            }
            return ketQua;
        }

        // Tìm học sinh có tên dài nhất
        public HocSinh TimHocSinhTenDaiNhat()
        {
            HocSinh ketQua = null;
            int doDaiTenMax = 0;
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.HoVaTen.Length > doDaiTenMax)
                {
                    doDaiTenMax = hs.HoVaTen.Length;
                    ketQua = hs;
                }
            }
            return ketQua;
        }

        // Tìm những học sinh xếp vị thứ 1 của mỗi lớp.
        public Dictionary<string, HocSinh> TimHocSinhXepViThu1()
        {
            Dictionary<string, HocSinh> ketQua = new Dictionary<string, HocSinh>();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && (!ketQua.ContainsKey(hs.Lop) || ketQua[hs.Lop].DiemTB < hs.DiemTB))
                {
                    ketQua[hs.Lop] = hs;
                }
            }
            return ketQua;
        }

        // Tìm những học sinh có xếp loại trung bình trở xuống.
        public DanhSachHocSinh TimHocSinhXepLoaiTBTrXuong()
        {
            DanhSachHocSinh ketQua = new DanhSachHocSinh();
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && (hs.XepLoai == XepLoai.TrungBinh || hs.XepLoai == XepLoai.Yeu || hs.XepLoai == XepLoai.Kem))
                {
                    ketQua.Them(hs);
                }
            }
            return ketQua;
        }

        // Cộng thêm 1.5 điểm cho tất cả những học sinh không rớt môn nào.
        public void CongDiemChoHocSinhKhongRotMon()
        {
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null && hs.DiemToan >= 5 && hs.DiemLy >= 5 && hs.DiemHoa >= 5)
                {
                    hs.DiemToan = Math.Min(hs.DiemToan + 1.5f, 10);
                    hs.DiemLy = Math.Min(hs.DiemLy + 1.5f, 10);
                    hs.DiemHoa = Math.Min(hs.DiemHoa + 1.5f, 10);
                }
            }
        }

        // Xóa những học sinh có họ Trần
        public void XoaHocSinhHoTran()
        {
            int i = 0;
            while (i < _soLuong)
            {
                if (_danhSach[i] != null && _danhSach[i].HoVaTen.StartsWith("Trần"))
                {
                    for (int j = i; j < _soLuong - 1; j++)
                    {
                        _danhSach[j] = _danhSach[j + 1];
                    }
                    _danhSach[--_soLuong] = null;
                }
                else
                {
                    i++;
                }
            }
        }

        // Với các câu sau, xuất nội dung có định dạng & canh lề theo hình ảnh trên
        // - Xuất danh sách học sinh theo từng lớp.
        public void XuatDanhSachTheoLop()
        {
            Console.WriteLine("DANH SACH SINH VIEN");
            Console.WriteLine("Ho va Ten            Khoa Diem");
            Console.WriteLine("-------------------- ---- -----");
            Array.Sort(_danhSach, 0, _soLuong, Comparer<HocSinh>.Create((x, y) => x.Lop.CompareTo(y.Lop)));
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null)
                {
                    Console.WriteLine($"{hs.HoVaTen,-20} {hs.Lop,-4} {hs.DiemTB,5:F2}");
                }
            }
        }

        // - Xuất danh sách học sinh theo xếp loại.
        public void XuatDanhSachTheoXepLoai()
        {
            Console.WriteLine("DANH SACH SINH VIEN THEO XEP LOAI");
            Console.WriteLine("Ho va Ten            Xep Loai  Diem");
            Console.WriteLine("-------------------- --------- -----");

            // Sắp xếp mảng theo xếp loại học sinh
            Array.Sort(_danhSach, 0, _soLuong, Comparer<HocSinh>.Create((x, y) =>
            {
                if (x == null) return 1;
                if (y == null) return -1;
                int result = x.XepLoai.CompareTo(y.XepLoai);
                if (result == 0) // Nếu xếp loại giống nhau, sắp xếp theo tên
                    return x.HoVaTen.CompareTo(y.HoVaTen);
                return result;
            }));

            // Xuất danh sách đã sắp xếp
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null)
                {
                    Console.WriteLine($"{hs.HoVaTen,-20} {hs.XepLoai,-9} {hs.DiemTB,5:F2}");
                }
            }
        }

        // - Xuất danh sách học sinh theo từng năm sinh.
        public void XuatDanhSachTheoNamSinh()
        {
            Console.WriteLine("DANH SACH SINH VIEN THEO NAM SINH");
            Console.WriteLine("Ho va Ten            Nam Sinh  Diem");
            Console.WriteLine("-------------------- --------- -----");

            // Sắp xếp mảng theo năm sinh của học sinh
            Array.Sort(_danhSach, 0, _soLuong, Comparer<HocSinh>.Create((x, y) =>
            {
                if (x == null) return 1;
                if (y == null) return -1;
                int result = x.NgaySinh.Nam.CompareTo(y.NgaySinh.Nam);
                if (result == 0) // Nếu năm sinh giống nhau, sắp xếp theo tên
                    return x.HoVaTen.CompareTo(y.HoVaTen);
                return result;
            }));

            // Xuất danh sách đã sắp xếp
            foreach (HocSinh hs in _danhSach)
            {
                if (hs != null)
                {
                    Console.WriteLine($"{hs.HoVaTen,-20} {hs.NgaySinh.Nam,-9} {hs.DiemTB,5:F2}");
                }
            }
        }
    }
}
