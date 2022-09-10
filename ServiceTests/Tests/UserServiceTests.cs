using NUnit.Framework;
using ServiceFramework.Factories;
using ServiceFramework.Models.UserModels;
using ServiceFramework.Services;
using ServiceTests.TestData;
using System.Net;

namespace ServiceTests.Tests
{
    [TestFixture]
    public class UserServiceTests
    {
        HttpClient client = new HttpClient().GetClient();

        [Test]
        public void GetUsers()
        {
            //Act
            var usersResponse = UserService.Instance.GetUsersPerPage<UsersResponseDto>(client: client, page: 1);

            //Assert
            Assert.AreEqual(UserTestData.Page, usersResponse.Page);
            Assert.AreEqual(UserTestData.PerPage, usersResponse.PerPage);
            Assert.AreEqual(UserTestData.Total, usersResponse.Total);
            Assert.AreEqual(UserTestData.TotalPages, usersResponse.TotalPages);

            Assert.AreEqual(UserTestData.PerPage, usersResponse.Data.Count);

            Assert.AreEqual(UserTestData.SupportUrl, usersResponse.Support.Url);
            Assert.AreEqual(UserTestData.SupportText, usersResponse.Support.Text);
        }

        [Test]
        public void GetFirstUser()
        {
            //Act
            var usersResponse = UserService.Instance.GetUsersPerPage <UsersResponseDto>(client: client, page: 1);
            var firstUser = usersResponse.Data.First();

            //Assert
            Assert.AreEqual(UserTestData.FirstUserId, firstUser.Id);
            Assert.AreEqual(UserTestData.FirstUserEmail, firstUser.Email);
            Assert.AreEqual(UserTestData.FirstUserFirstName, firstUser.FirstName);
            Assert.AreEqual(UserTestData.FirstUserLastName, firstUser.LastName);
            Assert.AreEqual(UserTestData.FirstUserLastAvatar, firstUser.Avatar);
        }

        [Test]
        public void SortUsersByFirstNameAlphabetically()
        {
            var usersResponse = UserService.Instance.GetUsersPerPage <UsersResponseDto>(client: client, page: 1);

            var sortUsers = usersResponse.Data.OrderBy(x => x.FirstName);

            foreach (var user in sortUsers)
            {
                Console.WriteLine(user.Id);
                Console.WriteLine(user.Email);
                Console.WriteLine(user.FirstName);
                Console.WriteLine(user.LastName);
                Console.WriteLine(user.Avatar);
            } 
        }

        [Test]
        public void GetExistingUser()
        {
            //Act
            var userResponse = UserService.Instance.GetUserById<UserResponseDto>(client: client, UserTestData.FirstUserId);

            //Assert
            Assert.AreEqual(UserTestData.FirstUserId, userResponse.Data.Id);
            Assert.AreEqual(UserTestData.FirstUserEmail, userResponse.Data.Email);
            Assert.AreEqual(UserTestData.FirstUserFirstName, userResponse.Data.FirstName);
            Assert.AreEqual(UserTestData.FirstUserLastName, userResponse.Data.LastName);
            Assert.AreEqual(UserTestData.FirstUserLastAvatar, userResponse.Data.Avatar);

            Assert.AreEqual(UserTestData.SupportUrl, userResponse.Support.Url);
            Assert.AreEqual(UserTestData.SupportText, userResponse.Support.Text);
        }
        [Test]
        public void GetNonExistingUser()
        {
            //Act
            var userResponse = UserService.Instance.GetUserById<UserResponseDto>(client: client, 
                UserTestData.NonExistingUserId, expectedStatusCode: HttpStatusCode.NotFound);

            //Assert
            Assert.IsNull(userResponse.Data);
            Assert.IsNull(userResponse.Support);
        }

        [Test]
        public void CreateNewUser()
        {
            //Arange
            var userRequest = UserFactory.Instance.CreateUser(UserTestData.Name, UserTestData.Job);

            //Act
            var userResponse = UserService.Instance.CreateUser<CreateUserResponseDto>(client, userRequest);

            //Assert
            Assert.AreEqual(UserTestData.Name, userResponse.Name);
            Assert.AreEqual(UserTestData.Job, userResponse.Job);
            Assert.IsNotNull(userResponse.Id);
            Assert.IsNotNull(userResponse.CreatedAt);
        }

        [Test]
        public void DeleteUser()
        {
            //Arange
            var userRequest = UserFactory.Instance.CreateUser(UserTestData.Name, UserTestData.Job);
            var userResponse = UserService.Instance.CreateUser<CreateUserResponseDto>(client, userRequest);

            //Act
            UserService.Instance.DeleteUserById(client, userResponse.Id);
        }
    }
}
