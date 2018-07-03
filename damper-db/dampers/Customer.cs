using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DamperDB {

    public class Customer {

        public int id {get;set;}
        public String customerName {get;set;}
        public bool isenabled {get;set;}
        public List<Customer> customers {get;set;}
        public List<User> users {get;set;}
        public List<Dampertest> dampertests  {get;set;}
        public List<Building> buildings {get;set;}

        

    }
}