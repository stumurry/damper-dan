using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class dampermaterial {
        
        public int id { get; set; }
        public String materialName { get; set; }
        public String description { get; set; }
        public bool isenabled { get; set; }
        // public List<Dampertest> dampertests  { get; set; }

    }
}