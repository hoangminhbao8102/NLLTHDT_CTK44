using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai1
{
    public class BoDocFile
    {
        private TextReader _reader;

        public BoDocFile(string duongdan)
        {
            if (!File.Exists(duongdan))
            {
                throw new FileNotFoundException("File không tồn tại", duongdan);
            }
            _reader = new StreamReader(duongdan);
        }

        public string DocMotTu()
        {
            return _reader.ReadLine();
        }

        public void DongKetNoi()
        {
            _reader.Close();
        }
    }
}
