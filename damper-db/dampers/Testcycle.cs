using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class testcycle {

        public int id { get; set; }
        // public building building { get; set; }
        public String description { get; set; }
        // public customer customer { get; set; }
        public DateTime startdate { get; set; }
        public Boolean complete { get; set; }
        public DateTime finishdate { get; set; }

    }
}