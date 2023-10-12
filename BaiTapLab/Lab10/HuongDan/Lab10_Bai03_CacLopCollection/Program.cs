using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai03_CacLopCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ViDuVeArrayList viDuVeArrayList = new ViDuVeArrayList();

            viDuVeArrayList.TruyCapPhanTu();

            viDuVeArrayList.CacHamXoa();

            ViDuVeLopList viDuVeLopList = new ViDuVeLopList();

            viDuVeLopList.TruyCapPhanTu();

            viDuVeLopList.CacHamXoa();

            ViDuVeLopStack vdNganXep = new ViDuVeLopStack();

            uint so = 1000, coSo = 16;

            string ketQua = vdNganXep.DoiCoSo(so, coSo);

            Console.WriteLine("{0}(10) = {1}({2})", so, coSo, ketQua);

            ViDuVeLopQueue vdHangDoi = new ViDuVeLopQueue();
            so = 1234500;

            int len = so.ToString().Length;

            uint daoSo = vdHangDoi.DaoNguocSo(so);

            string chuoiSo = daoSo.ToString().PadLeft(len, '0');

            Console.WriteLine("{0} => {1} => {2}", so, daoSo, chuoiSo);

            ViDuVeDictionary vdTuDien = new ViDuVeDictionary();
            string cau = "Kho@ C0ng nghE Thong TiN - Truong d@i hoc Da Lat";
            vdTuDien.ThongKeKyTu(cau);

            Console.ReadKey();
        }
    }
}
