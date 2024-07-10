using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class DanhSachMayTinh
    {
        List<MayTinh> collection = new List<MayTinh>();
        public void NhapTuFile()
        {
            string path = @"data.csv";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null)
            {
                // CPU,Intel,300 * CPU,Intel,300 * RAM,SamSung,50 * HDD,Seagate,500
                MayTinh m = new MayTinh();
                string[] s = str.Split('*');
                foreach (string item in s)
                {
                    if (item.IndexOf("CPU") == 0)
                        m.Them(new CPU(item));
                    if (item.IndexOf("RAM") == 0)
                        m.Them(new RAM(item));
                    if (item.IndexOf("HDD") == 0)
                        m.Them(new HDD(item));
                }
                Them(m);
            }
        }
        public void Them(MayTinh mt)
        {
            collection.Add(mt);
        }
        public DanhSachMayTinh TimMayTinhCoGiaCaoNhat()
        {
            float max = TimGiaCaoNhat();
            DanhSachMayTinh kq = new DanhSachMayTinh();
            foreach (var item in collection)
            {
                if (item.TongGia() == max)
                    kq.Them(item);
            }
            return kq;
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
        //10. Tìm máy tính theo dung lượng RAM và hãng sản xuất nào đó
        //11. Tìm máy tính có dung lượng RAM cao nhất, thấp nhất
        //12. Tìm máy tính có dung lượng RAM lớn hơn x
        //13. Xóa tất cả máy tính có dung lượng x
        //14. Cập nhật tất cả máy tính có dung lượng là x thì đổi sang dung lượng y
        //15. Lưu dữ liệu hiện tại vào tập tin mới theo đúng cấu trúc của dữ liệu hiện tại
        //16. Sắp xếp danh sách máy tính theo chiều tăng giảm của dung lượng RAM máy tính
        //17. Tìm hãng sản xuất sản xuất Ram có dung lượng cao nhất, thấp nhất
        //18. Thực hiện từ câu 1 đến 8 cho thuộc tính tốc độ của CPU
        //19. Viết thực đơn gọi các chức năng trên (Program.cs)
    }
}
