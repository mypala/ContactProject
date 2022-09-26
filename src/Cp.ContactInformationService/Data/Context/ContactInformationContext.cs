using Cp.ContactInformationService.Data.Mappings;
using Cp.ContactInformationService.Protos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cp.ContactInformationService.Data.Context
{
    public partial class ContactInformationContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public string Schema
        {
            get { return "cp"; }
        }

        public ContactInformationContext(IConfiguration configuration, DbContextOptions<ContactInformationContext> options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(_configuration.GetConnectionString("ContactProject"), x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName.ToLowerInvariant(), Schema))
                .UseLowerCaseNamingConvention();
        }

        public DbSet<ContactInformation> ContactInformations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);

            modelBuilder.ApplyConfiguration(new ContactInformationMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
