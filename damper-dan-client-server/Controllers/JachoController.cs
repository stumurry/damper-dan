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
        public async Task<List<dampertest>> GetDampers () {
            Console.WriteLine ("Getting Dampers for /jacho...");
            return await ctx.Dampertest.Take (3).ToListAsync ();
        }

        [Route ("building/{building_id}/dampers")]
        public async Task<List<dampertest>> GetDampersByBuilding(int building_id) {
            Console.WriteLine ("Getting dampers by floor for /jacho...");
            return await ctx.Dampertest.Where(s => s.building_id == building_id).ToListAsync ();
        }

        [Route ("buildings")]
        public async Task<List<building>> GetBuildings() {
            Console.WriteLine ("Getting Buildings for /jacho...");
            return await ctx.Building.Take (3).ToListAsync ();
        }

        [Route ("floors")]
        public async Task<List<buildingfloor>> GetFloorsByBuilding(int building_id){
            Console.WriteLine ("Getting Floors for /jacho...");
            return await ctx.Buildingfloor.Where(s => s.building_id == building_id).ToListAsync ();
        }

        [Route ("floors/{floor_id}/dampers")]
        public async Task<List<dampertest>> GetDampersByFloor(int floor_id){
            Console.WriteLine ("Getting dampers by floor for /jacho...");
            return await ctx.Dampertest.Where(s => s.floor_id == floor_id).ToListAsync ();
        }
    }
}