using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DamperDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using damper_dan_client.Interfaces;
using damper_dan_client.Models;

namespace damper_dan_client.Services {
    public class BuildingService : GeoCoder {


        public async Task<LatLong> GetBuildingLatLong () {
            // LatLong
            LatLong ltlng = new LatLong();
            return ltlng;
        }
    }
}