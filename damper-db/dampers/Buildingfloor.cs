using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Buildingfloor {

        public int id { get; set; }
        public User user { get; set; }
        public Building building { get; set; }
        public String floorName { get; set; }
        public int sequenceNum { get; set; }
        public List<Dampertest> dampertests { get; set; }
        public List<Userlog> userlogs { get; set; }

    }
}