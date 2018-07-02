using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;
using MySQL.Data;
using MySQL.Data.EntityFrameworkCore.Extensions;

namespace DamperDB {
  public class DamperContext : DbContext {

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseMySQL("server=localhost;database=tstrat_damper;user=root;password=");
    }

    protected override void OnModelCreating (ModelBuilder modelBuilder) {
      base.OnModelCreating (modelBuilder);

      modelBuilder.Entity<Damper> (entity => {
        entity.HasKey (e => e.ID);
        entity.Property (e => e.Name).IsRequired ();
      });

    }

  }
}