using Api.Database.Postgre;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Adler.System
{
	public class SwcContextFactory : IDesignTimeDbContextFactory<SwcContext>
	{
		public SwcContextFactory()
		{
		}

		private IConfiguration Configuration => new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
			.AddJsonFile("appsettings.json")
			.Build();

		public SwcContext CreateDbContext(string[] args)
		{
			var builder = new DbContextOptionsBuilder<SwcContext>();
			builder.UseNpgsql(Configuration.GetConnectionString("Adler.System.MainDB"));

			return new SwcContext(builder.Options);
		}
	}
}