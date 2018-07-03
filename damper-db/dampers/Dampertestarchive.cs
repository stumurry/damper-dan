using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Dampertestarchive {

        public int id { get; set; }
        public String aliasId { get; set; }
        public int buildingId { get; set; }
        public int typeId { get; set; }
        public int sizel { get; set; }
        public int sizew { get; set; }
        public String system { get; set; }
        public String systemtype { get; set; }
        public int materialId { get; set; }
        public int floorId { get; set; }
        public int statusId { get; set; }
        public String location { get; set; }
        public String sublocation { get; set; }
        public int dampernumber { get; set; }
        public int series { get; set; }
        public DateTime dateTestedTs { get; set; }
        public DateTime repairDate { get; set; }
        public String comments { get; set; }
        public int tester { get; set; }
        public bool isenabled { get; set; }
        public int customerId { get; set; }
        public DateTime nextTestDate { get; set; }
        public String occupancy { get; set; }
        public String specialProcedures { get; set; }
        public int xposition { get; set; }
        public int yposition { get; set; }
        public int dampertestId { get; set; }

    }
}