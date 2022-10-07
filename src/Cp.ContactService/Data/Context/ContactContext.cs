using Cp.ContactService.Data.Mappings;
using Cp.ContactService.Protos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cp.ContactService.Data.Context
{
    public partial class ContactContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public string Schema
        {
            get { return "cp"; }
        }

        public ContactContext(IConfiguration configuration, DbContextOptions<ContactContext> options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql(_configuration.GetConnectionString("ContactProject"), x => x.MigrationsHistoryTable(HistoryRepository.DefaultTableName.ToLowerInvariant(), Schema))
                .UseLowerCaseNamingConvention();
        }

        public DbSet<ContactModel> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema(Schema);

            modelBuilder.ApplyConfiguration(new ContactMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
