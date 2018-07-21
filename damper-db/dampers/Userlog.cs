using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System;

namespace DamperDB {

    public class userlog {

        public int id { get; set; }
        // public user user { get; set; }
        // public customer customer { get; set; }
        // public building building { get; set; }
        // public buildingfloor buildingfloor { get; set; }
        public String sessionId { get; set; }
        public DateTime loginTs { get; set; }
        public DateTime logoutTs { get; set; }

    }
}