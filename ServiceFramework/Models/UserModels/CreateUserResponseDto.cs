using Newtonsoft.Json;

namespace ServiceFramework.Models.UserModels
{
    /// <summary>
    /// Create user response dto.
    /// </summary>
    public class CreateUserResponseDto
    {
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets job.
        /// </summary>
        [JsonProperty("job")]
        public string Job { get; set; }

        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets createdAt.
        /// </summary>
        [JsonProperty("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
