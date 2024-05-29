using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai3
{
    public class Vector
    {
        private double x;
        private double y;

        public double DoDai
        {
            get { return Math.Sqrt(x * x + y * y); }
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector Cong(Vector other)
        {
            return new Vector(x + other.x, y + other.y);
        }

        public double TichVoHuong(Vector v)
        {
            return x * v.x + y * v.y;
        }

        public double TinhGocHopVoiOx()
        {
            return Math.Atan2(y, x) * (180 / Math.PI);
        }

        public double HeSoGoc()
        {
            return y / x;
        }

        public override string ToString()
        {
            return $"Vector({x}, {y})";
        }

        public static double GocGiuaHaiVector(Vector u, Vector v)
        {
            double tichVoHuong = u.TichVoHuong(v);
            double doDaiU = u.DoDai;
            double doDaiV = v.DoDai;
            return Math.Acos(tichVoHuong / (doDaiU * doDaiV)) * (180 / Math.PI);
        }

        public static bool KiemTraSongSong(Vector u, Vector v)
        {
            return Math.Abs(u.X * v.Y - v.X * u.Y) < 1e-10;
        }

        public static bool CungChieu(Vector u, Vector v)
        {
            return KiemTraSongSong(u, v) && (u.X * v.X + u.Y * v.Y > 0);
        }
    }
}
