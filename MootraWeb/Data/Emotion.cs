namespace MootraWeb
{
    /// <summary>
    /// The class that represents an emotion.
    /// </summary>
    public class Emotion
    {
        /// <summary>
        /// The id of the emotion.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the emotion name.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the date of creation.
        /// </summary>
        public DateTime DateCreated { get; set; }
    }
}
