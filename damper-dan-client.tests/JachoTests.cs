using System;
using Xunit;
using System.Linq;

using damper_dan_client.Controllers;
using DamperDB;

using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace damper_dan_client.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var optionsBuilder = new DbContextOptionsBuilder<DamperContext>();
            optionsBuilder.UseMySql("Server=localhost;Database=tstrat_damper;User=root;Password=;");

            using(var ctx = new DamperContext(optionsBuilder.Options) ) {
                var ss = ctx.Dampertest.ToList();
            }
            JachoController jc = new JachoController();

            jc.GetDampers().ForEach(s => Console.WriteLine(s));
        }
    }
}
