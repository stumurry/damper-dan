using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class damperstatus {

        public int id { get; set; }
        public String status { get; set; }
        public String substatus { get; set; }
        public bool isenabled { get; set; }
        // public List<Dampertest> dampertests  { get; set; }

    }
}