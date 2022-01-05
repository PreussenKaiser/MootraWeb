using Microsoft.EntityFrameworkCore;

namespace MootraWeb
{
    /// <summary>
    /// The class which queries the local database.
    /// </summary>
    public sealed class EmotionService
    {
        /// <summary>
        /// The session with the local Emotions.db database.
        /// </summary>
        private EmotionDbContext dbContext;

        /// <summary>
        /// Initializes a new instance of the EmotionService class.
        /// </summary>
        /// <param name="dbContext">The session with the local Emotions.db database.</param>
        public EmotionService(EmotionDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        /// <summary>
        /// Adds an emotion to the local database.
        /// </summary>
        /// <param name="emotion">The emotion to add.</param>
        /// <returns>If the task was completed or not.</returns>
        public async Task<Emotion> AddEmotionAsync(Emotion emotion)
        {
            this.dbContext.Emotion.Add(emotion);
            await this.dbContext.SaveChangesAsync();

            return emotion;
        }

        /// <summary>
        /// Removes an emotion from the local database.
        /// </summary>
        /// <param name="emotion">The emotion to remove.</param>
        /// <returns>If the task was completed or not.</returns>
        public async Task RemoveEmotionAsync(Emotion emotion)
        {
            this.dbContext.Emotion.Remove(emotion);
            await dbContext.SaveChangesAsync();
        }

        /// <summary>
        /// Gets a list of emotions from the database.
        /// </summary>
        /// <returns>If the task was completed or not.</returns>
        public async Task<List<Emotion>> GetEmotionsAsync()
        {
            return await this.dbContext.Emotion.ToListAsync();
        }
    }
}
