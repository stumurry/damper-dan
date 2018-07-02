using System;
using Xunit;
using System.Linq;

using damper_dan_client.Controllers;

namespace damper_dan_client.tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            JachoController jc = new JachoController();
            jc.GetDampers().ForEach(s => Console.WriteLine(s));
        }
    }
}
