using Microsoft.EntityFrameworkCore;

namespace MovieRatingApplication.Models
{
    /// <summary>
    /// DB context to the Sqlit which is attached to the project: MovieRating.db
    /// </summary>
    public class MovieRatingContext : DbContext
    {
        public MovieRatingContext(DbContextOptions options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=MovieRating.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<MovieRating>(builder =>
            {
                builder.HasKey(key => key.Id);
                builder.ToTable("MovieRating");
            });
        }

        public DbSet<MovieRating> MovieRatings { get; set; }
    }
}
