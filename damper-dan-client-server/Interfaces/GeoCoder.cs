using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DamperDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using damper_dan_client.Models;

namespace damper_dan_client.Interfaces {
    public interface GeoCoder {
        Task<LatLong> GetBuildingLatLong ();
    }
}