using Newtonsoft.Json;

namespace ServiceFramework.Models.UserModels
{
    public class UserResponseDto
    {
        /// <summary>
        /// Gets or sets page.
        /// </summary>
        [JsonProperty("data")]
        public UserDto Data { get; set; }

        /// <summary>
        /// Gets or sets page.
        /// </summary>
        [JsonProperty("support")]
        public Support Support { get; set; }
    }
}
