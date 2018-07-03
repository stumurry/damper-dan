using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace DamperDB {

    public class Userlog {

        public int id { get; set; }
        public User user { get; set; }
        public Customer customer { get; set; }
        public Building building { get; set; }
        public Buildingfloor buildingfloor { get; set; }
        public String sessionId { get; set; }
        public DateTime loginTs { get; set; }
        public DateTime logoutTs { get; set; }

    }
}