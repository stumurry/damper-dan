using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DamperDB {

    public class Commenthistory {

        public int id { get; set; }
        public Dampertest dampertest { get; set; }
        public Damperstatus damperstatus { get; set; }
        public DateTime dateTestedTs { get; set; }
        public DateTime cycleDate { get; set; }
        public String comments { get; set; }

        

    }
}