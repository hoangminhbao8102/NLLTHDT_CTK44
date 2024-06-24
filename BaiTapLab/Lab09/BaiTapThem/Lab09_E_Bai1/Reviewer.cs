using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_E_Bai1
{
    public class Reviewer : Participant
    {
        public List<string> Expertise { get; set; } = new List<string>();
        public int ReviewCount { get; set; } = 0; // Đếm số bài đã review
    }
}
