using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace damper_dan_client.Controllers {

    // Joint Commissions Inpector
    [Route("api/jacho")]
    public class JachoController : Controller {

        [Route("dampers")]
        public List<string> GetDampers() {
            return new List<string>() {
                "Hello", "World"
            };
        }
    }
}