using Homework_25.Models;
using Homework_25.Pages;

namespace Homework_25.Tests
{
    internal class LoginPatternTest : BaseTest
    {
        [TestCase("standard_user", "secret_sauce", "Products")]

        [TestCase("problem_user", "secret_sauce", "Products")]

        [TestCase("visual_user", "secret_sauce", "Products")]

        public void Login(string name, string password, string titleText)
        {
            LoginPagePattern loginPagePattern = new();
            User user = new User(name, password);

            loginPagePattern
                .FillUserName(user)
                .FillPassword(user)
                .ClickLoginButton()
                .IsPageOpened();

            var resultText = LoginPagePattern.GetProductText();
            Assert.That(resultText, Is.EqualTo(titleText));
        }
    }
}
 