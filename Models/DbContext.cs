using Microsoft.EntityFrameworkCore;

namespace Lab11.Models
{
	public class LabDbContext : DbContext
	{
		public LabDbContext (DbContextOptions<LabDbContext> options)
			: base(options)
		{
		}
		public DbSet<Professor> Professor {get; set;}
		public DbSet<Course> Course {get; set;}
	}
}