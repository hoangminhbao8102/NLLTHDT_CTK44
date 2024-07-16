using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class DanhSachMayTinh
    {
        List<MayTinh> collection = new List<MayTinh>();
        public void NhapTuFile(string path)
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string str;
                    while ((str = sr.ReadLine()) != null)
                    {
                        MayTinh m = ParseMayTinhFromLine(str);
                        Them(m);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đọc file: " + ex.Message);
            }
        }

        private MayTinh ParseMayTinhFromLine(string line)
        {
            MayTinh m = new MayTinh();
            string[] components = line.Split('*');
            foreach (string component in components)
            {
                IThietBi tb = ThietBiFactory.CreateFromCSV(component);
                if (tb != null)
                {
                    m.Them(tb);
                }
            }
            return m;
        }
        public void Them(MayTinh mt)
        {
            collection.Add(mt);
        }
        public void ThemMayTinh()
        {
            Console.WriteLine("Nhập thông tin máy tính (theo định dạng CSV, dấu '*' để tách các thiết bị): ");
            string input = Console.ReadLine();
            MayTinh mt = ParseMayTinhFromLine(input); // Giả định ParseMayTinhFromLine là phương thức đã có
            Them(mt);
            Console.WriteLine("Đã thêm máy tính vào danh sách.");
        }

        public void ThemDanhSachHang()
        {
            Console.WriteLine("Nhập danh sách các hãng (cách nhau bằng dấu phẩy ','):");
            string input = Console.ReadLine();
            List<string> hangList = input.Split(',').Select(h => h.Trim()).ToList();
            List<string> danhSachHangTong = TimDanhSachHang(); // Giả định TimDanhSachHang là phương thức đã có
            foreach (var hang in hangList)
            {
                if (!danhSachHangTong.Contains(hang))
                    danhSachHangTong.Add(hang);
            }
            Console.WriteLine("Đã cập nhật danh sách hãng.");
        }
        public DanhSachMayTinh TimMayTinhCoGiaCaoNhat()
        {
            float maxPrice = collection.Max(mt => mt.TongGia());
            return new DanhSachMayTinh 
            { 
                collection = collection.Where(mt => mt.TongGia() == maxPrice).ToList() 
            };
        }
        public float TimGiaCaoNhat()
        {
            float max = -1;
            foreach (var item in collection)
            {
                if (max < item.TongGia())
                    max = item.TongGia();
            }
            return max;
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
            {
                s += item + "\n";
            }
            return s;
        }
        public int DemThietBiTheoHang(string hang)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                dem += item.DemTheoHang(hang);
            }
            return dem;
        }
        /// <summary>
        /// Ham them 1 ds chuoi vao ds chuoi, tranh trung nhau
        /// </summary>
        /// <param name="kq">Danh sach goc</param>
        /// <param name="hang">Danh sach hang</param>
        public void ThemDanhSachHang(List<string> kq, List<string> hang)
        {
            foreach (var item in hang)
            {
                if (!kq.Contains(item))
                    kq.Add(item);
            }
        }
        public List<string> TimDanhSachHang()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                ThemDanhSachHang(kq, item.TimDanhSachHang());
            }
            return kq;
        }
        public int TimThietBiNhieuNhat()
        {
            int max = -1;
            List<string> ds = TimDanhSachHang();
            foreach (var item in ds)
            {
                int tam = DemThietBiTheoHang(item);
                if (max < tam)
                    max = tam;
            }
            return max;
        }
        public List<string> TimHangXuatHienNhieuNhat()
        {
            List<string> kq = new List<string>();
            int max = TimThietBiNhieuNhat();
            List<string> ds = TimDanhSachHang();
            foreach (var item in ds)
            {
                int tam = DemThietBiTheoHang(item);
                if (tam == max)
                    kq.Add(item);
            }
            return kq;
        }
        //1. Chạy các phương thức đã thực hiện trong dự án (Program.cs).
        //2. Tìm máy tính có giá rẻ nhất
        public MayTinh TimMayTinhCoGiaReNhat()
        {
            float min = float.MaxValue;
            MayTinh mayTinhReNhat = null;
            foreach (var item in collection)
            {
                if (item.TongGia() < min)
                {
                    min = item.TongGia();
                    mayTinhReNhat = item;
                }
            }
            return mayTinhReNhat;
        }
        //3. Tìm máy tính có CPU có giá rẻ nhất, cao nhất; Ram cao nhất, thấp nhất
        public MayTinh TimMayTinhTheoGiaCPU(bool caoNhat)
        {
            MayTinh result = null;
            float bestPrice = caoNhat ? float.MinValue : float.MaxValue;
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection())
                {
                    if (tb is CPU cpu)
                    {
                        if ((caoNhat && cpu.Gia > bestPrice) || (!caoNhat && cpu.Gia < bestPrice))
                        {
                            bestPrice = cpu.Gia;
                            result = item;
                        }
                    }
                }
            }
            return result;
        }

        public MayTinh TimMayTinhTheoGiaRAM(bool caoNhat)
        {
            MayTinh result = null;
            float bestPrice = caoNhat ? float.MinValue : float.MaxValue;
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection())
                {
                    if (tb is RAM ram)
                    {
                        if ((caoNhat && ram.Gia > bestPrice) || (!caoNhat && ram.Gia < bestPrice))
                        {
                            bestPrice = ram.Gia;
                            result = item;
                        }
                    }
                }
            }
            return result;
        }
        //4. Tìm hãng có nhiều, ít CPU sử dụng nhất
        public string TimHangCoNhieuCPU()
        {
            var hangCount = new Dictionary<string, int>();
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection())
                {
                    if (tb is CPU cpu)
                    {
                        if (hangCount.ContainsKey(cpu.HangSX))
                        {
                            hangCount[cpu.HangSX]++;
                        }
                        else
                        {
                            hangCount[cpu.HangSX] = 1;
                        }
                    }
                }
            }
            return hangCount.OrderByDescending(h => h.Value).First().Key;
        }

        public string TimHangCoItCPU()
        {
            var hangCount = new Dictionary<string, int>();
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection())
                {
                    if (tb is CPU cpu)
                    {
                        if (hangCount.ContainsKey(cpu.HangSX))
                        {
                            hangCount[cpu.HangSX]++;
                        }
                        else
                        {
                            hangCount[cpu.HangSX] = 1;
                        }
                    }
                }
            }
            return hangCount.OrderBy(h => h.Value).First().Key;
        }
        //5. Tìm hãng có nhiều, ít RAM sử dụng nhất
        public string TimHangCoNhieuRAM()
        {
            var hangCount = new Dictionary<string, int>();
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection())
                {
                    if (tb is RAM ram)
                    {
                        if (hangCount.ContainsKey(ram.HangSX))
                        {
                            hangCount[ram.HangSX]++;
                        }
                        else
                        {
                            hangCount[ram.HangSX] = 1;
                        }
                    }
                }
            }
            return hangCount.OrderByDescending(h => h.Value).First().Key;
        }

        public string TimHangCoItRAM()
        {
            var hangCount = new Dictionary<string, int>();
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection())
                {
                    if (tb is RAM ram)
                    {
                        if (hangCount.ContainsKey(ram.HangSX))
                        {
                            hangCount[ram.HangSX]++;
                        }
                        else
                        {
                            hangCount[ram.HangSX] = 1;
                        }
                    }
                }
            }
            return hangCount.OrderBy(h => h.Value).First().Key;
        }
        //6. Sắp xếp danh sách máy tính theo: số lượng thiết bị, giá thiết bị, giá CPU, giá RAM, số lượng CPU, số lượng RAM
        public void SapXepTheoSoLuongThietBi()
        {
            collection = collection.OrderBy(m => m.GetCollection().Count).ToList();
        }

        public void SapXepTheoGiaThietBi()
        {
            collection = collection.OrderBy(m => m.TongGia()).ToList();
        }

        public void SapXepTheoGiaCPU()
        {
            collection = collection.OrderBy(m => m.GetCollection().OfType<CPU>().Sum(cpu => cpu.Gia)).ToList();
        }

        public void SapXepTheoGiaRAM()
        {
            collection = collection.OrderBy(m => m.GetCollection().OfType<RAM>().Sum(ram => ram.Gia)).ToList();
        }

        public void SapXepTheoSoLuongCPU()
        {
            collection = collection.OrderBy(m => m.GetCollection().OfType<CPU>().Count()).ToList();
        }

        public void SapXepTheoSoLuongRAM()
        {
            collection = collection.OrderBy(m => m.GetCollection().OfType<RAM>().Count()).ToList();
        }
        //7. Hiển thị danh sách máy tính theo hãng sản xuất
        public void HienThiTheoHangSX()
        {
            var hangGroup = collection
                .SelectMany(m => m.GetCollection())
                .GroupBy(tb => tb.HangSX)
                .OrderBy(g => g.Key);

            foreach (var group in hangGroup)
            {
                Console.WriteLine($"Hãng: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }
        //8. Xóa tất cả máy tính có CPU theo hãng nào đó
        public void XoaMayTinhCoCPUHang(string hang)
        {
            collection.RemoveAll(m => m.GetCollection().Any(tb => tb is CPU && tb.HangSX == hang));
        }
        //9. Cập nhật máy tính nếu CPU của Intel thì giá là 700
        public void CapNhatGiaCPUIntel()
        {
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection())
                {
                    if (tb is CPU cpu && cpu.HangSX == "Intel")
                    {
                        cpu.Gia = 700;
                    }
                }
            }
        }
        // 10. Tìm máy tính theo dung lượng RAM và hãng sản xuất nào đó
        public List<MayTinh> TimMayTinhTheoDungLuongRAMVaHang(float dungLuong, string hang)
        {
            return collection.Where(m => m.GetCollection().OfType<RAM>().Any(ram => ram.DungLuong == dungLuong && ram.HangSX == hang)).ToList();
        }

        // 11. Tìm máy tính có dung lượng RAM cao nhất, thấp nhất
        public MayTinh TimMayTinhCoDungLuongRAMCaoNhat()
        {
            return collection.OrderByDescending(m => m.GetCollection().OfType<RAM>().Max(ram => ram.DungLuong)).FirstOrDefault();
        }

        public MayTinh TimMayTinhCoDungLuongRAMThapNhat()
        {
            return collection.OrderBy(m => m.GetCollection().OfType<RAM>().Min(ram => ram.DungLuong)).FirstOrDefault();
        }

        // 12. Tìm máy tính có dung lượng RAM lớn hơn x
        public List<MayTinh> TimMayTinhCoDungLuongRAMLonHon(float dungLuong)
        {
            return collection.Where(m => m.GetCollection().OfType<RAM>().Any(ram => ram.DungLuong > dungLuong)).ToList();
        }

        // 13. Xóa tất cả máy tính có dung lượng x
        public void XoaMayTinhCoDungLuongRAM(float dungLuong)
        {
            collection.RemoveAll(m => m.GetCollection().OfType<RAM>().Any(ram => ram.DungLuong == dungLuong));
        }

        // 14. Cập nhật tất cả máy tính có dung lượng là x thì đổi sang dung lượng y
        public void CapNhatDungLuongRAM(float dungLuongCu, float dungLuongMoi)
        {
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection().OfType<RAM>())
                {
                    if (tb.DungLuong == dungLuongCu)
                    {
                        tb.DungLuong = dungLuongMoi;
                    }
                }
            }
        }

        // 15. Lưu dữ liệu hiện tại vào tập tin mới theo đúng cấu trúc của dữ liệu hiện tại
        public void LuuDuLieu(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in collection)
                {
                    sw.WriteLine(item);
                }
            }
        }

        // 16. Sắp xếp danh sách máy tính theo chiều tăng giảm của dung lượng RAM máy tính
        public void SapXepTheoDungLuongRAM(bool tangDan)
        {
            if (tangDan)
            {
                collection = collection.OrderBy(m => m.GetCollection().OfType<RAM>().Sum(ram => ram.DungLuong)).ToList();
            }
            else
            {
                collection = collection.OrderByDescending(m => m.GetCollection().OfType<RAM>().Sum(ram => ram.DungLuong)).ToList();
            }
        }

        // 17. Tìm hãng sản xuất sản xuất RAM có dung lượng cao nhất, thấp nhất
        public string TimHangSanXuatRAMCoDungLuongCaoNhat()
        {
            return collection.SelectMany(m => m.GetCollection().OfType<RAM>())
                             .OrderByDescending(ram => ram.DungLuong)
                             .FirstOrDefault()?.HangSX;
        }

        public string TimHangSanXuatRAMCoDungLuongThapNhat()
        {
            return collection.SelectMany(m => m.GetCollection().OfType<RAM>())
                             .OrderBy(ram => ram.DungLuong)
                             .FirstOrDefault()?.HangSX;
        }

        // 18. Thực hiện từ câu 1 đến 8 cho thuộc tính tốc độ của CPU
        // 18a. Tìm máy tính có CPU tốc độ cao nhất, thấp nhất
        public MayTinh TimMayTinhTheoTocDoCPU(bool caoNhat)
        {
            MayTinh result = null;
            float bestSpeed = caoNhat ? float.MinValue : float.MaxValue;
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection().OfType<CPU>())
                {
                    if ((caoNhat && tb.TocDo > bestSpeed) || (!caoNhat && tb.TocDo < bestSpeed))
                    {
                        bestSpeed = tb.TocDo;
                        result = item;
                    }
                }
            }
            return result;
        }

        // 18b. Tìm hãng có nhiều, ít CPU tốc độ cao nhất, thấp nhất
        public string TimHangCoNhieuCPUTocDoCaoNhat()
        {
            var hangCount = new Dictionary<string, int>();
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection().OfType<CPU>())
                {
                    if (hangCount.ContainsKey(tb.HangSX))
                    {
                        hangCount[tb.HangSX]++;
                    }
                    else
                    {
                        hangCount[tb.HangSX] = 1;
                    }
                }
            }
            return hangCount.OrderByDescending(h => h.Value).First().Key;
        }

        public string TimHangCoItCPUTocDoThapNhat()
        {
            var hangCount = new Dictionary<string, int>();
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection().OfType<CPU>())
                {
                    if (hangCount.ContainsKey(tb.HangSX))
                    {
                        hangCount[tb.HangSX]++;
                    }
                    else
                    {
                        hangCount[tb.HangSX] = 1;
                    }
                }
            }
            return hangCount.OrderBy(h => h.Value).First().Key;
        }

        // 18c. Sắp xếp danh sách máy tính theo tốc độ CPU
        public void SapXepTheoTocDoCPU(bool tangDan)
        {
            if (tangDan)
            {
                collection = collection.OrderBy(m => m.GetCollection().OfType<CPU>().Sum(cpu => cpu.TocDo)).ToList();
            }
            else
            {
                collection = collection.OrderByDescending(m => m.GetCollection().OfType<CPU>().Sum(cpu => cpu.TocDo)).ToList();
            }
        }

        // 18d. Hiển thị danh sách máy tính theo tốc độ CPU
        public void HienThiTheoTocDoCPU()
        {
            var tocDoGroup = collection
                .SelectMany(m => m.GetCollection().OfType<CPU>())
                .GroupBy(cpu => cpu.TocDo)
                .OrderBy(g => g.Key);

            foreach (var group in tocDoGroup)
            {
                Console.WriteLine($"Tốc độ: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine();
            }
        }

        // 18e. Xóa tất cả máy tính có CPU theo tốc độ nào đó
        public void XoaMayTinhCoCPUTocDo(float tocDo)
        {
            collection.RemoveAll(m => m.GetCollection().OfType<CPU>().Any(cpu => cpu.TocDo == tocDo));
        }

        // 18f. Cập nhật máy tính nếu CPU có tốc độ là x thì đổi sang tốc độ y
        public void CapNhatTocDoCPU(float tocDoCu, float tocDoMoi)
        {
            foreach (var item in collection)
            {
                foreach (var tb in item.GetCollection().OfType<CPU>())
                {
                    if (tb.TocDo == tocDoCu)
                    {
                        tb.TocDo = tocDoMoi;
                    }
                }
            }
        }
        //19. Viết thực đơn gọi các chức năng trên (Program.cs)
    }
}
