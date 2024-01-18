using backend.Models;
using Microsoft.EntityFrameworkCore;

namespace backend.Data;

public class AuthDbContext : DbContext
{
    public ExerciseDBContext()
        {
            _configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(_configuration.GetConnectionString("AuthDb")!)
                .EnableDetailedErrors();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("Users");
            modelBuilder.Entity<TempUser>().ToTable("TempUser");
            modelBuilder.Entity<Session>().ToTable("Session");

            

        }
}