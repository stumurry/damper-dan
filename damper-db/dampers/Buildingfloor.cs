using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Buildingfloor {

        public int id { get; set; }
        // public User user { get; set; }
        public int? user_id {get;set;}
        // public Building building { get; set; }
        public int building_id { get;set;}
        public String floor_name { get; set; }
        public int sequence_num { get; set; }
        // public List<Dampertest> dampertests { get; set; }
        // public List<Userlog> userlogs { get; set; }

    }
}