using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
	public class NorthwindContext: DbContext
	{
		public DbSet<Product> Products { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=(LocalDb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true");	
		}
	}
}
