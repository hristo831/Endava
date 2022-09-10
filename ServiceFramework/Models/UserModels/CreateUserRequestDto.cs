using Newtonsoft.Json;

namespace ServiceFramework.Models.UserModels
{
    /// <summary>
    /// Create user request dto.
    /// </summary>
    public class CreateUserRequestDto
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
    }
}
