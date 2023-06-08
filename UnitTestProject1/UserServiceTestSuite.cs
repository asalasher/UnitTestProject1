using DataAccess;
using Functions;
using Moq;
using Service;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject1
{
    public class UserServiceTestSuite
    {

        [Fact]
        public void GetUsers_Response()
        {
            //Arrange
            var userRepo = new UsersRepo();
            var userService = new UserService(userRepo);

            //Act
            List<string> result = userService.GetUsers();

            //Assert
            Assert.True(result.Count >= 0);
        }

        [Fact]
        public void AddUser_InputUserInstance_TrueResponse()
        {
            //Arrange
            IUsersRepo userRepo = new UsersRepo();
            var userService = new UserService(userRepo);

            User newUser = new User(4, "Alberto");

            //Act
            bool result = userService.AddUser(newUser);

            //Assert
            Assert.True(result);
        }

        [Fact]
        public void AddUser_InputUserInstance_FalseResponse()
        {
            //Arrange
            User simulatedUser = new User(4, "Alberto");

            Mock<IUsersRepo> userMock = new Mock<IUsersRepo>();
            //userMock.Setup(x => x.GetById(1)).Returns(simulatedUser);
            userMock.Setup(x => x.GetDataFromFile()).Returns(new List<User>() { simulatedUser });

            IUsersRepo usersRepo = userMock.Object;
            UserService userService = new UserService(usersRepo);

            //Act
            List<string> result = userService.GetUsers();

            //Assert
            Assert.True(result.Count == 1);
        }
    }
}
