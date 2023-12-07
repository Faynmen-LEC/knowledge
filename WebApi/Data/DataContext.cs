using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using WebApi.Entities;

namespace WebApi.Data
{
	public class DataContext :DbContext
	{
        public DataContext(DbContextOptions<DataContext> options):base(options) 
        {
            
        }

        public DbSet<Driver>  Drivers { get; set; }
    }
}
