using AccountingOfStudents.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingOfStudents.Configuration
{
	public class PersonalInformationOfStudentEntityTypeConfiguration : IEntityTypeConfiguration<PersonalInformationOfStudent>
	{
		public void Configure(EntityTypeBuilder<PersonalInformationOfStudent> builder)
		{
			builder.HasKey(c => c.Id)
				.HasName("PK_PersonalInformationOfStudents_Id");

			builder.Property(c => c.LastName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnType("nvarchar");

			builder.Property(c => c.FirstName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnType("nvarchar");

			builder.Property(c => c.MiddleName)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnType("nvarchar");

			builder.Property(c => c.Snils)
				.IsRequired()
				.HasMaxLength(14)
				.HasColumnType("nvarchar");

			builder.Property(c => c.DateOfBirth)
				.IsRequired()
				.HasColumnType("date");
		}
	}
}
