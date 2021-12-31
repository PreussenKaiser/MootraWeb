using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace MootraWeb
{
    /// <summary>
    /// The class which handles emotion queries.
    /// </summary>
    [Serializable]
    public class EmotionHandler
    {
        /// <summary>
        /// Stores the save file name for the data store.
        /// </summary>
        private const string SAVEFILENAME = "emotions.txt";

        /// <summary>
        /// Initializes a new instance of the EmotionHandler class.
        /// </summary>
        public EmotionHandler()
        {
            this.Emotions = new List<Emotion>
            {
                new Emotion { Name = "Happy", DateCreated = DateTime.Now },
                new Emotion { Name = "Sad", DateCreated= DateTime.Now },
                new Emotion { Name = "Anxious", DateCreated = DateTime.Now},
                new Emotion { Name = "Angry", DateCreated = DateTime.Now}
            };
        }

        /// <summary>
        /// Gets the list of emotions.
        /// </summary>
        public List<Emotion> Emotions { get; private set; }

        /// <summary>
        /// Adds an emotion to the data store.
        /// </summary>
        /// <param name="emotionName">The emotion to add.</param>
        public void AddEmotion(string emotionName)
        {
            this.Emotions.Add(new Emotion
            {
                Name = emotionName,
                DateCreated = DateTime.Now
            });

            this.SaveToFile();
        }

        /// <summary>
        /// Saves the current emotions list instance.
        /// </summary>
        public void SaveToFile()
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());

            using (StreamWriter sw = new StreamWriter(SAVEFILENAME))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, this.Emotions);
            }
        }
    }
}
