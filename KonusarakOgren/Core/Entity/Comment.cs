using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Comment: Base
    {
        public int UserId{ get; set; }
        public int ProductId{ get; set; }
        public int CommentContent{ get; set; }
    }
}
