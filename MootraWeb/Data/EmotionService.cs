namespace MootraWeb
{
    /// <summary>
    /// The class which queries the local database.
    /// </summary>
    public sealed class EmotionService : IEmotionService
    {
        /// <summary>
        /// Adds an emotion to the database.
        /// </summary>
        /// <param name="name">The emotion name.</param>
        /// <returns>If the task was completed or not.</returns>
        public async Task AddEmotion(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Removes an emotion from the local database.
        /// </summary>
        /// <param name="id">The of the emotion to remove.</param>
        /// <returns>If the task was completed or not.</returns>
        public async Task RemoveEmotion(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets an IEnumerable of emotions from the local database.
        /// </summary>
        /// <param name="query">Queries the local database for an enumerable of emotions.</param>
        /// <returns>If the task was completed or not.</returns>
        public async Task<IEnumerable<Emotion>> GetEmotions(string query)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Initializes the local database.
        /// </summary>
        /// <returns>Not implemented.</returns>
        private async Task Init()
        {
            throw new NotImplementedException();
        }
    }
}
