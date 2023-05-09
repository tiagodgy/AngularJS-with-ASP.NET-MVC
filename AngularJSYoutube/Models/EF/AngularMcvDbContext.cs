using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AngularJSYoutube.Models.EF
{
    public class AngularMcvDbContext : DbContext
    {
        public AngularMcvDbContext() : base("name = AngularjsMvcDbContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
    }
}