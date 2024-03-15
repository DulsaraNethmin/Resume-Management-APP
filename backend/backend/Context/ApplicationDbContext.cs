using backend.Enties;
using Microsoft.EntityFrameworkCore;

namespace backend.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Job>().HasOne(j => j.Company)
                .WithMany(c => c.Jobs)
                .HasForeignKey(j => j.ComponyId);
            modelBuilder.Entity<Candidate>().HasOne(c => c.Job)
                .WithMany(j => j.Candidates)
                .HasForeignKey(c => c.JobId);
            modelBuilder.Entity<Company>()
                .Property(c => c.size)
                .HasConversion<string>();
            modelBuilder.Entity<Job>()
                .Property(j => j.Level)
                .HasConversion<string>();
        }
    }
}
