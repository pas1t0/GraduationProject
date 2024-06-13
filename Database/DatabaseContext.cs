using System.Text.Json;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Employee> Employees { get; set; } = null!;

        public DbSet<Position> Positions { get; set; } = null!;

        public DbSet<Request> Requests { get; set; } = null!;

        public DbSet<Role> Roles { get; set; } = null!;

        public DbSet<Service> Services { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        public DatabaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Configs", "connectionString.json");

            var connectionStrings = ReadFromFile<ConnectionStrings>(path);

            optionsBuilder.UseSqlServer(connectionStrings.Default);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            FillEntities<Role>(modelBuilder, "roles");
            FillEntities<Category>(modelBuilder, "categories");
            FillEntities<Position>(modelBuilder, "positions");
            FillEntities<Service>(modelBuilder, "services");
            FillEntities<User>(modelBuilder, "users");
            FillEntities<Employee>(modelBuilder, "employees");
            FillEntities<Request>(modelBuilder, "requests");
        }

        private void FillEntities<T>(ModelBuilder modelBuilder, string jsonName) where T : class
        {
            var entities = ReadEntities<T[]>(jsonName);

            modelBuilder
                .Entity<T>()
                .HasData(entities);
        }

        private T ReadEntities<T>(string jsonName)
        {
            var path = Path.Combine(Environment.CurrentDirectory, "Configs", "Entities", $"{jsonName}.json");

            return ReadFromFile<T>(path);
        }

        private T ReadFromFile<T>(string path)
        {
            var fileContent = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(fileContent);
        }
    }
}
