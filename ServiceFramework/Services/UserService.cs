using ServiceFramework.Endpoints;
using ServiceFramework.Models.UserModels;
using ServiceFramework.Utilities;
using System.Net;

namespace ServiceFramework.Services
{
    /// <summary>
    /// User service.
    /// </summary>
    public class UserService : BaseService<UserService>
    {
        /// <summary>
        /// Get users per page.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="page"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public T GetUsersPerPage<T>(HttpClient client, int page, 
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
                where T : class, new()
        {
            return  GetAsync<T>(client, UserEndpoints.Instance.GetUsersPerPage(page), expectedStatusCode);
        }

        /// <summary>
        /// Get user by id.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="id"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public T GetUserById<T>(HttpClient client, int id,
            HttpStatusCode expectedStatusCode = HttpStatusCode.OK)
                where T : class, new()
        {
            return GetAsync<T>(client, UserEndpoints.Instance.GetUserById(id), expectedStatusCode);
        }

        /// <summary>
        /// Create user.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="client"></param>
        /// <param name="user"></param>
        /// <param name="expectedStatusCode"></param>
        /// <returns></returns>
        public T CreateUser<T>(HttpClient client, CreateUserRequestDto user,
            HttpStatusCode expectedStatusCode = HttpStatusCode.Created)
                where T : class, new()
        {
            return PostAsync<T>(client, UserEndpoints.Instance.CreatetUser(), user, expectedStatusCode);
        }

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="id"></param>
        /// <param name="expectedStatusCode"></param>
        public void DeleteUserById(HttpClient client, int id, HttpStatusCode expectedStatusCode = HttpStatusCode.NoContent)
        {
            DeleteAsync(client, UserEndpoints.Instance.DeleteUserById(id), expectedStatusCode);
        }  
    }
}
