using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_E_Bai1
{
    public class Paper
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Topic { get; set; }
        public List<Author> Authors { get; set; } = new List<Author>();
        public string MainAuthorId { get; set; }
        public int Id { get; set; }
        public List<string> Reviews { get; set; } = new List<string>();
        public int AcceptedCount { get; set; } = 0;
    }
}
