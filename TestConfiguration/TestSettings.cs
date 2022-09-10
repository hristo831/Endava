using Newtonsoft.Json;

namespace TestConfiguration
{
    /// <summary>
    /// Test settings.
    /// </summary>
    public class TestSettings
    {
        /// <summary>
        /// Gets or sets UI.
        /// </summary>
        [JsonProperty("UI")]
        public UI? UI { get; set; }


        /// <summary>
        /// Gets or sets Service.
        /// </summary>
        [JsonProperty("Service")]
        public Service? Service { get; set; }
    }
    public class Service
    {
        /// <summary>
        /// Gets or sets service base url.
        /// </summary>
        [JsonProperty("ServiceBaseUrl")]
        public string? ServiceBaseUrl { get; set; }
    }
    public class UI
    {
        /// <summary>
        /// Gets or sets UI base url.
        /// </summary>
        [JsonProperty("UIBaseUrl")]
        public string? UIBaseUrl { get; set; }

        /// <summary>
        /// Gets or sets browser.
        /// </summary>
        [JsonProperty("Browser")]
        public string? Browser { get; set; }
    }
}