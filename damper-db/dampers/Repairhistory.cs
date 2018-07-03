using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Repairhistory {

        public int id { get; set; }
        public Dampertest dampertest { get; set; }
        public DateTime repairDate { get; set; }
        public String description { get; set; }

        

    }
}