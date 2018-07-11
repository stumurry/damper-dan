using System;
using System.Linq;
using System.Collections.Generic;
using damper_dan_client.Controllers;
using DamperDB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;

using damper_dan_client.Interfaces;


namespace damper_dan_client.tests {
    public class FacilitiesEngineerTest {

        [Fact]
         // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.FacilitiesEngineerTest.GetDampersTest"
        public async void GetDampersTest() {

            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                Dampers d = new FacilitiesController(ctx);
                (await d.GetDampers()).ForEach(s => Console.WriteLine (s.alias_id));
            }
        }
    }
}