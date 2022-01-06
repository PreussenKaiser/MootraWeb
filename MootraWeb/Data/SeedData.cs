namespace MootraWeb
{
    /// <summary>
    /// The class which seeds data into a local database.
    /// </summary>
    public static class SeedData
    {
        /// <summary>
        /// Initializes the local database.
        /// </summary>
        /// <param name="db">The database to initalize.</param>
        public static void Initialize(EmotionContext db)
        {
            List<Emotion> emotions = new()
            {
                new Emotion("Happy"),
                new Emotion("Sad"),
                new Emotion("Fristerated"),
                new Emotion("Anxious"),
            };

            db.Emotions.AddRange(emotions);
            db.SaveChanges();
        }
    }
}
