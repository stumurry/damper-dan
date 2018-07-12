using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using damper_dan_client.Interfaces;
using DamperDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace damper_dan_client.Controllers {

    [Route ("api/facilities")]
    [EnableCors("AllowSpecificOrigin")]
    public class FacilitiesController : Controller, Dampers {

        public DamperContext ctx;

        public FacilitiesController (DamperContext ctx) {
            this.ctx = ctx;
        }

        [Route ("dampers")]
        public async Task<List<Dampertest>> GetDampers () {
            Console.WriteLine ("Getting Dampers for /facilities...");
            return await ctx.Dampertest.Take (3).ToListAsync ();
        }

    }

}