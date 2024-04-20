using Microsoft.EntityFrameworkCore;

namespace L02P02_2022_QR_601_2021_AA_651.Models
{
	public class libreriaDbContext : DbContext
	{
		public libreriaDbContext(DbContextOptions options) : base(options) 
		{
		}

		public DbSet<libros> libros { get; set; }
		public DbSet<autores> autores { get; set; }
		public DbSet<categorias> categorias { get; set; }
	}
}
