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
using damper_dan_client.Services;

namespace damper_dan_client.tests {
    public class ServicesTests {

        [Fact]
         // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.ServicesTests.GetBuildingLatLong"
        public async Task GetBuildingLatLong () {
            Console.WriteLine("Services Test");
            // var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            // optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            // using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
            //     Dampers jc = new JachoController (ctx);
            //     (await jc.GetDampers()).ForEach(s => Console.WriteLine (s.alias_id));
            // }

        }
    }
}