using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai03_CacLopCollection
{
    class ViDuVeDictionary
    {
        public void ThongKeKyTu(string cau)
        {
            Dictionary<char, int> duLieuTk = new Dictionary<char, int>();

            foreach (char kyTu in cau)
            {
                if (duLieuTk.ContainsKey(kyTu))
                {
                    duLieuTk[kyTu]++;
                }
                else 
                {
                    duLieuTk.Add(kyTu, 1);
                }
            }
            XuatKetQua(duLieuTk);
        }

        private void XuatKetQua(Dictionary<char, int> ketQuaTk)
        {
            foreach (KeyValuePair<char, int> cap in ketQuaTk)
            {
                Console.WriteLine("{0} : {1}", cap.Key, cap.Value);
            }
        }
    }
}
