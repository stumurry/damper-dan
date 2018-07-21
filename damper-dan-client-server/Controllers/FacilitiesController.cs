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
        public async Task<List<dampertest>> GetDampers () {
            Console.WriteLine ("Getting Dampers for /jacho...");
            return await ctx.Dampertest.Take (3).ToListAsync ();
        }

        [Route ("building/{building_id}/dampers")]
        public async Task<List<dampertest>> GetDampersByBuilding(int building_id) {
            Console.WriteLine ("Getting dampers by floor for /facilities...");
            return await ctx.Dampertest.Where(s => s.building_id == building_id).ToListAsync ();
        }

        [Route ("buildings")]
        public async Task<List<building>> GetBuildings() {
            Console.WriteLine ("Getting Buildings for /facilities...");
            return await ctx.Building.ToListAsync ();
        }

        [Route ("buildings/{building_id}/floors")]
        public async Task<List<buildingfloor>> GetFloorsByBuilding(int building_id){
            Console.WriteLine ("Getting Floors for /facilities...");
            return await ctx.Buildingfloor.Where(s => s.building_id == building_id).ToListAsync ();
        }

        [Route ("floors/{floorId}/dampers")]
        public async Task<List<dampertest>> GetDampersByFloor(int floorId){
            Console.WriteLine ("Getting dampers by floor for /facilities...");
            return await ctx.Dampertest.Where(s => s.floor_id == floorId).ToListAsync ();
        }
        

    }

}