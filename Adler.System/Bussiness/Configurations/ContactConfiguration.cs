using Adler.System.Bussiness.Demographics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Adler.System.Bussiness.Configurations
{
	internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
	{
		private const string TableName = "contact";

		public void Configure(EntityTypeBuilder<Contact> builder)
		{
			builder.ToTable(TableName);
			builder.HasKey(x => x.Key);

			builder.Property(x => x.Key)
				.HasColumnName("key")
				.HasColumnType("bigint")
				.IsRequired();

			builder.HasIndex(x => x.Key)
				.HasDatabaseName("contact_key")
				.IsUnique();

			builder.Property(x => x.Country)
				.HasColumnName("country")
				.HasColumnType("varchar(2)")
				.HasMaxLength(36)
				.IsRequired();

			builder.Property(x => x.City)
				.HasColumnName("city")
				.HasColumnType("varchar(256)")
				.HasMaxLength(256)
				.IsRequired();

			builder.Property(x => x.Street)
				.HasColumnName("street")
				.HasColumnType("varchar(256)")
				.HasMaxLength(256);

			builder.Property(x => x.Phone)
				.HasColumnName("phone")
				.HasColumnType("varchar(256)")
				.HasMaxLength(256);

			builder.Property(x => x.Email)
				.HasColumnName("email")
				.HasColumnType("varchar(256)")
				.HasMaxLength(256);
		}
	}
}