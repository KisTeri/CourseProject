using AccountingOfStudents.Entities;
using Microsoft.EntityFrameworkCore;

namespace AccountingOfStudents.Data
{
    public class DataContext : DbContext
    {
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(DataContext).Assembly);
		}

		public DbSet<AssignedCategory> AssignedCategories { get; set; }
		public DbSet<InformationAboutEducation> InformationAboutEducations { get; set; }
		public DbSet<EducationalProgram> EducationalPrograms { get; set; }
		public DbSet<KindOfDocument> KindOfDocuments { get; set; }
		public DbSet<PersonalInformationOfStudent> PersonalInformationOfStudents { get; set; }
		public DbSet<SendingOrganization> SendingOrganizations { get; set; }
	}
}
