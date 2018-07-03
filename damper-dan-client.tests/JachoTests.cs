using System;
using System.Linq;
using damper_dan_client.Controllers;
using DamperDB;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Xunit;

namespace damper_dan_client.tests {
    public class UnitTest1 {
        [Fact]
        public void Test1 () {

            // IServiceCollection i = new ServiceCollection();
            // var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            // optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            // using(var ctx = new DamperContext(optionsBuilder.Options) ) {
            //     var ss = ctx.Dampertest.ToList();
            // }

            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using (DamperContext ctx = new DamperContext(optionsBuilder.Options) ) {
                JachoController jc = new JachoController (ctx);
                jc.GetDampers ().ForEach (s => Console.WriteLine (s.alias_id));
            }

            
        }
    }
}