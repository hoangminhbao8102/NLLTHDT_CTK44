using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    public class Program
    {
        enum Menu
        {
            Thoat = 0,
            NhapTay = 1,
            NhapNgauNhien = 2,
            NhapTuFile = 3,
            Xuat = 4,
            TimMax,
            TimTheoMau,
            DemSoPhanSoAm,
            DemSoPhanSoDuong,
            DemSoPhanSoCoTuLa,
            DemSoPhanSoCoMauLa,
            TimPhanSoAmLonNhat,
            TimPhanSoAmNhoNhat,
            TimPhanSoDuongLonNhat,
            TimPhanSoDuongNhoNhat,
            TimTatCaPhanSoAm,
            TimTatCaPhanSoDuong,
            TimViTriCuaPhanSo,
            TimViTriCuaPhanSoAmDuong,
            TongTatCaPhanSoAm,
            TongTatCaPhanSoDuong,
            TongTatCaPhanSoCoTuLa,
            TongTatCaPhanSoCoMauLa,
            XoaPhanSoX,
            XoaTatCaPhanSoCoTuLa,
            XoaTatCaPhanSoCoMauLa,
            XoaTatCaPhanSoGiongPhanSoDauTien,
            XoaTatCaPhanSoGiongPhanSoCuoiCung,
            XoaTatCaPhanSoNhoNhat,
            XoaTaiCacViTri,
            ThemPhanSoTaiViTri,
            ThemPhanSoDauTien,
            XoaTatCaPhanSoAm,
            XoaTatCaPhanSoDuong,
            SapXepTang,
            SapXepGiam,
            SapXepTangTheoTu,
            SapXepGiamTheoTu,
            SapXepTangTheoMau,
            SapXepGiamTheoMau
        }
        static void Main(string[] args)
        {
            MangPhanSo ds = new MangPhanSo();
            while (true)
            {
                Console.WriteLine("Nhap {0} de thoat ", (int)Menu.Thoat);
                Console.WriteLine("Nhap {0} de nhap tay", (int)Menu.NhapTay);
                Console.WriteLine("Nhap {0} de nhap ngau nhien", (int)Menu.NhapNgauNhien);
                Console.WriteLine("Nhap {0} de nhap tu file ", (int)Menu.NhapTuFile);
                Console.WriteLine("Nhap {0} de xuat ", (int)Menu.Xuat);
                Console.WriteLine("Nhap {0} de tim max ", (int)Menu.TimMax);
                Console.WriteLine("Nhap {0} de tim theo mau ", (int)Menu.TimTheoMau);
                Console.WriteLine("Nhap {0} de dem so phan so am trong mang ", (int)Menu.DemSoPhanSoAm);
                Console.WriteLine("Nhap {0} de dem so phan so duong trong mang ", (int)Menu.DemSoPhanSoDuong);
                Console.WriteLine("Nhap {0} de dem phan so co tu la x trong mang ", (int)Menu.DemSoPhanSoCoTuLa);
                Console.WriteLine("Nhap {0} de dem phan so co mau la x trong mang ", (int)Menu.DemSoPhanSoCoMauLa);
                Console.WriteLine("Nhap {0} de tim phan so am lon nhat ", (int)Menu.TimPhanSoAmLonNhat);
                Console.WriteLine("Nhap {0} de tim phan so am nho nhat ", (int)Menu.TimPhanSoAmNhoNhat);
                Console.WriteLine("Nhap {0} de tim phan so duong lon nhat ", (int)Menu.TimPhanSoDuongLonNhat);
                Console.WriteLine("Nhap {0} de tim phan so duong nho nhat ", (int)Menu.TimPhanSoDuongNhoNhat);
                Console.WriteLine("Nhap {0} de tim tat ca phan so am ", (int)Menu.TimTatCaPhanSoAm);
                Console.WriteLine("Nhap {0} de tim tat ca phan so duong ", (int)Menu.TimTatCaPhanSoDuong);
                Console.WriteLine("Nhap {0} de tim vi tri cua phan so x trong mang ", (int)Menu.TimViTriCuaPhanSo);
                Console.WriteLine("Nhap {0} de tim vi tri cua phan so am, duong trong mang ", (int)Menu.TimViTriCuaPhanSoAmDuong);
                Console.WriteLine("Nhap {0} de tinh tong tat ca phan so am trong mang ", (int)Menu.TongTatCaPhanSoAm);
                Console.WriteLine("Nhap {0} de tinh tong tat ca phan so duong trong mang ", (int)Menu.TongTatCaPhanSoDuong);
                Console.WriteLine("Nhap {0} de tinh tong tat ca phan so co tu la x trong mang ", (int)Menu.TongTatCaPhanSoCoTuLa);
                Console.WriteLine("Nhap {0} de tinh tong tat ca phan so co mau la x trong mang ", (int)Menu.TongTatCaPhanSoCoMauLa);
                Console.WriteLine("Nhap {0} de xoa phan so x trong mang ", (int)Menu.XoaPhanSoX);
                Console.WriteLine("Nhap {0} de xoa tat ca phan so co tu la x trong mang ", (int)Menu.XoaTatCaPhanSoCoTuLa);
                Console.WriteLine("Nhap {0} de xoa tat ca phan so co mau la x trong mang ", (int)Menu.XoaTatCaPhanSoCoMauLa);
                Console.WriteLine("Nhap {0} de xoa tat ca phan so giong phan so dau tien trong mang ", (int)Menu.XoaTatCaPhanSoGiongPhanSoDauTien);
                Console.WriteLine("Nhap {0} de xoa tat ca phan so giong phan so cuoi cung trong mang ", (int)Menu.XoaTatCaPhanSoGiongPhanSoCuoiCung);
                Console.WriteLine("Nhap {0} de xoa tat ca phan so nho nhat trong mang ", (int)Menu.XoaTatCaPhanSoNhoNhat);
                Console.WriteLine("Nhap {0} de xoa phan tu tai cac vi tri ", (int)Menu.XoaTaiCacViTri);
                Console.WriteLine("Nhap {0} de them phan so tai vi tri ", (int)Menu.ThemPhanSoTaiViTri);
                Console.WriteLine("Nhap {0} de them phan so dau tien ", (int)Menu.ThemPhanSoDauTien);
                Console.WriteLine("Nhap {0} de xoa tat ca phan so am ", (int)Menu.XoaTatCaPhanSoAm);
                Console.WriteLine("Nhap {0} de xoa tat ca phan so duong ", (int)Menu.XoaTatCaPhanSoDuong);
                Console.WriteLine("Nhap {0} de sap xep tang ", (int)Menu.SapXepTang);
                Console.WriteLine("Nhap {0} de sap xep giam ", (int)Menu.SapXepGiam);
                Console.WriteLine("Nhap {0} de sap xep tang theo tu ", (int)Menu.SapXepTangTheoTu);
                Console.WriteLine("Nhap {0} de sap xep giam theo tu ", (int)Menu.SapXepGiamTheoTu);
                Console.WriteLine("Nhap {0} de sap xep tang theo mau ", (int)Menu.SapXepTangTheoMau);
                Console.WriteLine("Nhap {0} de sap xep giam theo mau ", (int)Menu.SapXepGiamTheoMau);
                Menu menu = (Menu)int.Parse(Console.ReadLine());
                switch (menu) 
                {
                    case Menu.Thoat: return;
                    case Menu.NhapTay:
                        ds.Nhap();
                        break;
                    case Menu.NhapNgauNhien:
                        ds.NhapNgauNhien();
                        break;
                    case Menu.NhapTuFile: 
                        ds.NhapTuFile();
                        break;
                    case Menu.Xuat:
                        ds.Xuat();
                        break;
                    case Menu.TimMax:
                        PhanSo maxPhanSo = ds.TimMax();
                        Console.WriteLine("Phan so lon nhat la: {0}/{1}", maxPhanSo.tu, maxPhanSo.mau);
                        break;
                    case Menu.TimTheoMau:
                        Console.WriteLine("Nhap gia tri cua mau: ");
                        int mau = int.Parse(Console.ReadLine());
                        MangPhanSo ketQuaTheoMau = ds.TimPhanSoCoMauLa(mau);
                        Console.WriteLine("Cac phan so co mau {0} là:", mau);
                        ketQuaTheoMau.Xuat();
                        break;
                    case Menu.DemSoPhanSoAm:
                        Console.WriteLine("So phan so am trong mang: " + ds.DemPhanSoAm());
                        break;
                    case Menu.DemSoPhanSoDuong:
                        Console.WriteLine("So phan so duong trong mang: " + ds.DemPhanSoDuong());
                        break;
                    case Menu.DemSoPhanSoCoTuLa:
                        Console.WriteLine("Nhap phan so can tim: ");
                        int tuTim = int.Parse(Console.ReadLine());
                        Console.WriteLine("So phan so co tu la " + tuTim + " trong mang: " + ds.DemPhanSoCoTuLa(tuTim));
                        break;
                    case Menu.DemSoPhanSoCoMauLa:
                        Console.WriteLine("Nhap phan so can tim: ");
                        int mauTim = int.Parse(Console.ReadLine());
                        Console.WriteLine("So phan so co mau la " + mauTim + " trong mang: " + ds.DemPhanSoCoMauLa(mauTim));
                        break;
                    case Menu.TimPhanSoAmLonNhat:
                        PhanSo maxAm = ds.TimPhanSoAmLonNhat();
                        if (maxAm != null)
                            Console.WriteLine("Phan so am lon nhat: ");
                        maxAm.Xuat();
                        break;
                    case Menu.TimPhanSoAmNhoNhat:
                        PhanSo minAm = ds.TimPhanSoAmNhoNhat();
                        if (minAm != null)
                            Console.WriteLine("Phan so am nho nhat: ");
                        minAm.Xuat();
                        break;
                    case Menu.TimPhanSoDuongLonNhat:
                        PhanSo maxDuong = ds.TimPhanSoDuongLonNhat();
                        if (maxDuong != null)
                            Console.WriteLine("Phan so duong lon nhat: ");
                        maxDuong.Xuat();
                        break;
                    case Menu.TimPhanSoDuongNhoNhat:
                        PhanSo minDuong = ds.TimPhanSoDuongNhoNhat();
                        if (minDuong != null)
                            Console.WriteLine("Phan so duong nho nhat: ");
                        minDuong.Xuat();
                        break;
                    case Menu.TimTatCaPhanSoAm:
                        MangPhanSo am = ds.TimTatCaPhanSoAm();
                        Console.WriteLine("Tat ca phan so am: ");
                        am.Xuat();
                        break;
                    case Menu.TimTatCaPhanSoDuong:
                        MangPhanSo duong = ds.TimTatCaPhanSoDuong();
                        Console.WriteLine("Tat ca phan so duong: ");
                        duong.Xuat();
                        break;
                    case Menu.TimViTriCuaPhanSo:
                        Console.WriteLine("Nhap phan so can tim vi tri: ");
                        int tuViTri = int.Parse(Console.ReadLine());
                        int[] viTri = ds.TimViTriCuaPhanSo(tuViTri);
                        Console.WriteLine("Vi tri cua phan so co tu la " + tuViTri + " trong mang: ");
                        foreach (int vt in viTri)
                        {
                            Console.Write(vt + " ");
                        }
                        Console.WriteLine();
                        break;
                    case Menu.TimViTriCuaPhanSoAmDuong:
                        Console.WriteLine("Vi tri cua phan so am hoac duong trong mang: ");
                        int[] viTriAD = ds.TimViTriCuaPhanSoAmDuong();
                        foreach (int vt in viTriAD)
                        {
                            Console.Write(vt + " ");
                        }
                        Console.WriteLine();
                        break;
                    case Menu.TongTatCaPhanSoAm:
                        Console.WriteLine("Tong tat ca phan so am trong mang: " + ds.TinhTongTatCaPhanSoAm());
                        break;
                    case Menu.TongTatCaPhanSoDuong:
                        Console.WriteLine("Tong tat ca phan so duong trong mang: " + ds.TinhTongTatCaPhanSoDuong());
                        break;
                    case Menu.TongTatCaPhanSoCoTuLa:
                        Console.WriteLine("Nhap phan so can tinh tong: ");
                        int tuTong = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tong tat ca phan so co tu la " + tuTong + " trong mang: " + ds.TinhTongTatCaPhanSoCoTuLa(tuTong));
                        break;
                    case Menu.TongTatCaPhanSoCoMauLa:
                        Console.WriteLine("Nhap phan so can tinh tong mau: ");
                        int mauTong = int.Parse(Console.ReadLine());
                        Console.WriteLine("Tong tat ca phan so co mau la " + mauTong + " trong mang: " + ds.TinhTongTatCaPhanSoCoMauLa(mauTong));
                        break;
                    case Menu.XoaPhanSoX:
                        Console.WriteLine("Nhap vi tri can xoa: ");
                        int vtXoa = int.Parse(Console.ReadLine());
                        ds.XoaPhanSoTaiViTri(vtXoa);
                        break;
                    case Menu.XoaTatCaPhanSoCoTuLa:
                        Console.WriteLine("Nhap phan so can xoa: ");
                        int phanSoXoa = int.Parse(Console.ReadLine());
                        ds.XoaPhanSoCoTuLa(phanSoXoa);
                        break;
                    case Menu.XoaTatCaPhanSoCoMauLa:
                        Console.WriteLine("Nhap phan so can xoa: ");
                        int mauXoa = int.Parse(Console.ReadLine());
                        ds.XoaPhanSoCoMauLa(mauXoa);
                        break;
                    case Menu.XoaTatCaPhanSoGiongPhanSoDauTien:
                        ds.XoaPhanSoGiongPhanSoDauTien();
                        break;
                    case Menu.XoaTatCaPhanSoGiongPhanSoCuoiCung:
                        ds.XoaPhanSoGiongPhanSoCuoiCung();
                        break;
                    case Menu.XoaTatCaPhanSoNhoNhat:
                        ds.XoaTatCaPhanSoNhoNhat();
                        break;
                    case Menu.XoaTaiCacViTri:
                        Console.WriteLine("Nhap so vi tri can xoa: ");
                        int n = int.Parse(Console.ReadLine());
                        int[] viTriXoa = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write("Nhap vi tri thu " + (i + 1) + ": ");
                            viTriXoa[i] = int.Parse(Console.ReadLine());
                        }
                        ds.XoaTaiCacViTri(viTriXoa);
                        break;
                    case Menu.ThemPhanSoTaiViTri:
                        PhanSo phanSoThem = new PhanSo(1, 1);
                        Console.WriteLine("Nhap vi tri can them: ");
                        int vtThem = int.Parse(Console.ReadLine());
                        ds.ThemPhanSoTaiViTri(phanSoThem, vtThem);
                        break;
                    case Menu.ThemPhanSoDauTien:
                        PhanSo phanSoDau = new PhanSo(2, 2);
                        ds.ThemPhanSoDauTien(phanSoDau);
                        break;
                    case Menu.XoaTatCaPhanSoAm:
                        ds.XoaTatCaPhanSoAm();
                        break;
                    case Menu.XoaTatCaPhanSoDuong:
                        ds.XoaTatCaPhanSoDuong();
                        break;
                    case Menu.SapXepTang:
                        ds.SapXepTang();
                        break;
                    case Menu.SapXepGiam:
                        ds.SapXepGiam();
                        break;
                    case Menu.SapXepTangTheoTu:
                        ds.SapXepTangTheoTu();
                        break;
                    case Menu.SapXepGiamTheoTu:
                        ds.SapXepGiamTheoTu();
                        break;
                    case Menu.SapXepTangTheoMau:
                        ds.SapXepTangTheoMau();
                        break;
                    case Menu.SapXepGiamTheoMau:
                        ds.SapXepGiamTheoMau();
                        break;
                    default:
                        Console.WriteLine("Lua chon khong hop le.");
                        break;
                }
            }
        }
    }
}
