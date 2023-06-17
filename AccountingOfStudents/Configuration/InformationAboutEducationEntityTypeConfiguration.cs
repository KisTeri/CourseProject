using AccountingOfStudents.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingOfStudents.Configuration
{
	public class InformationAboutEducationEntityTypeConfiguration : IEntityTypeConfiguration<InformationAboutEducation>
	{
		public void Configure(EntityTypeBuilder<InformationAboutEducation> builder)
		{
			builder.HasKey(i => i.Id)
				.HasName("PK_InformationAboutEducations_Id");

			builder.Property(i => i.StartOfEducation)
				.IsRequired()
				.HasColumnType("date");

			builder.Property(i => i.EndOfEducation)
				.IsRequired()
				.HasColumnType("date");

			builder.HasOne(i => i.AssignedCategory)
				.WithMany(i => i.InformationAboutEducations)
				.HasForeignKey(i => i.AssignedCategoryId)
				.HasConstraintName("FK_InformationAboutEducations_AssignedCategoryId_AssignedCategories_Id")
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(i => i.SendingOrganization)
				.WithMany(i => i.InformationAboutEducations)
				.HasForeignKey(i => i.SendingOrganizationId)
				.HasConstraintName("FK_InformationAboutEducations_SendingOrganizationId_SendingOrganizations_Id")
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(i => i.EducationalProgram)
				.WithMany(i => i.InformationAboutEducations)
				.HasForeignKey(i => i.EducationalProgramId)
				.HasConstraintName("FK_InformationAboutEducations_EducationalProgramId_EducationalProgram_Id")
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(i => i.PersonalInformationOfStudent)
				.WithMany(i => i.InformationAboutEducations)
				.HasForeignKey(i => i.PersonalInformationOfStudentId)
				.HasConstraintName("FK_InformationAboutEducations_PersonalInformationOfStudentId_PersonalInformationOfStudent_Id")
				.OnDelete(DeleteBehavior.NoAction);

			builder.HasOne(i => i.KindOfDocument)
				.WithOne(i => i.InformationAboutEducations)
				.HasForeignKey<InformationAboutEducation>(i => i.KindOfDocumentId)
				.HasConstraintName("FK_InformationAboutEducations_KindOfDocumentId_KindOfDocument_Id")
				.OnDelete(DeleteBehavior.NoAction);

		}
	}
}
