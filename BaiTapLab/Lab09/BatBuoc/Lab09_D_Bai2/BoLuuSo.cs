using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai2
{
    public class BoLuuSo
    {
        private string _duongDan;
        private StreamWriter _writer;

        public BoLuuSo(string duongDan) 
        {
            // Lưu đường dẫn và mở file để ghi
            _duongDan = duongDan;
            _writer = new StreamWriter(File.Open(_duongDan, FileMode.Append));
        }

        public void DongKetNoi()
        {
            // Đóng và xóa đối tượng StreamWriter
            _writer?.Close();
            _writer?.Dispose();
        }

        public void LuuSo(string chuoiSo)
        {
            // Ghi chuỗi số vào file
            if (_writer != null)
            {
                _writer.WriteLine(chuoiSo);
                _writer.Flush();  // Đảm bảo dữ liệu được ghi ngay lập tức vào file
            }
        }
    }
}
