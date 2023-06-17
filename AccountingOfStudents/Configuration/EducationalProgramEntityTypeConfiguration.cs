using AccountingOfStudents.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingOfStudents.Configuration
{
	public class EducationalProgramEntityTypeConfiguration : IEntityTypeConfiguration<EducationalProgram>
	{
		public void Configure(EntityTypeBuilder<EducationalProgram> builder)
		{
			builder.HasKey(c => c.Id)
				.HasName("PK_EducationalPrograms_Id");

			builder.Property(c => c.KindOfProgram)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnType("nvarchar");

			builder.Property(c => c.NameOfProgram)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnType("nvarchar");
		}
	}
}
