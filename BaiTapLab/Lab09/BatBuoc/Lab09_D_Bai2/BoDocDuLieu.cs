using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai2
{
    public delegate void XuLySo(string chuoiSo);

    public class BoDocDuLieu
    {
        public event XuLySo TimThaySo;

        public void Doc(string duongDan)
        {
            // Đọc từng dòng trong file
            foreach (var line in File.ReadAllLines(duongDan))
            {
                // Xử lý từng từ trong dòng
                var words = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var word in words)
                {
                    // Nếu từ là chuỗi số, phát sinh sự kiện
                    if (LaChuoiSo(word))
                    {
                        PhatSinhSuKien(word);
                    }
                }
            }
        }

        protected virtual void PhatSinhSuKien(string chuoiSo)
        {
            // Kích hoạt event với chuỗi số tìm được
            TimThaySo?.Invoke(chuoiSo);
        }

        private bool LaChuoiSo(string chuoi) 
        {
            // Kiểm tra xem chuỗi có thể chuyển đổi thành số hay không
            return double.TryParse(chuoi, out _);
        }
    }
}
