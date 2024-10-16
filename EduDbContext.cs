﻿using lldb.Models;
using Microsoft.EntityFrameworkCore;

namespace lldb
{
	public class EduDbContext : DbContext
	{
		public EduDbContext():base()
		{

		}

		public EduDbContext(DbContextOptions<EduDbContext> options) : base(options) 
		{
			
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Class>();
			modelBuilder.Entity<Student>();
		}

		public DbSet<Class> Classes { get; set; }
		public DbSet<Student> Students { get; set; }
	}
}
