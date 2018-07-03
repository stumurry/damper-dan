using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using DamperDB;

namespace damper_dan_client.Controllers {

    // Joint Commissions Inpector
    [Route ("api/jacho")]
    public class JachoController : Controller {

        [Route ("dampers")]
        public List<string> GetDampers () {

            using (var ctx = new DamperContext ()) {
                // var l = ctx.Dampertest.ToList();
                // Console.WriteLine(l);

            }

            return new List<string> () {
            "Hello",
            "World"
            };
        }
    }
}