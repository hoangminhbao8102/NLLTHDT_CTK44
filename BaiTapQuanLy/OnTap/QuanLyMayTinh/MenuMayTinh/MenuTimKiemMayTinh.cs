using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MenuTimKiemMayTinh
    {
        private DanhSachMayTinh mayTinh;

        public MenuTimKiemMayTinh()
        {
            mayTinh = new DanhSachMayTinh();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU TÌM KIẾM ==================");
            Console.WriteLine("{0}. Tìm máy tính có giá cao nhất.", (int)ChucNangTimKiemMayTinh.TimMayTinhCoGiaCaoNhat);
            Console.WriteLine("{0}. Truy vấn giá cao nhất trong danh sách.", (int)ChucNangTimKiemMayTinh.TimGiaCaoNhat);
            Console.WriteLine("{0}. Tìm máy tính có giá rẻ nhất.", (int)ChucNangTimKiemMayTinh.TimMayTinhCoGiaReNhat);
            Console.WriteLine("{0}. Tìm máy tính theo giá CPU.", (int)ChucNangTimKiemMayTinh.TimMayTinhTheoGiaCPU);
            Console.WriteLine("{0}. Tìm máy tính theo giá RAM.", (int)ChucNangTimKiemMayTinh.TimMayTinhTheoGiaRAM);
            Console.WriteLine("{0}. Tìm danh sách hãng.", (int)ChucNangTimKiemMayTinh.TimDanhSachHang);
            Console.WriteLine("{0}. Tìm danh sách thiết bị phổ biến nhất.", (int)ChucNangTimKiemMayTinh.TimThietBiNhieuNhat);
            Console.WriteLine("{0}. Tìm danh sách hãng xuất hiện phổ biến nhất.", (int)ChucNangTimKiemMayTinh.TimHangXuatHienNhieuNhat);
            Console.WriteLine("{0}. Tìm máy tính theo dung lượng và hãng RAM.", (int)ChucNangTimKiemMayTinh.TimMayTinhTheoDungLuongRAMVaHang);
            Console.WriteLine("{0}. Tìm máy tính theo dung lượng RAM cao nhất.", (int)ChucNangTimKiemMayTinh.TimMayTinhCoDungLuongRAMCaoNhat);
            Console.WriteLine("{0}. Tìm máy tính theo dung lượng RAM thấp nhất.", (int)ChucNangTimKiemMayTinh.TimMayTinhCoDungLuongRAMThapNhat);
            Console.WriteLine("{0}. Tìm máy tính có dung lượng RAM lớn hơn giá trị cho trước.", (int)ChucNangTimKiemMayTinh.TimMayTinhCoDungLuongRAMLonHon);
            Console.WriteLine("{0}. Tìm hãng sản xuất RAM có dung lượng cao nhất.", (int)ChucNangTimKiemMayTinh.TimHangSanXuatRAMCoDungLuongCaoNhat);
            Console.WriteLine("{0}. Tìm hãng sản xuất RAM có dung lượng thấp nhất.", (int)ChucNangTimKiemMayTinh.TimHangSanXuatRAMCoDungLuongThapNhat);
            Console.WriteLine("{0}. Tìm máy tính theo tốc độ CPU.", (int)ChucNangTimKiemMayTinh.TimMayTinhTheoTocDoCPU);
            Console.WriteLine("{0}. Tìm hãng có nhiều CPU tốc độ nhất.", (int)ChucNangTimKiemMayTinh.TimHangCoNhieuCPUTocDoCaoNhat);
            Console.WriteLine("{0}. Tìm hãng có ít CPU tốc độ nhất.", (int)ChucNangTimKiemMayTinh.TimHangCoItCPUTocDoThapNhat);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangTimKiemMayTinh.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangTimKiemMayTinh Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTimKiemMayTinh)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu tìm kiếm (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangTimKiemMayTinh)menu;
        }

        private void Process(ChucNangTimKiemMayTinh menu)
        {
            switch (menu)
            {
                case ChucNangTimKiemMayTinh.Thoat:
                    Console.WriteLine("Kết thúc chương trình tìm kiếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhCoGiaCaoNhat:
                    var dtCaoNhat = mayTinh.TimMayTinhCoGiaCaoNhat();
                    Console.WriteLine(dtCaoNhat);
                    break;
                case ChucNangTimKiemMayTinh.TimGiaCaoNhat:
                    float giaCaoNhat = mayTinh.TimGiaCaoNhat();
                    Console.WriteLine($"Giá cao nhất: {giaCaoNhat}");
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhCoGiaReNhat:
                    var dtReNhat = mayTinh.TimMayTinhCoGiaReNhat();
                    Console.WriteLine(dtReNhat);
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhTheoGiaCPU:
                    Console.WriteLine("Nhập true để tìm CPU giá cao nhất, false cho giá thấp nhất:");
                    bool cpuCaoNhat = bool.Parse(Console.ReadLine());
                    var dtTheoCPUGia = mayTinh.TimMayTinhTheoGiaCPU(cpuCaoNhat);
                    Console.WriteLine(dtTheoCPUGia);
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhTheoGiaRAM:
                    Console.WriteLine("Nhập true để tìm RAM giá cao nhất, false cho giá thấp nhất:");
                    bool ramCaoNhat = bool.Parse(Console.ReadLine());
                    var dtTheoRAMGia = mayTinh.TimMayTinhTheoGiaRAM(ramCaoNhat);
                    Console.WriteLine(dtTheoRAMGia);
                    break;
                case ChucNangTimKiemMayTinh.TimDanhSachHang:
                    var dsHang = mayTinh.TimDanhSachHang();
                    Console.WriteLine(String.Join(", ", dsHang));
                    break;
                case ChucNangTimKiemMayTinh.TimThietBiNhieuNhat:
                    int tbNhieuNhat = mayTinh.TimThietBiNhieuNhat();
                    Console.WriteLine($"Thiết bị xuất hiện nhiều nhất: {tbNhieuNhat}");
                    break;
                case ChucNangTimKiemMayTinh.TimHangXuatHienNhieuNhat:
                    var hangPhoBien = mayTinh.TimHangXuatHienNhieuNhat();
                    Console.WriteLine(String.Join(", ", hangPhoBien));
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhTheoDungLuongRAMVaHang:
                    Console.WriteLine("Nhập dung lượng RAM và hãng (cách nhau bởi dấu phẩy):");
                    var input = Console.ReadLine().Split(',');
                    float dungLuong = float.Parse(input[0]);
                    string hang = input[1].Trim();
                    var dtTheoDungLuongVaHang = mayTinh.TimMayTinhTheoDungLuongRAMVaHang(dungLuong, hang);
                    Console.WriteLine(String.Join("\n", dtTheoDungLuongVaHang));
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhCoDungLuongRAMCaoNhat:
                    var dtDungLuongCaoNhat = mayTinh.TimMayTinhCoDungLuongRAMCaoNhat();
                    Console.WriteLine(dtDungLuongCaoNhat);
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhCoDungLuongRAMThapNhat:
                    var dtDungLuongThapNhat = mayTinh.TimMayTinhCoDungLuongRAMThapNhat();
                    Console.WriteLine(dtDungLuongThapNhat);
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhCoDungLuongRAMLonHon:
                    Console.WriteLine("Nhập dung lượng RAM:");
                    float lonHon = float.Parse(Console.ReadLine());
                    var dtDungLuongLonHon = mayTinh.TimMayTinhCoDungLuongRAMLonHon(lonHon);
                    Console.WriteLine(String.Join("\n", dtDungLuongLonHon));
                    break;
                case ChucNangTimKiemMayTinh.TimHangSanXuatRAMCoDungLuongCaoNhat:
                    var hangDungLuongCaoNhat = mayTinh.TimHangSanXuatRAMCoDungLuongCaoNhat();
                    Console.WriteLine($"Hãng sản xuất RAM dung lượng cao nhất: {hangDungLuongCaoNhat}");
                    break;
                case ChucNangTimKiemMayTinh.TimHangSanXuatRAMCoDungLuongThapNhat:
                    var hangDungLuongThapNhat = mayTinh.TimHangSanXuatRAMCoDungLuongThapNhat();
                    Console.WriteLine($"Hãng sản xuất RAM dung lượng thấp nhất: {hangDungLuongThapNhat}");
                    break;
                case ChucNangTimKiemMayTinh.TimMayTinhTheoTocDoCPU:
                    Console.WriteLine("Nhập true để tìm CPU tốc độ cao nhất, false cho tốc độ thấp nhất:");
                    bool tocDoCaoNhat = bool.Parse(Console.ReadLine());
                    var dtTheoTocDoCPU = mayTinh.TimMayTinhTheoTocDoCPU(tocDoCaoNhat);
                    Console.WriteLine(dtTheoTocDoCPU);
                    break;
                case ChucNangTimKiemMayTinh.TimHangCoNhieuCPUTocDoCaoNhat:
                    var hangCPUTocDoCaoNhat = mayTinh.TimHangCoNhieuCPUTocDoCaoNhat();
                    Console.WriteLine($"Hãng có nhiều CPU tốc độ cao nhất: {hangCPUTocDoCaoNhat}");
                    break;
                case ChucNangTimKiemMayTinh.TimHangCoItCPUTocDoThapNhat:
                    var hangCPUTocDoThapNhat = mayTinh.TimHangCoItCPUTocDoThapNhat();
                    Console.WriteLine($"Hãng có ít CPU tốc độ thấp nhất: {hangCPUTocDoThapNhat}");
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangTimKiemMayTinh menu = ChucNangTimKiemMayTinh.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTimKiemMayTinh.Thoat);
        }
    }
}
