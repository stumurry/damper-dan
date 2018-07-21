using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DamperDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace damper_dan_client.Models {

    public class LatLong {
        public int BuildingID { get; set; }
        public float Lat { get; set; }
        public float Lng { get; set; }
    }
}