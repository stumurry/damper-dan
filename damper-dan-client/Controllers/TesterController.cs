using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using damper_dan_client.Interfaces;
using DamperDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace damper_dan_client.Controllers {

    // Joint Commissions Inpector
    [Route ("api/tester")]
    public class TesterController : Controller, Dampers {
        public DamperContext ctx;

        public TesterController (DamperContext ctx) {
            this.ctx = ctx;
        }

        [Route ("dampers")]
        public async Task<List<Dampertest>> GetDampers () {

            Console.WriteLine ("Getting Dampers for /tester...");
            return await ctx.Dampertest.Take (3).ToListAsync ();
            
        }
        [Route ("upload")]
        public async Task<List<Dampertest>> PostUpload () {

            Console.WriteLine("Uploading...");

            Console.WriteLine ("Getting Dampers for /tester...");
            return await ctx.Dampertest.Take (3).ToListAsync ();
            
        }
    }
}