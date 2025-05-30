using Microsoft.EntityFrameworkCore;
using CampusCore.Models;

namespace CampusCore.Data
{
    public class CampusContext : DbContext
    {
        public CampusContext(DbContextOptions<CampusContext> options) : base(options) { }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Faculty>()
                .HasOne(f => f.Dean)
                .WithMany()
                .HasForeignKey(f => f.DeanId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.Chairman)
                .WithMany()
                .HasForeignKey(d => d.ChairmanId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
