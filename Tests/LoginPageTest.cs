//using Homework_25.Models;
//using Homework_25.Pages;

//namespace Homework_25.Tests
//{
//    internal class LoginPageTest : BaseTest
//    {
//        [TestCase("standard_user", "secret_sauce", "Products")]

//        [TestCase("problem_user", "secret_sauce", "Products")]

//        [TestCase("visual_user", "secret_sauce", "Products")]

//        public void Login(string name, string password, string titleText)
//        {
//            User user = new User(name, password);
//            LoginPage.Login(user);

//            var resultText = LoginPage.GetTitleText();
//            Assert.That(resultText, Is.EqualTo(titleText));
//        }
//    }
//}
