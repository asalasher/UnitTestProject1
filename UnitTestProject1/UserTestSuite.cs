using Functions;
using Xunit;

namespace UnitTestProject1
{
    public class UserTestSuite
    {

        public User User { get; set; }

        public UserTestSuite()
        {
            User = new User(1, "Alberto");
        }

        [Fact]
        public void AddPoints_PositiveInt_TrueResponse()
        {
            //Arrange

            //Act
            bool result = User.AddPoints(1);

            //Assert
            Assert.True(result);
            Assert.Equal(1, User.Points);

        }

        [Fact]
        public void AddPoints_InputZero_FalseResponse()
        {
            //Arrange

            //Act
            bool result = User.AddPoints(0);

            //Assert
            Assert.False(result);
            Assert.Equal(0, User.Points);

        }

    }
}
