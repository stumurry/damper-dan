using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class User {

        public int id { get; set; }
        public Customer customer { get; set; }
        public Role role { get; set; }
        public String userName { get; set; }
        public String password { get; set; }
        public String email { get; set; }
        public String firstName { get; set; }
        public String lastName { get; set; }
        public String address1 { get; set; }
        public String address2 { get; set; }
        public String city { get; set; }
        public String state { get; set; }
        public String zip { get; set; }
        public String phone { get; set; }
        public DateTime dateCreatedTs { get; set; }
        public DateTime lastModifiedTs { get; set; }
        public bool isenabled { get; set; }
        public String sessionId { get; set; }
        public List<Userlog> userlogs { get; set; }
        public List<Dampertest> dampertests  { get; set; }
        public List<Buildingfloor> buildingfloors { get; set; }
        public String customers { get; set; }
        public String includebuildingids { get; set; }

       

    }
}