using Cp.ContactService.Protos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cp.ContactService.Data.Mappings
{
    public class ContactMapping : IEntityTypeConfiguration<ContactModel>
    {
        public void Configure(EntityTypeBuilder<ContactModel> builder)
        {
            //builder.ToTable("ContactModel");
            builder.HasKey(t => t.UUID);
            builder.Property(t => t.Ad).HasMaxLength(255).IsRequired();
            builder.Property(t => t.Soyad).HasMaxLength(255).IsRequired();
            builder.Property(t => t.Firma).HasMaxLength(500).IsRequired();

            builder.HasData(Data());
        }

        static IEnumerable<ContactModel> Data()
        {
            return new List<ContactModel>
            {
                new ContactModel()
                {
                    UUID = 1,
                    Ad = "Ayşe",
                    Soyad = "Çiçek",
                    Firma = "Company One"
                },
                new ContactModel()
                {
                    UUID = 2,
                    Ad = "Ali",
                    Soyad = "Böcek",
                    Firma = "Company One"
                },
                new ContactModel()
                {
                    UUID = 3,
                    Ad = "Murat",
                    Soyad = "Ağaç",
                    Firma = "Company Two"
                },
                new ContactModel()
                {
                    UUID = 4,
                    Ad = "Bahar",
                    Soyad = "Yeni",
                    Firma = "Company Two"
                },
                new ContactModel()
                {
                    UUID = 5,
                    Ad = "Fatma",
                    Soyad = "Öz",
                    Firma = "Company Three"
                }
            };
        }
    }
}
