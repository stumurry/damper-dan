using System;
using System.Linq;
using System.Collections.Generic;
using damper_dan_client.Controllers;
using DamperDB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;

namespace damper_dan_client.tests {
    public class MysqlTests {

        [Fact]
         // dotnet test --filter "FullyQualifiedName=damper_dan_client.tests.MysqlTests.BasicConnectionTest"
        public void BasicConnectionTest () {

            // Within ASP Framework, the common use is DBContextPooling
            // Using Dependency Injection from the ServiceContainer, basic configuration
            // is done in the startup.cs file.
            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                ctx.Dampertest.Select(x => x.alias_id).Take(3).ToList().ForEach (s => Console.WriteLine (s));
            }

        }
    }
}