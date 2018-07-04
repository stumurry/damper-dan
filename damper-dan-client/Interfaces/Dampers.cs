using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DamperDB;
using Microsoft.EntityFrameworkCore;

namespace damper_dan_client.Interfaces {
    public interface Dampers {
        Task<List<Dampertest>> GetDampers();
    }
}