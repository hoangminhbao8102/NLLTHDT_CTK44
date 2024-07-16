using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public static class ThietBiFactory
    {
        public static IThietBi CreateFromCSV(string component)
        {
            // Phân tích component để xác định loại thiết bị và các thuộc tính
            string[] parts = component.Trim().Split(',');
            if (parts.Length == 0)
            {
                return null;
            }

            string type = parts[0].Trim();
            string hangSX = parts[1].Trim();
            float gia = float.Parse(parts[2].Trim());
            string model = parts.Length > 3 ? parts[3].Trim() : "";
            int namSanXuat = parts.Length > 4 ? int.Parse(parts[4].Trim()) : DateTime.Now.Year; // Giả định năm sản xuất mặc định là năm hiện tại

            switch (type)
            {
                case "CPU":
                    return new CPU(hangSX, gia, 0, model, namSanXuat); // Giả định tốc độ CPU là 0 nếu không được chỉ định
                case "RAM":
                    float dungLuong = parts.Length > 5 ? float.Parse(parts[5].Trim()) : 0; // Giả định dung lượng RAM
                    return new RAM(hangSX, gia, model, namSanXuat, dungLuong);
                default:
                    return null;
            }
        }
    }
}
