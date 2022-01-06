using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MootraWeb
{
    /// <summary>
    /// The class which represents an emotions controller.
    /// </summary>
    [Route("emotions")]
    [ApiController]
    public class EmotionsController : Controller
    {
        /// <summary>
        /// The local database.
        /// </summary>
        private readonly EmotionContext db;

        /// <summary>
        /// Initializes a new instance of the EmotionsController class.
        /// </summary>
        /// <param name="db">The local database.</param>
        public EmotionsController(EmotionContext db)
        {
            this.db = db;
        }

        /// <summary>
        /// Adds an emotion to the local database.
        /// </summary>
        /// <param name="emotionName">The name of the emotion.</param>
        /// <returns>No value.</returns>
        [HttpPost]
        public async Task<ActionResult> AddEmotionAsync(Emotion emotion)
        {
            this.db.Emotions.Add(emotion);
            await this.db.SaveChangesAsync();

            return this.Ok(emotion);
        }

        /// <summary>
        /// Removes an emotion from the local database.
        /// </summary>
        /// <param name="emotion">The emotion to remove.</param>
        /// <returns>No value.</returns>
        [HttpDelete("{id}")]
        public async Task<ActionResult> RemoveEmotionAsync(int id)
        {
            var foundEmotion = this.db.Emotions.FirstOrDefault(e => e.Id == id);
            ActionResult result = this.NotFound("Emotion not found.");

            if (foundEmotion != null)
            {
                this.db.Emotions.Remove(foundEmotion);
                await this.db.SaveChangesAsync();

                result = this.Ok(foundEmotion);
            }

            return result;
        }

        /// <summary>
        /// Gets a list of emotions from the local database.
        /// </summary>
        /// <returns>The emotions from the local database.</returns>
        [HttpGet]
        public async Task<ActionResult<List<Emotion>>> GetEmotionsAsync()
        {
            return (await this.db.Emotions.ToListAsync()).OrderByDescending(e => e.DateCreated).ToList();
        }
    }
}
