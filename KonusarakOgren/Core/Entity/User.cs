﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class User:Base
    {
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
