using GlassCleaning.Entities.Model;
using Microsoft.EntityFrameworkCore;

namespace GlassCleaning.DataAccess.Concrete.EntityFramework.Context
{
    public class GlassCleaningContext: DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IIGST50;Database=GlassCleaning;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<AdminUser> AdminUser { get; set; }
        public DbSet<Appointment> Appointment { get; set; }
        public DbSet<Expense> Expense { get; set; }
        public DbSet<Firm> Firm { get; set; }
        public DbSet<Ref> Ref { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TransactionEntityConfiguration());
          //  modelBuilder.ApplyConfiguration(new UserEntityConfiguration());

         
        }
    }
}
