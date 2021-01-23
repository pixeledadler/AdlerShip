using Adler.System.Bussiness.Demographics;
using Microsoft.EntityFrameworkCore;

namespace Api.Database.Postgre
{
	public class SwcContext : DbContext
	{
		public SwcContext(DbContextOptions<SwcContext> options) : base(options)
		{
		}

		public DbSet<Contact> Contact { get; set; }
		public DbSet<CrewMember> CrewMember { get; set; }
		public DbSet<RollList> RollList { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
		}
	}
}