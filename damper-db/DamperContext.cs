using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

using Pomelo.EntityFrameworkCore.MySql.Infrastructure;

namespace DamperDB {
	public class DamperContext : DbContext {

		// public DbSet<Building> Building { get; set; }
		// public DbSet<Buildingfloor> Buildingfloor { get; set; }
		// public DbSet<Commenthistory> Commenthistory { get; set; }
		// public DbSet<Customer> Customer { get; set; }
		// public DbSet<Dampercomment> Dampercomment { get; set; }
		// public DbSet<Dampermaterial> Dampermaterial { get; set; }
		// public DbSet<Damperstatus> Damperstatus { get; set; }
		public DbSet<Dampertest> Dampertest { get; set; }
		// public DbSet<Dampertestarchive> Dampertestarchive { get; set; }
		// public DbSet<Dampertype> Dampertype { get; set; }
		// public DbSet<Drawing> Drawing { get; set; }
		// public DbSet<Pictures> Pictures { get; set; }
		// public DbSet<Project> Project { get; set; }
		// public DbSet<Repairhistory> Repairhistory { get; set; }
		// public DbSet<Role> Role { get; set; }
		// public DbSet<Site> Site { get; set; }
		// public DbSet<Testcycle> Testcycle { get; set; }
		// public DbSet<User> User { get; set; }
		// public DbSet<Userlog> Userlog { get; set; }


		public DamperContext(DbContextOptions options) : base(options)
        {

        }

		// Wierd Quark. This constructor is not allowed otherwise ContextPooling cannot occur.
		//public DamperContext () { }



		// protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		// {
		// 	optionsBuilder.UseMySQL("server=localhost;database=tstrat_damper;user=root;password=");
		// }

	}

	// protected override void OnModelCreating (ModelBuilder modelBuilder) {
	//   base.OnModelCreating (modelBuilder);

	//   modelBuilder.Entity<Damper> (entity => {
	//     entity.HasKey (e => e.ID);
	//     entity.Property (e => e.Name).IsRequired ();
	//   });

	// }

}