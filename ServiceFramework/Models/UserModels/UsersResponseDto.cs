using Newtonsoft.Json;

namespace ServiceFramework.Models.UserModels
{
    /// <summary>
    /// User response dto.
    /// </summary>
    public class UsersResponseDto
    {
        /// <summary>
        /// Gets or sets page.
        /// </summary>
        [JsonProperty("page")]
        public int Page { get; set; }

        /// <summary>
        /// Gets or sets per page.
        /// </summary>
        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        /// <summary>
        /// Gets or sets total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }

        /// <summary>
        /// Gets or sets total pages.
        /// </summary>
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or sets data.
        /// </summary>
        [JsonProperty("data")]
        public List<UserDto> Data { get; set; }

        /// <summary>
        /// Gets or sets support.
        /// </summary>
        [JsonProperty("support")]
        public Support Support { get; set; }
    }

    /// <summary>
    /// User response dto.
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// Gets or sets id.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets first name.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets last name.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets avatar.
        /// </summary>
        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }

    /// <summary>
    /// Support.
    /// </summary>
    public class Support
    {
        /// <summary>
        /// Gets or sets url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets text.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
