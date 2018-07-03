
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Role {

        public int id { get; set; }
        public String role { get; set; }
        public List<User> users  { get; set; }

        
    }
}