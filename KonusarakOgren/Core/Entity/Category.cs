using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Category:Base
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public string Approval { get; set; }
        public int Rows { get; set; }
    }
}
