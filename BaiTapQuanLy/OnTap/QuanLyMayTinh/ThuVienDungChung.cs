using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class ThuVienDungChung
    {
        private static List<string> dsHang = new List<string>();
        private static object lockObject = new object();

        public static void Them(string hang)
        {
            lock (lockObject)
            {
                if (!dsHang.Contains(hang))
                {
                    dsHang.Add(hang);
                }
            }
        }

        public static bool Xoa(string hang)
        {
            lock (lockObject)
            {
                return dsHang.Remove(hang);
            }
        }

        public static bool KiemTraTonTai(string hang)
        {
            lock (lockObject)
            {
                return dsHang.Contains(hang);
            }
        }

        public static void LuuRaFile(string tenFile)
        {
            lock (lockObject)
            {
                File.WriteAllLines(tenFile, dsHang);
            }
        }

        public static void DocTuFile(string tenFile)
        {
            lock (lockObject)
            {
                dsHang = File.ReadAllLines(tenFile).ToList();
            }
        }

    }
}
