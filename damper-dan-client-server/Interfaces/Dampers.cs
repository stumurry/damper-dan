using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DamperDB;
using Microsoft.EntityFrameworkCore;

namespace damper_dan_client.Interfaces {
    public interface Dampers {

        Task<List<dampertest>> GetDampers();

        Task<List<dampertest>> GetDampersByBuilding(int building_id);

         Task<List<building>> GetBuildings();

         Task<List<buildingfloor>> GetFloorsByBuilding(int building_id);

         Task<List<dampertest>> GetDampersByFloor(int floor_id);

    }
    
}