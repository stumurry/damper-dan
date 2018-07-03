using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Pictures {

        public int id { get; set; }
        public Dampertest dampertest { get; set; }
        public String name { get; set; }
        public byte[] image { get; set; }

    }
}