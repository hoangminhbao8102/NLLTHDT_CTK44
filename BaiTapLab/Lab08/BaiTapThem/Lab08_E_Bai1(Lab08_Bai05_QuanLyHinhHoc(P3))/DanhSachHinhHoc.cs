using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai1_Lab08_Bai05_QuanLyHinhHoc_P3__
{
    public class DanhSachHinhHoc
    {
        private IHinhHoc[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public IHinhHoc this[int index]
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }

        public DanhSachHinhHoc()
        {
            danhSach = new IHinhHoc[100];
            soLuong = 0;
        }

        public void NhapCoDinh()
        {
            Console.WriteLine("Nhap so luong hinh hoc co dinnh: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap hinh hoc thu " + (i + 1) + ":");
                Console.WriteLine("1. Hinh tron");
                Console.WriteLine("2. Hinh vuong");
                Console.WriteLine("3. Hinh chu nhat");
                Console.WriteLine("Chon loai hinh: ");
                int loaiHinh = int.Parse(Console.ReadLine());
                LoaiHinh kieu = (LoaiHinh)loaiHinh;

                switch (kieu)
                {
                    case LoaiHinh.HinhChuNhat:
                        Console.WriteLine("Nhap chieu dai: ");
                        double chieuDai = double.Parse(Console.ReadLine());
                        Console.WriteLine("Nhap chieu rong: ");
                        double chieuRong = double.Parse(Console.ReadLine());
                        danhSach[soLuong] = new HinhChuNhat(chieuDai, chieuRong);
                        soLuong++;
                        break;
                    case LoaiHinh.HinhVuong:
                        Console.WriteLine("Nhap canh a: ");
                        double a = double.Parse(Console.ReadLine());
                        danhSach[soLuong] = new HinhVuong(a);
                        soLuong++;
                        break;
                    case LoaiHinh.HinhTron:
                        Console.WriteLine("Nhap ban kinh: ");
                        double r = double.Parse(Console.ReadLine());
                        danhSach[soLuong] = new HinhTron(r);
                        soLuong++;
                        break;
                    default:
                        Console.WriteLine("Loai hinh khong hop le");
                        break;
                }
            }
        }

        public void SapXep(ISoSanhHinhHoc ham, ThuTu thuTu)
        {
            int chieu = (int)thuTu;

            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (ham.SoSanh(danhSach[i], danhSach[j]) * chieu > 0)
                    {
                        IHinhHoc tam = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = tam;
                    }
                }
            }
        }

        public void Them(IHinhHoc taiLieu)
        {
            danhSach[soLuong] = taiLieu;
            soLuong++;
        }

        public List<HinhTron> GetHinhTron()
        {
            return danhSach.OfType<HinhTron>().ToList();
        }

        public List<HinhVuong> GetHinhVuong()
        {
            return danhSach.OfType<HinhVuong>().ToList();
        }

        public List<HinhChuNhat> GetHinhChuNhat()
        {
            return danhSach.OfType<HinhChuNhat>().ToList();
        }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < soLuong; i++)
            {
                result += danhSach[i].ToString() + "\n";
            }
            return result;
        }

        //d. Trong lớp DanhSachHinhHoc, cài đặt phương thức tìm các đối tượng hình học theo nguyên mẫu: public DanhSachHinhHoc TimKiem(IDieuKienTimKiem ham).
        public DanhSachHinhHoc TimKiem(IDieuKienTimKiem ham)
        {
            DanhSachHinhHoc danhSachTimKiem = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                if (ham.KiemTra(danhSach[i]))
                {
                    danhSachTimKiem.Them(danhSach[i]);
                }
            }
            return danhSachTimKiem;
        }

        //g.Tính tổng diện tích các hình học
        public double TinhTongDienTich()
        {
            double tongDienTich = 0;
            for (int i = 0; i < soLuong; i++)
            {
                tongDienTich += danhSach[i].TinhDienTich();
            }
            return tongDienTich;
        }

        //h.Tính tổng chu vi các hình học
        public double TinhTongChuVi()
        {
            double tongChuVi = 0;
            for (int i = 0; i < soLuong; i++)
            {
                tongChuVi += danhSach[i].TinhChuVi();
            }
            return tongChuVi;
        }

        //i.Tính tổng chu vi của các hình vuông
        public double TinhTongChuViHinhVuong()
        {
            double tongChuViHinhVuong = 0;
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhVuong)
                {
                    tongChuViHinhVuong += danhSach[i].TinhChuVi();
                }
            }
            return tongChuViHinhVuong;
        }

        //j.Tìm hình theo loại
        public DanhSachHinhHoc TimKiemTheoLoai(LoaiHinh loaiHinh)
        {
            DanhSachHinhHoc danhSachTimKiem = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == loaiHinh)
                {
                    danhSachTimKiem.Them(danhSach[i]);
                }
            }
            return danhSachTimKiem;
        }

        //k.Tìm diện tích của hình lớn nhất.
        public double TimDienTichLonNhat()
        {
            double dienTichLonNhat = 0;
            for (int i = 0; i < soLuong; i++)
            {
                double dienTichHienTai = danhSach[i].TinhDienTich();
                if (dienTichHienTai > dienTichLonNhat)
                {
                    dienTichLonNhat = dienTichHienTai;
                }
            }
            return dienTichLonNhat;
        }

        //l.Tìm hình chữ nhật có diện tích lớn nhất
        public HinhChuNhat TimHinhChuNhatCoDienTichLonNhat()
        {
            HinhChuNhat hinhChuNhatLonNhat = null;
            double dienTichLonNhat = 0;
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhChuNhat)
                {
                    HinhChuNhat hinhChuNhat = (HinhChuNhat)danhSach[i];
                    double dienTichHienTai = hinhChuNhat.TinhDienTich();
                    if (dienTichHienTai > dienTichLonNhat)
                    {
                        dienTichLonNhat = dienTichHienTai;
                        hinhChuNhatLonNhat = hinhChuNhat;
                    }
                }
            }
            return hinhChuNhatLonNhat;
        }

        //m. Tìm hình có giá trị chu vi lớn hơn giá trị diện tích (không tính đơn vị đo)
        public IHinhHoc TimHinhCoChuViLonHonDienTich()
        {
            for (int i = 0; i < soLuong; i++)
            {
                double chuVi = danhSach[i].TinhChuVi();
                double dienTich = danhSach[i].TinhDienTich();
                if (chuVi > dienTich)
                {
                    return danhSach[i];
                }
            }
            return null;
        }

        //n.Xóa hình tại vị trí(viTri) cho trước
        public void XoaHinhTaiViTri(int viTri)
        {
            if (viTri >= 0 && viTri < soLuong)
            {
                for (int i = viTri; i < soLuong - 1; i++)
                {
                    danhSach[i] = danhSach[i + 1];
                }
                danhSach[soLuong - 1] = null;
                soLuong--;
            }
        }

        //o.Xóa một hình học(hinh) cho trước
        public void XoaHinh(IHinhHoc hinh)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] == hinh)
                {
                    XoaHinhTaiViTri(i);
                    break;
                }
            }
        }

        //p.Xóa các hình thỏa điều kiện: void XoaTheoDK(IDieuKienTimKiem dieuKien)
        public void XoaTheoDieuKien(IDieuKienTimKiem dieuKien)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (dieuKien.KiemTra(danhSach[i]))
                {
                    XoaHinhTaiViTri(i);
                    i--; // Giảm i để kiểm tra lại phần tử mới sau khi xóa
                }
            }
        }

        //q.Đếm số lượng hình học mỗi loại
        public void DemSoLuongHinhHocMoiLoai()
        {
            int soLuongHinhChuNhat = 0;
            int soLuongHinhVuong = 0;
            int soLuongHinhTron = 0;

            for (int i = 0; i < soLuong; i++)
            {
                LoaiHinh loaiHinh = danhSach[i].LayKieuHinh();
                switch (loaiHinh)
                {
                    case LoaiHinh.HinhChuNhat:
                        soLuongHinhChuNhat++;
                        break;
                    case LoaiHinh.HinhVuong:
                        soLuongHinhVuong++;
                        break;
                    case LoaiHinh.HinhTron:
                        soLuongHinhTron++;
                        break;
                }
            }

            Console.WriteLine("So luong hinh chu nhat: " + soLuongHinhChuNhat);
            Console.WriteLine("So luong hinh vuong: " + soLuongHinhVuong);
            Console.WriteLine("So luong hinh tron: " + soLuongHinhTron);
        }

        //r.Tìm hình có chu vi nhỏ nhất nhưng không phải là hình vuông
        public IHinhHoc TimHinhCoChuViNhoNhat()
        {
            IHinhHoc hinhNhoNhat = null;
            double chuViNhoNhat = double.MaxValue;

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() != LoaiHinh.HinhVuong)
                {
                    double chuVi = danhSach[i].TinhChuVi();
                    if (chuVi < chuViNhoNhat)
                    {
                        chuViNhoNhat = chuVi;
                        hinhNhoNhat = danhSach[i];
                    }
                }
            }

            return hinhNhoNhat;
        }

        //s.Xuất danh sách hình chữ nhật tăng dần theo chu vi
        public void XuatDanhSachHinhChuNhatTangDanTheoChuVi()
        {
            DanhSachHinhHoc danhSachHinhChuNhat = new DanhSachHinhHoc();
            ISoSanhHinhHoc dieuKien = new SoSanhTheoChuVi();

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhChuNhat)
                {
                    danhSachHinhChuNhat.Them(danhSach[i]);
                }
            }

            danhSachHinhChuNhat.SapXep(dieuKien, ThuTu.Tang);

            danhSachHinhChuNhat.ToString();
        }

        //t. Liệt kê các hình chữ vuông hoặc hình tròn giảm dần theo diện tích
        public void LietKeHinhChuVuongVaHinhTronGiamDanTheoDienTich()
        {
            DanhSachHinhHoc danhSachHinhChuVuongVaHinhTron = new DanhSachHinhHoc();
            ISoSanhHinhHoc dieuKien = new SoSanhTheoDienTich();

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhVuong || danhSach[i].LayKieuHinh() == LoaiHinh.HinhTron)
                {
                    danhSachHinhChuVuongVaHinhTron.Them(danhSach[i]);
                }
            }

            danhSachHinhChuVuongVaHinhTron.SapXep(dieuKien, ThuTu.Giam);

            danhSachHinhChuVuongVaHinhTron.ToString();
        }

        //u.Tìm hình tròn có bán kính nhỏ nhất
        public HinhTron TimHinhTronCoBanKinhNhoNhat()
        {
            HinhTron hinhTronNhoNhat = null;
            double banKinhNhoNhat = double.MaxValue;

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhTron)
                {
                    HinhTron hinhTron = (HinhTron)danhSach[i];
                    Console.WriteLine("Nhap ban kinh bat ky : ");
                    double banKinh = double.Parse(Console.ReadLine());
                    if (banKinh < banKinhNhoNhat)
                    {
                        banKinhNhoNhat = banKinh;
                        hinhTronNhoNhat = hinhTron;
                    }
                }
            }

            return hinhTronNhoNhat;
        }

        //v.Tìm hình tròn có khả năng nội tiếp một hình vuông (hinhVuong) cho trước (R = cạnh / 2).
        public HinhTron TimHinhTronNoiTiepHinhVuong(HinhVuong hinhVuong)
        {
            double banKinh = hinhVuong.Canh / 2;
            HinhTron hinhTronNoiTiep = null;

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhTron)
                {
                    HinhTron hinhTron = (HinhTron)danhSach[i];
                    if (hinhTron.CoTheNoiTiepHinhVuong(hinhVuong))
                    {
                        hinhTronNoiTiep = hinhTron;
                        break;
                    }
                }
            }

            return hinhTronNoiTiep;
        }

        //w.Đếm số lượng hình vuông có diện tích lớn hơn diện tích mọi hình tròn.
        public int DemSoLuongHinhVuongCoDienTichLonHonHinhTron()
        {
            int count = 0;

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhVuong)
                {
                    HinhVuong hinhVuong = (HinhVuong)danhSach[i];
                    double dienTichHinhVuong = hinhVuong.TinhDienTich();

                    bool isLarger = true;
                    for (int j = 0; j < soLuong; j++)
                    {
                        if (danhSach[j].LayKieuHinh() == LoaiHinh.HinhTron)
                        {
                            HinhTron hinhTron = (HinhTron)danhSach[j];
                            double dienTichHinhTron = hinhTron.TinhDienTich();

                            if (dienTichHinhVuong <= dienTichHinhTron)
                            {
                                isLarger = false;
                                break;
                            }
                        }
                    }

                    if (isLarger)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        //x.Tính diện tích trung bình của các hình chữ nhật
        public double TinhDienTichTrungBinhHinhChuNhat()
        {
            double tongDienTich = 0;
            int count = 0;

            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].LayKieuHinh() == LoaiHinh.HinhChuNhat)
                {
                    HinhChuNhat hinhChuNhat = (HinhChuNhat)danhSach[i];
                    double dienTich = hinhChuNhat.TinhDienTich();

                    tongDienTich += dienTich;
                    count++;
                }
            }

            return tongDienTich / count;
        }

        //y.Tính độ chênh lệch nhỏ nhất về diện tích giữa các hình.
        public double TinhDoChenhLechNhoNhatVeDienTich()
        {
            double minChenhLech = double.MaxValue;

            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    double dienTich1 = danhSach[i].TinhDienTich();
                    double dienTich2 = danhSach[j].TinhDienTich();
                    double chenhLech = Math.Abs(dienTich1 - dienTich2);

                    if (chenhLech < minChenhLech)
                    {
                        minChenhLech = chenhLech;
                    }
                }
            }

            return minChenhLech;
        }

        //z.Cài đặt lớp Menu để xử lý các chức năng trên
    }
}
