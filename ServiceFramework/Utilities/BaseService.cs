using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;
using System.Text;

namespace ServiceFramework.Utilities
{
    /// <summary>
    /// Base Singleton Lazy.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class BaseService<T>
        where T : new()
    {
        private static readonly Lazy<T> lazy = new Lazy<T>(() => new T());

        public static T Instance => lazy.Value;

        /// <summary>
        /// Get Async.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="url"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public T GetAsync<T>(HttpClient client, string url, HttpStatusCode expectedStatusCode)
            where T : class, new()
        {
            var response = client.GetAsync(url);

            Assert.AreEqual(expectedStatusCode, response.Result.StatusCode);

            var responseAsString = response.Result.Content.ReadAsStringAsync().Result;
            var articleUsers = JsonConvert.DeserializeObject<T>(responseAsString);

            return articleUsers;
        }

        /// <summary>
        /// Post async.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="url"></param>
        /// <param name="request"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public T PostAsync<T>(HttpClient client, string url, object request, HttpStatusCode expectedStatusCode)
            where T : class, new()
        {
            var userAsString = JsonConvert.SerializeObject(request);
            var response = client.PostAsync(url, new StringContent(userAsString, Encoding.UTF8, "application/json"));

            Assert.AreEqual(expectedStatusCode, response.Result.StatusCode);

            var responseAsString = response.Result.Content.ReadAsStringAsync().Result;
            var articleUsers = JsonConvert.DeserializeObject<T>(responseAsString);

            return articleUsers;
        }
        /// <summary>
        /// Delete async.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="url"></param>
        /// <param name="expectedStatusCode"></param>
        public void DeleteAsync(HttpClient client, string url, HttpStatusCode expectedStatusCode)
        {
            var response = client.DeleteAsync(url);

            Assert.AreEqual(expectedStatusCode, response.Result.StatusCode);
        }
    }
}
