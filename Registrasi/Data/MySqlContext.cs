 using Microsoft.EntityFrameworkCore;
using Registrasi.Models;

namespace Registrasi.Data
{
	public class MySqlContext : DbContext
	{
        internal readonly object Agens;

        public MySqlContext(DbContextOptions options) : base(options)
		{
		}
		
        public DbSet<Agen> Agen { get; set; }
		public DbSet<WorkExperience> WorkExperience { get; set; }
		public DbSet<Attachmentt> Attachmentt { get; set; }
		public DbSet<Education> Education { get; set; }
		public DbSet<Kombinasi> Kombinasi { get; set;}
	}

}
