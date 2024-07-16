using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MayTinh
    {
        private List<IThietBi> collection = new List<IThietBi>();

        public List<IThietBi> GetCollection()
        {
            return collection;
        }

        public void Them(IThietBi tb)
        {
            // Ví dụ: kiểm tra sự trùng lặp trước khi thêm
            if (!collection.Contains(tb))
            {
                collection.Add(tb);
            }
        }

        public bool XoaThietBi(IThietBi tb)
        {
            return collection.Remove(tb);
        }

        public float TongGia()
        {
            return collection.Sum(item => item.Gia);
        }

        public override string ToString()
        {
            StringBuilder s = new StringBuilder();
            foreach (var item in collection)
            {
                s.AppendLine(item.ToString());
            }
            s.AppendLine($"Tổng giá là: {TongGia():C}");  // C: định dạng tiền tệ
            return s.ToString();
        }

        public int DemTheoHang(string hang)
        {
            return collection.Count(item => item.HangSX == hang);
        }

        public List<string> TimDanhSachHang()
        {
            // Sử dụng HashSet để loại bỏ trùng lặp
            HashSet<string> kq = new HashSet<string>();
            foreach (var item in collection)
            {
                kq.Add(item.HangSX);
            }
            return kq.ToList();
        }

        public List<IThietBi> TimTheoModel(string model)
        {
            return collection.Where(tb => tb.Model == model).ToList();
        }
    }
}
