using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class MayTinh
    {
        List<IThietBi> collection = new List<IThietBi>();
        public List<IThietBi> GetCollection()
        {
            return collection;
        }
        public void Them(IThietBi tb)
        {
            collection.Add(tb);
        }
        public float TongGia()
        {
            float tong = 0;
            foreach (var item in collection)
            {
                tong += item.Gia;
            }
            return tong;
        }
        public override string ToString()
        {
            string s = "";
            foreach (var item in collection)
            {
                s += item + "\n";
            }
            s += "; tổng giá là " + TongGia();
            return s;
        }
        public int DemTheoHang(string hang)
        {
            int dem = 0;
            foreach (var item in collection)
            {
                if (item.HangSX == hang) dem++;
            }
            return dem;
        }
        public List<string> TimDanhSachHang()
        {
            List<string> kq = new List<string>();
            foreach (var item in collection)
            {
                kq.Add(item.HangSX);
            }
            return kq;
        }
    }
}
