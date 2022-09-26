using Cp.ContactInformationService.Protos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cp.ContactInformationService.Data.Mappings
{
    public class ContactInformationMapping : IEntityTypeConfiguration<ContactInformation>
    {
        public void Configure(EntityTypeBuilder<ContactInformation> builder)
        {
            //builder.ToTable("ContactInformation");
            builder.HasKey(t => t.UUID);
            builder.Property(t => t.ContactId).IsRequired();
            builder.Property(t => t.InformationType).IsRequired();
            builder.Property(t => t.Content).HasMaxLength(1000).IsRequired();

            builder.HasData(Data());
        }

        static IEnumerable<ContactInformation> Data()
        {
            return new List<ContactInformation>
            {
                new ContactInformation()
                {
                    UUID = 1,
                    ContactId = 1,
                    InformationType = InformationType.Phone,
                    Content = "05320000000"
                },
                new ContactInformation()
                {
                    UUID = 2,
                    ContactId = 1,
                    InformationType = InformationType.Mail,
                    Content = "mypala@mail.com"
                },
                new ContactInformation()
                {
                    UUID = 3,
                    ContactId = 1,
                    InformationType = InformationType.Location,
                    Content = "Ümraniye"
                }
            };
        }
    }
}
