using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using damper_dan_client.Interfaces;
using DamperDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace damper_dan_client.Controllers {

    [Route ("api/facilities")]
    public class FacilitiesController : Controller, Dampers {

        public DamperContext ctx;

        public FacilitiesController (DamperContext ctx) {
            this.ctx = ctx;
        }

        [Route ("dampers")]
        public async Task<List<Dampertest>> GetDampers () {
            return await ctx.Dampertest.Take (3).ToListAsync ();
        }

    }

}