﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Class
    {
        public int ClassId { get; set; }
        public int AccessLevel {get; set;}
        public string NameClass { get; set; }
        public List<User> Users { get; set; }
    }
}
