using TestConfiguration;

namespace ServiceFramework.Services
{
    /// <summary>
    /// Client.
    /// </summary>
    public static class Client
    {
        /// <summary>
        /// Get client.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="baseAddress"></param>
        /// <returns></returns>
        public static HttpClient GetClient(this HttpClient client, string baseAddress = null)
        {
            if (baseAddress == null)
                baseAddress = Configurator.Settings.Service.ServiceBaseUrl;

            client.BaseAddress = new Uri(baseAddress);

            return client;
        }
    }
}
