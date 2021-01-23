using Adler.System.Ship.Models;
using Microsoft.EntityFrameworkCore;

namespace Adler.System.Ship.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<RollList> RollList {get; set;}
        public DbSet<CrewMembers> CrewMember {get; set;}
        public DbSet<CrewContact> CrewContact {get; set;}
    }
}