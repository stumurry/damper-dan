using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Building {

        public int id { get; set; }
        public Customer customer { get; set; }
        public Site site { get; set; }
        public String aliasId { get; set; }
        public String buildingName { get; set; }
        public String address1 { get; set; }
        public String address2 { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
        public String poc { get; set; }
        public String pocPhone { get; set; }
        public int ho { get; set; }
        public int bo { get; set; }
        public DateTime lastDateTestedTs { get; set; }
        public bool isenabled { get; set; }
        public List<Userlog> userlogs { get; set; }
        public List<Buildingfloor> buildingfloors { get; set; }
        public List<Dampertest> dampertests { get; set; }
        public String occupancy { get; set; }

    }

}