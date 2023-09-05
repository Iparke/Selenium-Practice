namespace TestAutomation.UI.Features
{
    [TestFixture]
    internal class LoginFeature
    {
        [SetUp] 
        public void SetUp() 
        {

        }

        [Test]
        public void UserCannotLoginWithIncorrectPassword()
        {
            Assert.True(true);
        }
    }
}
