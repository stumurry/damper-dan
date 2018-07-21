using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class site {

        public int id { get; set; }
        public String alias { get; set; }
        public String description { get; set; }
        public String name { get; set; }
        // public customer customer { get; set; }

    }
}