using System;
using System.Linq;
using System.Collections.Generic;
using damper_dan_client.Controllers;
using DamperDB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;
using System.Threading.Tasks;

using damper_dan_client.Interfaces;


namespace damper_dan_client.tests {
    public class FacilitiesEngineerTest {

        [Fact]
         // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.FacilitiesEngineerTest.GetDampersTest"
        public async Task GetDampersTest() {
            Console.WriteLine("FacilitiesEngineer");
            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                Dampers d = new FacilitiesController(ctx);
                (await d.GetDampers()).ForEach(s => Console.WriteLine (s.alias_id));
            }
        }

        [Fact]
         // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.FacilitiesEngineerTest.GetBuildingsTest"
        public async Task GetBuildingsTest() {
            Console.WriteLine("FacilitiesEngineer - Getting Buildings");
            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                Dampers d = new FacilitiesController(ctx);
                (await d.GetBuildings()).ForEach(s => Console.WriteLine (s.alias_id));
            }
        }

        [Fact]
         // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.FacilitiesEngineerTest.GetDampersByBuildingTest"
        public async Task GetDampersByBuildingTest() {
            Console.WriteLine("FacilitiesEngineer - Getting Dampers by Building");
            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                Dampers d = new FacilitiesController(ctx);
                var building = (await d.GetDampers())[1]; // Let just get the first building on the list
                (await d.GetDampersByBuilding(building.id)).ForEach(s => Console.WriteLine (s.alias_id));
            }
        }

        [Fact]
         // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.FacilitiesEngineerTest.GetDampersByFloor"
        public async Task GetDampersByFloor() {
            Console.WriteLine("FacilitiesEngineer - Getting Dampers by Floor");
            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                Dampers d = new FacilitiesController(ctx);
                var building = (await d.GetBuildings())[1]; // Let just get the first building on the list
                var floor = (await d.GetFloorsByBuilding(building.id))[0];
                (await d.GetDampersByFloor(floor.id)).ForEach(s => Console.WriteLine (s.alias_id));
            }
        }
    }
}