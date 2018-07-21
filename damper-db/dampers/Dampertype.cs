using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class dampertype {

        public int id { get; set; }
        public String aliasId { get; set; }
        public String typeName { get; set; }
        public bool isenabled { get; set; }
        // public List<Dampertest> dampertests { get; set; }

    }
}