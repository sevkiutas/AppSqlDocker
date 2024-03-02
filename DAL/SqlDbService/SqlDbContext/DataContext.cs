using DAL.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DAL.SqlDbService.SqlDbContext
{
	public class DataContext : DbContext
	{
		private readonly IConfiguration _configuration;
		public DataContext(IConfiguration configuration)
		{
			_configuration = configuration;
		} 
		public DbSet<ProductEntity> Product { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			string conn =  _configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
			optionsBuilder.UseSqlServer(conn);
		}
	}
}
