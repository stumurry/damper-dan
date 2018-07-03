using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DamperDB;

namespace damper_dan_client.Interfaces {
    public interface Dampers {
        List<Dampertest> GetDampers();
    }
}