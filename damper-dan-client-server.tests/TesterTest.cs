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

    public class TesterTests {

        [Fact]
        // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.TesterTests.GetDampersTest"
        public async Task GetDampersTest() {

            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                Dampers jc = new TesterController (ctx);
				(await jc.GetDampers()).ForEach(s => Console.WriteLine (s.alias_id));
            }
        }
    }
}