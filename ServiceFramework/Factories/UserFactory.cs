using ServiceFramework.Models.UserModels;
using ServiceFramework.Utilities;

namespace ServiceFramework.Factories
{
    /// <summary>
    /// User factory.
    /// </summary>
    public class UserFactory : BaseService<UserFactory>
    {
        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="job"></param>
        /// <returns></returns>
        public CreateUserRequestDto CreateUser(string name, string job)
        {
            var user = new CreateUserRequestDto()
            {
                Name = name,
                Job = job
            };

            return user;
        }
    }
}
