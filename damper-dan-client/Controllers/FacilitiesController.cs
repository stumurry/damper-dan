using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DamperDB;
using damper_dan_client.Interfaces;

namespace damper_dan_client.Controllers {

    [Route ("api/facilities")]
    public class FacilitiesController : Controller, Dampers {
        
        private DamperContext ctx;
        public FacilitiesController (DamperContext ctx) {
            this.ctx = ctx;
        }

        [Route ("dampers")]
        public List<Dampertest> GetDampers () {
            return ctx.Dampertest.ToList();
        }
        
    }

}