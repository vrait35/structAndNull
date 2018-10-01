using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class PlainShape
    {
        public Nullable<Guid> Id { get; set; }
        public DateTime? CreationDate { get; set; }
        public Point? Point { get; set; }
        public string Description { get; set; }

    }
}
