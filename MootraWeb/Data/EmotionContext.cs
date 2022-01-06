using Microsoft.EntityFrameworkCore;

namespace MootraWeb
{
    /// <summary>
    /// The class used to handle the emotion database context.
    /// </summary>
    public class EmotionContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the EmotionDBContext class.
        /// </summary>
        /// <param name="options">The database context options.</param>
        public EmotionContext(DbContextOptions options) : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the table of emotions in the local database..
        /// </summary>
        public DbSet<Emotion> Emotions { get; set; }
    }
}
