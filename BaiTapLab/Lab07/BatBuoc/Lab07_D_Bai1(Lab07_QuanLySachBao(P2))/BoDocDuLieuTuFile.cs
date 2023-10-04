using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
{
    public class BoDocDuLieuTuFile : BoDocDuLieu
    {
        private const char SEPERATOR = ',';

        private string _duongDan;

        public BoDocDuLieuTuFile(string path)
        {
            _duongDan = path;
        }

        public override DanhSachTaiLieu DocDuLieu()
        {
            DanhSachTaiLieu danhSach = new DanhSachTaiLieu();

            FileStream stream = new FileStream(_duongDan, FileMode.Open, FileAccess.Read);

            StreamReader reader = new StreamReader(stream);

            string line = reader.ReadLine();

            while (!string.IsNullOrEmpty(line))
            {
                string[] parts = line.Split(SEPERATOR);

                switch (parts[0].ToUpper())
                {
                    case "SACH":
                        Sach cuonSach = new Sach(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                        for (int i = 5; i < parts.Length; i++)
                        {
                            cuonSach.ThemTacGia(parts[i].Trim());
                        }
                        danhSach.Them(cuonSach);
                        break;
                    case "LUANVAN":
                        LuanVan baoCao = new LuanVan(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                        danhSach.Them(baoCao);
                        break;
                    case "BAO":
                        BaoKhoaHoc baiBao = new BaoKhoaHoc(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                        for (int i = 5; i < parts.Length; i++)
                        {
                            baiBao.ThemTacGia(parts[i].Trim());
                        }
                        danhSach.Them(baiBao);
                        break;
                }

                line = reader.ReadLine();
            }
            reader.Close();

            stream.Close();

            return danhSach;
        }
    }
}
