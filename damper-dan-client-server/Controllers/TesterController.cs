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
    [Route ("api/tester")]
    [EnableCors("AllowSpecificOrigin")]
    public class TesterController : Controller, Dampers {
        public DamperContext ctx;

        public TesterController (DamperContext ctx) {
            this.ctx = ctx;
        }

       [Route ("dampers")]
        public async Task<List<Dampertest>> GetDampers () {
            Console.WriteLine ("Getting Dampers for /jacho...");
            return await ctx.Dampertest.Take (3).ToListAsync ();
        }

        [Route ("building/{building_id}/dampers")]
        public async Task<List<Dampertest>> GetDampersByBuilding(int building_id) {
            Console.WriteLine ("Getting dampers by floor for /jacho...");
            return await ctx.Dampertest.Where(s => s.building_id == building_id).ToListAsync ();
        }

        [Route ("buildings")]
        public async Task<List<Building>> GetBuildings() {
            Console.WriteLine ("Getting Buildings for /jacho...");
            return await ctx.Building.ToListAsync ();
        }

        [Route ("floors")]
        public async Task<List<Buildingfloor>> GetFloorsByBuilding(int building_id){
            Console.WriteLine ("Getting Floors for /jacho...");
            return await ctx.Buildingfloor.Where(s => s.building_id == building_id).ToListAsync ();
        }

        [Route ("floors/{floor_id}/dampers")]
        public async Task<List<Dampertest>> GetDampersByFloor(int floor_id){
            Console.WriteLine ("Getting dampers by floor for /jacho...");
            return await ctx.Dampertest.Where(s => s.floor_id == floor_id).ToListAsync ();
        }
        
        // [Route ("upload")]
        // public async Task<List<Dampertest>> PostUpload () {

        //     Console.WriteLine("Uploading...");

        //     Console.WriteLine ("Getting Dampers for /tester...");
        //     return await ctx.Dampertest.Take (3).ToListAsync ();
            
        // }
    }
}