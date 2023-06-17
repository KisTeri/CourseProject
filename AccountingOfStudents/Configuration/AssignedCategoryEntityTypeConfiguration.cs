using AccountingOfStudents.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingOfStudents.Configuration
{
	public class AssignedCategoryEntityTypeConfiguration : IEntityTypeConfiguration<AssignedCategory>
	{
		public void Configure(EntityTypeBuilder<AssignedCategory> builder)
		{
			builder.HasKey(c => c.Id)
				.HasName("PK_AssignedCategories_Id");

			builder.Property(c => c.Category)
				.IsRequired()
				.HasMaxLength(255)
				.HasColumnType("nvarchar");
		}
	}
}
