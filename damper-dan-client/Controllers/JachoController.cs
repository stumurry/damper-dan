using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DamperDB;
using damper_dan_client.Interfaces;

namespace damper_dan_client.Controllers {

    // Joint Commissions Inpector
    [Route ("api/jacho")]
    public class JachoController : Controller, Dampers {

        private DamperContext ctx;
        public JachoController (DamperContext ctx) {
            this.ctx = ctx;
        }

        [Route ("dampers")]
        public List<Dampertest> GetDampers () {
            return ctx.Dampertest.Take(3).ToList();
        }
    }
}