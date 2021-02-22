using System.Collections.Generic;
using System.Linq;
using HomeWork9.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace HomeWork9.Context
{
    /// <summary>
    /// 
    /// </summary>
    public class StoryDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true);
            var connection = builder.Build().GetConnectionString("StoryConnection");

            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().Property(character => character.FirstName).IsRequired().HasMaxLength(50);
            modelBuilder.Entity<Character>().Property(character => character.LastName).IsRequired().HasMaxLength(100);

            var stories = new List<Story>
            { 
            new Story { Id = 1, Name = "Foundation", Description = "" },
            new Story { Id = 2, Name = "LOTR", Description = "" },
            new Story { Id = 3, Name = "Hyperion", Description = "" }
            };

            modelBuilder.Entity<Story>().HasData(stories);

            modelBuilder.Entity<Character>().HasData(
                new Character
                { Id = 1, FirstName = "Harry", LastName = "Seldon", Gender = true, Age = 35, StoryId = 1 },
                new Character
                { Id = 2, FirstName = "Arven", LastName = "Undomiel", Gender = false, Age = 2700, StoryId = 2 },
                new Character
                { Id = 3, FirstName = "Finn", LastName = "Mertens", Gender = true, Age = 14, StoryId = 3 });


            modelBuilder.Entity<Author>().HasData(
                new Author { Id=1, FirstName = "Reuel ", LastName = "Tolkien"},
                new Author { Id = 2, FirstName = "Hans", LastName = "Andersen"}
                );
        }
    }
}
