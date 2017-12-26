using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HelpDesk.Models
{
    public class HelpDeskContext : DbContext
    {

		public HelpDeskContext(DbContextOptions<HelpDeskContext> options) : base(options)
		{
			
		}

		public DbSet<company> companies { get; set; }
		public DbSet<computer> computers { get; set; }
		public DbSet<CPU> CPUS { get; set; }
		public DbSet<department> department { get; set; }
		public DbSet<employee> employees { get; set; }
		public DbSet<HDD> HDDS { get; set; }
		public DbSet<HDD_Type> HDD_Types { get; set; }
		public DbSet<monitor> monitors { get; set; }
		public DbSet<monitor_brand> monitor_brands { get; set; }
		public DbSet<monitor_brand_model> monitor_brand_models { get; set; }
		public DbSet<RAM> RAMS { get; set; }
		public DbSet<RAM_Type> RAM_Types { get; set; }
		public DbSet<roles> roless { get; set; }
		public DbSet<section> sections { get; set; }
		public DbSet<statuscomponent> statuscomponents { get; set; }
		public DbSet<type_size> type_sizes { get; set; }
		public DbSet<user> users { get; set; }


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<company>().ToTable("company");
			modelBuilder.Entity<computer>().ToTable("computer");
			modelBuilder.Entity<CPU>().ToTable("CPU");
			modelBuilder.Entity<department>().ToTable("department");
			modelBuilder.Entity<employee>().ToTable("employee");
			modelBuilder.Entity<HDD>().ToTable("HDD");
			modelBuilder.Entity<HDD_Type>().ToTable("HDD_Type");
			modelBuilder.Entity<monitor>().ToTable("monitor");
			modelBuilder.Entity<monitor_brand>().ToTable("monitor_brand");
			modelBuilder.Entity<monitor_brand_model>().ToTable("monitor_brand_model");
			modelBuilder.Entity<RAM>().ToTable("RAM");
			modelBuilder.Entity<RAM_Type>().ToTable("RAM_Type");
			modelBuilder.Entity<roles>().ToTable("roles");
			modelBuilder.Entity<section>().ToTable("section");
			modelBuilder.Entity<statuscomponent>().ToTable("statuscomponent");
			modelBuilder.Entity<type_size>().ToTable("type_size");
			modelBuilder.Entity<user>().ToTable("user");
		}
	}
}