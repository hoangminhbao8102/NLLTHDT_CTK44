using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai1
{
    public class BoThongKe
    {
        private Dictionary<string, int> _ketQuaTk;

        public BoThongKe()
        {
            _ketQuaTk = new Dictionary<string, int>();
        }

        public void ThongKe(string tapTin)
        {
            try
            {
                BoDocFile docFile = new BoDocFile(tapTin);
                string dong;
                while ((dong = docFile.DocMotTu()) != null)
                {
                    string[] tu = dong.Split(new char[] { ' ', ',', '.', ';', ':', '-', '_', '/' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (var t in tu)
                    {
                        if (_ketQuaTk.ContainsKey(t))
                        {
                            _ketQuaTk[t]++;
                        }
                        else
                        {
                            _ketQuaTk[t] = 1;
                        }
                    }
                }
                docFile.DongKetNoi();
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Lỗi: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Lỗi không xác định: " + e.Message);
            }
        }

        public void XuatKetQua()
        {
            foreach (var kvp in _ketQuaTk)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
