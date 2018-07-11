using System;
using System.Linq;
using System.Collections.Generic;
using damper_dan_client.Controllers;
using DamperDB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;

namespace damper_dan_client.tests {

    public class TesterTests {

        [Fact]
        // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.TesterTests.GetDampersTest"
        public async void GetDampersTest() {

            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                JachoController jc = new JachoController (ctx);
				(await jc.GetDampers()).ForEach(s => Console.WriteLine (s.alias_id));
            }
        }
    }
}