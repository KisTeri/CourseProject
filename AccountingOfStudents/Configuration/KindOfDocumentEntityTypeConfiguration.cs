using AccountingOfStudents.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingOfStudents.Configuration
{
	public class KindOfDocumentEntityTypeConfiguration : IEntityTypeConfiguration<KindOfDocument>
	{
		public void Configure(EntityTypeBuilder<KindOfDocument> builder)
		{
			builder.HasKey(c => c.Id)
				.HasName("PK_KindOfDocuments_Id");

			builder.Property(c => c.DateOfIssue)
				.IsRequired()
				.HasColumnType("date");
		}
	}
}
