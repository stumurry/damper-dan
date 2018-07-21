using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class dampercomment {

        public int id { get; set; }
        public String comment { get; set; }
        public bool isenabled { get; set; }

    }
}