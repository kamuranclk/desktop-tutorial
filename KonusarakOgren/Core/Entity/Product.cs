using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Product:Base
    {
        public string Name { get; set; }
        public string URL { get; set; }
        public int CategoryId { get; set; }
        public string ShortContent { get; set; }
        public string Contents{ get; set; }
        public string Image{ get; set; }
        public string discount { get; set; }
        public string Approval { get; set; }
        public int Rows { get; set; }

    }
}
