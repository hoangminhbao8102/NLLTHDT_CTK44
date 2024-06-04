using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai4
{
    public class Computer
    {
        private MainBoard _board;
        private CDROM _cdRom;
        private CPU _cpu;
        private HDD _hdd;        
        private RAM _ram;

        public MainBoard Board 
        { 
            set { _board = value; } 
        }
        public CDROM CdRom
        {
            set { _cdRom = value; }
        }
        public CPU Cpu
        {
            set { _cpu = value; }
        }
        public HDD Hdd
        {
            set { _hdd = value; }
        }
        public RAM Ram
        {
            set { _ram = value; }
        }

        public Computer()
        {
            _board = new MainBoard();
            _cdRom = new CDROM();
            _cpu = new CPU();
            _hdd = new HDD();
            _ram = new RAM();
        }

        public int TinhTongGia()
        {
            return _board.Gia + _cdRom.Gia + _cpu.Gia + _hdd.Gia + _ram.Gia;
        }

        public override string ToString()
        {
            return $"Computer:\n{_board}\n{_cdRom}\n{_cpu}\n{_hdd}\n{_ram}";
        }
    }
}
