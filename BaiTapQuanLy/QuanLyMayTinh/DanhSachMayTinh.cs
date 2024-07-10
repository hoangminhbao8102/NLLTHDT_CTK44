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
    }
}
