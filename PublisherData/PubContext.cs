using Microsoft.EntityFrameworkCore;
using PublisherDomain;
using Microsoft.Extensions.Logging;

namespace PublisherData
{
    public class PubContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Cover> Covers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
              "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = PubDatabase"
            ).LogTo(Console.WriteLine,
                    new[] { DbLoggerCategory.Database.Command.Name },
                    LogLevel.Information)
            .EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var artists = new Artist[]
            {
                new Artist { Id = 1, FirstName = "Omar", LastName = "Ahmad"},
                new Artist { Id = 2, FirstName = "Mariam", LastName = "Ahmad"},
                new Artist { Id = 3, FirstName = "Yosuf", LastName = "Ahmad"}
            };

            var covers = new Cover[]
            {
                new Cover { Id = 1, DesignIdeas ="How is?", DigitalOnly = false },
                new Cover { Id = 2, DesignIdeas ="How are?", DigitalOnly = true },
                new Cover { Id = 3, DesignIdeas ="How am?", DigitalOnly = true },

            };

            modelBuilder.Entity<Artist>().HasData(artists);
            modelBuilder.Entity<Cover>().HasData(covers);

            //example of mapping an unconventional FK
            //since I have the author prop in books, I am
            //using it in WithOne:
            //modelBuilder.Entity<Author>()
            //   .HasMany(a => a.Books)
            //   .WithOne(b => b.Author)
            //   .HasForeignKey("AuthorId").IsRequired(false);


            //example of a more advanced mapping to specify
            //a one to many between author and book when 
            //there are no navigation properties:
            //modelBuilder.Entity<Author>()
            //    .HasMany<Book>()
            //    .WithOne();
        }

    }
}