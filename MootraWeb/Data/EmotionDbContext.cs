using Microsoft.EntityFrameworkCore;

namespace MootraWeb
{
    /// <summary>
    /// The class used to handle the emotion database context.
    /// </summary>
    public class EmotionDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the EmotionDBContext class.
        /// </summary>
        /// <param name="options">The database context options.</param>
        public EmotionDbContext(DbContextOptions<EmotionDbContext> options)
            : base(options) { }

        /// <summary>
        /// Gets or sets an emotion in the database.
        /// </summary>
        public DbSet<Emotion> Emotion { get; set; }

        /// <summary>
        /// Executes when the model os created.
        /// </summary>
        /// <param name="modelBuilder">Defines the structure of the database.</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Emotion>().HasData(new List<Emotion>());
            base.OnModelCreating(modelBuilder);
        }
    }
}
