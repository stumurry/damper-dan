using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DamperDB;
using Microsoft.AspNetCore.Mvc;

namespace damper_dan_client.Controllers {

    // Joint Commissions Inpector
    [Route ("api/jacho")]
    public class JachoController : Controller {

        private DamperContext ctx;
        public JachoController (DamperContext ctx) {
            this.ctx = ctx;
        }

        [Route ("dampers")]
        public List<Dampertest> GetDampers () {
            return ctx.Dampertest.ToList ();
        }
    }
}