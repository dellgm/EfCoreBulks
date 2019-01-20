using Microsoft.EntityFrameworkCore;

namespace EfCoreBulks
{
    public class SesContext : DbContext
    {

        public SesContext(DbContextOptions<SesContext> options) : base(options)
        {

        }

        public virtual DbSet<SesPriceHistory> SesPriceHistory { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-DC7I6UJ\SQLEXPRESS;Initial Catalog=Test;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
