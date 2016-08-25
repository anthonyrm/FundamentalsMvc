using NetFundamentals.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace NetFundamentals.Repository
{
    public class ChinookContext : DbContext
    {
        public ChinookContext() : base("NetFundamentals")
        {
            Database.SetInitializer<ChinookContext>(null);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Customer> Customer { get; set; }
    }
}