using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class repairhistory {

        public int id { get; set; }
        public dampertest dampertest { get; set; }
        public DateTime repairDate { get; set; }
        public String description { get; set; }

        

    }
}