using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Project {

        public int id { get; set; }
        public Customer customer { get; set; }
        public int aggregatedCount { get; set; }
        public String projectNum { get; set; }
        public String projectName { get; set; }
        public DateTime dateReceived { get; set; }
        public DateTime dateDue { get; set; }
        public int totalEstimate { get; set; }
        public int status { get; set; }
        public String lastModifiedTs { get; set; }
        public DateTime userLastModified { get; set; }
        public String room { get; set; }
        public String comments { get; set; }
        public Boolean isEnabled { get; set; }
        public String location { get; set; }
        public String contact { get; set; }
        public List<Userlog> userlogs { get; set; }
        public List<Dampertest> dampertests { get; set; }

        

    }
}