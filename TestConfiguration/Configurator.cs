using Microsoft.Extensions.Configuration;


namespace TestConfiguration
{
    /// <summary>
    /// Configurator.
    /// </summary>
    public static class Configurator
    {
        /// <summary>
        /// Gets or sets test settings.
        /// </summary>
        public static TestSettings? Settings { get; set; }

        /// <summary>
        /// Create test settings.
        /// </summary>
        /// <returns></returns>
        public static TestSettings Create()
        {
            var path = TryGetSolutionDirectoryInfo().FullName;
            var builder = new ConfigurationBuilder()
                .SetBasePath(path)
                .AddJsonFile("testsettings.json");

            IConfigurationRoot configurationRoot = builder.Build();


            Settings = new TestSettings()
            {
                UI = new UI()
                {
                    UIBaseUrl = configurationRoot.GetSection("testSettings").GetSection("UI").GetSection("UIBaseUrl").Value,
                    Browser = configurationRoot.GetSection("testSettings").GetSection("UI").GetSection("Browser").Value,
                },
                Service = new Service()
                {
                    ServiceBaseUrl = configurationRoot.GetSection("testSettings").GetSection("Service").GetSection("ServiceBaseUrl").Value
                }
            };

            return Settings;
        }

        /// <summary>
        /// Try get solution directory info.
        /// </summary>
        /// <param name="currentPath"></param>
        /// <returns></returns>
        private static DirectoryInfo TryGetSolutionDirectoryInfo(string? currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());
            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }
            return directory;
        }
    }
}
