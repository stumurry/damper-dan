using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Testcycle {

        public int id { get; set; }
        public Building building { get; set; }
        public String description { get; set; }
        public Customer customer { get; set; }
        public DateTime startdate { get; set; }
        public Boolean complete { get; set; }
        public DateTime finishdate { get; set; }

    }
}