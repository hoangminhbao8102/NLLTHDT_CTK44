using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai1_Lab06_Bai02__SuDungLopTruuTuong_P2__
{
    public class Menu
    {
        private DanhSachHinhHoc dsHinhHoc;

        public Menu()
        {
            dsHinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhap co dinh", (int)ChucNang.NhapCoDinh);
            Console.WriteLine("{0}. Xuat hinh", (int)ChucNang.Xuat);
            Console.WriteLine("{0}. Tim hinh theo loai", (int)ChucNang.TimHinhTheoLoai);
            Console.WriteLine("{0}. Tim hinh co dien tich lon nhat", (int)ChucNang.TimHinhCoDienTichLonNhat);
            Console.WriteLine("{0}. Sap xep cac hinh giam dan theo dien tich", (int)ChucNang.SapTangTheoDienTich);
            Console.WriteLine("{0}. Tim hinh co dien tich nho nhat", (int)ChucNang.TimHinhCoDienTichNhoNhat);
            Console.WriteLine("{0}. Tim hinh tron có dien tich nho nhất", (int)ChucNang.TimHinhTronNhoNhat);
            Console.WriteLine("{0}. Sap xep cac hinh giam dan theo dien tich", (int)ChucNang.SapGiamTheoDienTich);
            Console.WriteLine("{0}. Đem so luong hinh theo loai", (int)ChucNang.DemSoLuongHinh);
            Console.WriteLine("{0}. Tinh tong dien tich cac hinh", (int)ChucNang.TinhTongDienTich);
            Console.WriteLine("{0}. Tim hinh co dien tich lon nhat theo loai hinh hoc", (int)ChucNang.TimHinhCoDienTichLonNhatTheoLoai);
            Console.WriteLine("{0}. Tim vi trí cua hinh trong danh sach", (int)ChucNang.TimViTriCuaHinh);
            Console.WriteLine("{0}. Xoa mot hinh tai vi tri cho truoc", (int)ChucNang.XoaTaiViTri);
            Console.WriteLine("{0}. Tim hinh theo dien tich", (int)ChucNang.TimHinhTheoDTich);
            Console.WriteLine("{0}. Xoa mot hinh hoc khoi danh sach", (int)ChucNang.XoaHinh);
            Console.WriteLine("{0}. Xoa tat ca cac hinh theo loai cho truoc", (int)ChucNang.XoaHinhTheoLoai);
            Console.WriteLine("{0}. Tim hình co chu vi nho nhat", (int)ChucNang.TimHinhCoChuViNhoNhat);
            Console.WriteLine("{0}. Xuat danh sach hinh theo loai va sap tang/giam", (int)ChucNang.XuatHinhTheoChieuTangGiam);
            Console.WriteLine("{0}. Tinh tong chu vi cac hinh theo loai", (int)ChucNang.TinhTongChuVi);
            Console.WriteLine("{0}. Tim nhung hinh co dien tich bang binh phuong cua chu vi", (int)ChucNang.TimHinhCoDienTichBangBinhPhuongChuVi);
            Console.WriteLine("{0}. Sap xep", (int)ChucNang.SapXep);
            Console.WriteLine("{0}. Thoat", (int)ChucNang.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNang Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNang)).Length;

            int menu = 0;

            do
            {
                this.Show();
                Console.Write("Nhap so de chon menu (0..{0}) : ", SoMenu);
            } while (menu < 0 || menu >= SoMenu);

            return (ChucNang)menu;
        }

        private void Process(ChucNang menu)
        {
            switch (menu)
            {
                case ChucNang.Thoat:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
                case ChucNang.NhapCoDinh:
                    dsHinhHoc.NhapCoDinh();
                    break;
                case ChucNang.Xuat:
                    Console.WriteLine("So hinh hoc trong danh sach {0}", dsHinhHoc.SoLuong);
                    dsHinhHoc.Xuat();
                    break;
                case ChucNang.TimHinhTheoLoai:
                    Console.Write("Nhap loai hinh (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    int loai = int.Parse(Console.ReadLine());
                    DanhSachHinhHoc dsHinh = dsHinhHoc.TimHinhTheoLoai((LoaiHinh)loai);
                    dsHinh.Xuat();
                    break;
                case ChucNang.TimHinhCoDienTichLonNhat:
                    DanhSachHinhHoc hinhLonNhat = dsHinhHoc.TimHinhCoDienTichLonNhat();
                    hinhLonNhat.Xuat();
                    break;
                case ChucNang.SapTangTheoDienTich:
                    dsHinhHoc.SapTangTheoDienTich();
                    dsHinhHoc.Xuat();
                    break;
                case ChucNang.TimHinhCoDienTichNhoNhat:
                    DanhSachHinhHoc hinhNhoNhat = dsHinhHoc.TimHinhCoDienTichNhoNhat();
                    hinhNhoNhat.Xuat();
                    break;
                case ChucNang.TimHinhTronNhoNhat:
                    DanhSachHinhHoc hinhTronNhoNhat = dsHinhHoc.TimHinhTronNhoNhat();
                    hinhTronNhoNhat.Xuat();
                    break;
                case ChucNang.SapGiamTheoDienTich:
                    dsHinhHoc.SapGiamTheoDienTich();
                    dsHinhHoc.Xuat();
                    break;
                case ChucNang.DemSoLuongHinh:
                    Console.WriteLine("Nhap loai hinh can dem (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    loai = int.Parse(Console.ReadLine());
                    LoaiHinh kieu = (LoaiHinh)loai;
                    int soLuongHinh = dsHinhHoc.DemSoLuongHinh(kieu);
                    Console.WriteLine("So luong hinh {0}: {1}", kieu, soLuongHinh);
                    break;
                case ChucNang.TinhTongDienTich:
                    double tongDienTich = dsHinhHoc.TinhTongDienTich();
                    Console.WriteLine("Tong didn tich các hình: {0}", tongDienTich);
                    break;
                case ChucNang.TimHinhCoDienTichLonNhatTheoLoai:
                    Console.WriteLine("Nhap loai hinh can tim (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    int loaiTim = int.Parse(Console.ReadLine());
                    LoaiHinh kieuTim = (LoaiHinh)loaiTim;
                    DanhSachHinhHoc hinhLonNhatTheoLoai = dsHinhHoc.TimHinhCoDienTichLonNhat(kieuTim);
                    hinhLonNhatTheoLoai.Xuat();
                    break;
                case ChucNang.TimViTriCuaHinh:
                    Console.Write("Nhap thong tin hinh can tim vi tri:");
                    Console.Write("Loai hinh (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    int loaiHinh = int.Parse(Console.ReadLine());
                    LoaiHinh kieuTimHinh = (LoaiHinh)loaiHinh;
                    switch (kieuTimHinh)
                    {
                        case LoaiHinh.HinhVuong:
                            Console.Write("Nhap canh cua hinh vuong: ");
                            double canhHV = double.Parse(Console.ReadLine());
                            HinhVuong hv = new HinhVuong(canhHV);
                            int viTriHV = dsHinhHoc.TimViTriCuaHinh(hv);
                            if (viTriHV != -1)
                            {
                                Console.WriteLine($"Hinh vuong co canh {canhHV} duoc tim thay tai vi tri {viTriHV + 1} trong danh sach.");
                            }
                            else
                            {
                                Console.WriteLine($"Hinh vuong co canh {canhHV} khong ton tai trong danh sach.");
                            }
                            break;
                        case LoaiHinh.HinhChuNhat:
                            Console.Write("Nhap chieu dai cua hinh chu nhat: ");
                            double chieuDaiHCN = double.Parse(Console.ReadLine());
                            Console.Write("Nhap chieu rong cua hinh chu nhat: ");
                            double chieuRongHCN = double.Parse(Console.ReadLine());
                            HinhChuNhat hcn = new HinhChuNhat(chieuDaiHCN, chieuRongHCN);
                            int viTriHCN = dsHinhHoc.TimViTriCuaHinh(hcn);
                            if (viTriHCN != -1)
                            {
                                Console.WriteLine($"Hinh chu nhat co chieu dai {chieuDaiHCN} va chieu rong {chieuRongHCN} duoc tim thay tai vi tri {viTriHCN + 1} trong danh sach.");
                            }
                            else
                            {
                                Console.WriteLine($"Hinh chu nhat co chieu dai {chieuDaiHCN} va chieu rong {chieuRongHCN} khong ton tai trong danh sach.");
                            }
                            break;
                        case LoaiHinh.HinhTron:
                            Console.Write("Nhap ban kinh cua hinh tron: ");
                            double banKinhHT = double.Parse(Console.ReadLine());
                            HinhTron ht = new HinhTron(banKinhHT);
                            int viTriHT = dsHinhHoc.TimViTriCuaHinh(ht);
                            if (viTriHT != -1)
                            {
                                Console.WriteLine($"Hinh tron co ban kinh {banKinhHT} duocc tim thay tai vi tri {viTriHT + 1} trong danh sach.");
                            }
                            else
                            {
                                Console.WriteLine($"Hinh tron co ban kinh {banKinhHT} khong ton tai trong danh sach.");
                            }
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le! Vui long nhap lai!");
                            break;
                    }
                    break;
                case ChucNang.XoaTaiViTri:
                    Console.WriteLine("Nhap vi tri can xoa: ");
                    int viTriXoa = int.Parse(Console.ReadLine());
                    bool xoaTaiViTri = dsHinhHoc.XoaTaiViTri(viTriXoa);
                    Console.WriteLine("Xoa tai vi tri {0}: {1}", viTriXoa, xoaTaiViTri);
                    break;
                case ChucNang.TimHinhTheoDTich:
                    Console.WriteLine("Nhap dien tich can tim: ");
                    double dt = double.Parse(Console.ReadLine());
                    DanhSachHinhHoc hinhTheoDT = dsHinhHoc.TimHinhTheoDTich(dt);
                    hinhTheoDT.Xuat();
                    break;
                case ChucNang.XoaHinh:
                    Console.WriteLine("Nhap thong tin hinh can xoa: ");
                    Console.Write("Loai hinh (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    loaiHinh = int.Parse(Console.ReadLine());
                    LoaiHinh kieuXoaHinh = (LoaiHinh)loaiHinh;
                    switch (kieuXoaHinh)
                    {
                        case LoaiHinh.HinhVuong:
                            Console.Write("Nhap canh cua hinh vuong: ");
                            double canhHV = double.Parse(Console.ReadLine());
                            HinhVuong hv = new HinhVuong(canhHV);
                            bool ketQuaHV = dsHinhHoc.XoaHinh(hv);
                            if (ketQuaHV)
                            {
                                Console.WriteLine($"Xoa hinh vuong co canh {canhHV} thanh cong!");
                            }
                            else
                            {
                                Console.WriteLine($"Xoa hinh vuong co canh {canhHV} that bai!");
                            }
                            break;
                        case LoaiHinh.HinhChuNhat:
                            Console.Write("Nhập chiều dài của hình chữ nhật: ");
                            double chieuDaiHCN = double.Parse(Console.ReadLine());
                            Console.Write("Nhập chiều rộng của hình chữ nhật: ");
                            double chieuRongHCN = double.Parse(Console.ReadLine());
                            HinhChuNhat hcn = new HinhChuNhat(chieuDaiHCN, chieuRongHCN);
                            bool ketQuaHCN = dsHinhHoc.XoaHinh(hcn);
                            if (ketQuaHCN)
                            {
                                Console.WriteLine($"Xoa hinh chu nhat co chieu dai {chieuDaiHCN} va chieu rong {chieuRongHCN} thanh cong!");
                            }
                            else
                            {
                                Console.WriteLine($"Xoa hinh chu nhat co chieu dai {chieuDaiHCN} va chieu rong {chieuRongHCN} that bai!");
                            }
                            break;
                        case LoaiHinh.HinhTron:
                            Console.Write("Nhập bán kính của hình tròn: ");
                            double banKinhHT = double.Parse(Console.ReadLine());
                            HinhTron ht = new HinhTron(banKinhHT);
                            bool ketQuaHT = dsHinhHoc.XoaHinh(ht);
                            if (ketQuaHT)
                            {
                                Console.WriteLine($"Xoa Hình tròn có bán kính {banKinhHT} thanh cong!");
                            }
                            else
                            {
                                Console.WriteLine($"Xoa Hình tròn có bán kính {banKinhHT} that bai!");
                            }
                            break;
                        default:
                            Console.WriteLine("Lua chon khong hop le! Vui long nhap lai!");
                            break;
                    }
                    break;
                case ChucNang.XoaHinhTheoLoai:
                    Console.WriteLine("Nhap loai hinh can xoa (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    int loaiXoa = int.Parse(Console.ReadLine());
                    LoaiHinh kieuXoa = (LoaiHinh)loaiXoa;
                    dsHinhHoc.XoaHinhTheoLoai(kieuXoa);
                    dsHinhHoc.Xuat();
                    break;
                case ChucNang.TimHinhCoChuViNhoNhat:
                    DanhSachHinhHoc hinhChuViNhoNhat = dsHinhHoc.TimHinhCoChuViNhoNhat();
                    hinhChuViNhoNhat.Xuat();
                    break;
                case ChucNang.XuatHinhTheoChieuTangGiam:
                    Console.WriteLine("Nhap loai hinh can xuat (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    int loaiXuat = int.Parse(Console.ReadLine());
                    LoaiHinh kieuXuat = (LoaiHinh)loaiXuat;
                    Console.WriteLine("Nhap thu tu sap xep (true - tang, false - giam): ");
                    bool tang = bool.Parse(Console.ReadLine());
                    dsHinhHoc.XuatHinhTheoChieuTangGiam(kieuXuat, tang);
                    break;
                case ChucNang.TinhTongChuVi:
                    Console.WriteLine("Nhap loai hinh can tinh tong chu vi (1 - Hinh tron, 2 - Hinh vuong, 3 - Hinh chu nhat): ");
                    int loaiTinh = int.Parse(Console.ReadLine());
                    LoaiHinh kieuTinh = (LoaiHinh)loaiTinh;
                    double tongChuVi = dsHinhHoc.TinhTongChuVi(kieuTinh);
                    Console.WriteLine("Tong chu vi hinh {0}: {1}", kieuTinh, tongChuVi);
                    break;
                case ChucNang.TimHinhCoDienTichBangBinhPhuongChuVi:
                    DanhSachHinhHoc hinhDienTichBangBinhPhuongChuVi = dsHinhHoc.TimHinhCoDienTichBangBinhPhuongChuVi();
                    hinhDienTichBangBinhPhuongChuVi.Xuat();
                    break;
                case ChucNang.SapXep:
                    Console.Write("Nhap kieu sap xep: ");
                    int ksx = int.Parse(Console.ReadLine());
                    dsHinhHoc.SapXep((KieuSapXep)ksx);
                    dsHinhHoc.Xuat();
                    break;
                default:
                    Console.WriteLine("Loi nhap so! Vui long nhap lai!");
                    break;
            }
        }

        public void Run()
        {
            ChucNang menu = ChucNang.Thoat;
            do
            {
                menu = this.Select();
                this.Process(menu);
            } while (menu != ChucNang.Thoat);
        }
    }
}
