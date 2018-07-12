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

    // Joint Commissions Inpector
    [Route ("api/jacho")]
    [EnableCors("AllowSpecificOrigin")]
    public class JachoController : Controller, Dampers {

        private DamperContext ctx;
        public JachoController (DamperContext ctx) {
            this.ctx = ctx;
        }

        [Route ("dampers")]
        public async Task<List<Dampertest>> GetDampers () {
            Console.WriteLine ("Getting Dampers for /jacho...");
            return await ctx.Dampertest.Take (3).ToListAsync ();
        }
    }
}