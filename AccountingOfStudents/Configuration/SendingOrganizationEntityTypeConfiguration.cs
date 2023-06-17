using AccountingOfStudents.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AccountingOfStudents.Configuration
{
	public class SendingOrganizationEntityTypeConfiguration : IEntityTypeConfiguration<SendingOrganization>
	{
		public void Configure(EntityTypeBuilder<SendingOrganization> builder)
		{
			builder.HasKey(c => c.Id)
				.HasName("PK_SendingOrganizations_Id");

			builder.Property(c => c.Organization)
				.IsRequired()
				.HasMaxLength(500)
				.HasColumnType("nvarchar");
		}
	}
}
