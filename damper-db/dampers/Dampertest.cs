using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Dampertest {

        public int id { get; set; }
        public Customer customer { get; set; }
        public Dampertype dampertype { get; set; }
        public Building building { get; set; }
        public Dampermaterial dampermaterial { get; set; }
        public Damperstatus damperstatus { get; set; }
        public Buildingfloor buildingfloor { get; set; }
        public User user { get; set; }
        public String aliasId { get; set; }
        public int sizel { get; set; }
        public int sizew { get; set; }
        public String system { get; set; }
        public String systemtype { get; set; }
        public String location { get; set; }
        public String sublocation { get; set; }
        public int dampernumber { get; set; }
        public int series { get; set; }
        public DateTime dateTestedTs { get; set; }
        public DateTime repairDate { get; set; }
        public String comments { get; set; }
        public bool isenabled { get; set; }
        public DateTime nextTestDate { get; set; }
        public String occupancy { get; set; }
        public String specialProcedures { get; set; }
        public List<Repairhistory> repairhistories  { get; set; }

    }
}