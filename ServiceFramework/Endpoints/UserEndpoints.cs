using ServiceFramework.Utilities;

namespace ServiceFramework.Endpoints
{
    /// <summary>
    /// User endpoints
    /// </summary>
    public class UserEndpoints : BaseService<UserEndpoints>
    {
        /// <summary>
        /// Gets article users per page.
        /// </summary>
        /// <param name="page"></param>
        /// <returns></returns>
        public string GetUsersPerPage(int page)
            => $"users?page={page}";


        /// <summary>
        /// Get user by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUserById(int id)
            => $"users/{id}";

        /// <summary>
        /// Create user.
        /// </summary>
        /// <returns></returns>
        public string CreatetUser()
            => $"users";

        public string DeleteUserById(int id)
            => $"users/{id}";
    }
}
