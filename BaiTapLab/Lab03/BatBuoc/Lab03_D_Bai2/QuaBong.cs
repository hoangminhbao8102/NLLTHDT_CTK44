using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai2
{
    public class QuaBong
    {
        private int _banKinh;
        private int _x, _y, _z;

        public int R
        {
            get => _banKinh;
            set => _banKinh = value;
        }

        public int X
        {
            get => _x;
            set => _x = value;
        }

        public int Y
        {
            get => _y;
            set => _y = value;
        }

        public int Z
        {
            get => _z;
            set => _z = value;
        }

        public QuaBong()
        {
            _x = _y = _z = _banKinh = 0;
        }

        public QuaBong(int x, int y, int z, int r)
        {
            _x = x;
            _y = y;
            _z = z;
            _banKinh = r;
        }

        public void DichChuyen(int dx, int dy, int dz)
        {
            _x += dx;
            _y += dy;
            _z += dz;
        }

        public bool DungDo(QuaBong ball)
        {
            double distance = Math.Sqrt(Math.Pow(_x - ball._x, 2) + Math.Pow(_y - ball._y, 2) + Math.Pow(_z - ball._z, 2));
            return distance <= (_banKinh + ball._banKinh);
        }

        public double TinhTheTich()
        {
            return (4 / 3) * Math.PI * Math.Pow(_banKinh, 3);
        }

        public override string ToString()
        {
            return $"Ball at ({_x}, {_y}, {_z}) with radius {_banKinh}";
        }
    }
}
