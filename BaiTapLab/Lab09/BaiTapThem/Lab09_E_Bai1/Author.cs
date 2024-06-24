using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_E_Bai1
{
    public class Author : Participant
    {
        public List<Paper> Papers { get; set; } = new List<Paper>();
    }
}
