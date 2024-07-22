//using Homework_25.Elements;
//using Homework_25.Models;
//using OpenQA.Selenium;

//namespace Homework_25.Pages
//{
//    internal class LoginPage : BasePage
//    {
//        private static Element _userNameField = new Element(By.XPath("//*[@id='user-name']"));
//        private static Element _passwordField = new(By.XPath("//*[@id='password']"));
//        private static Element _loginButton = new(By.XPath("//*[@id='login-button']"));

//        private static Element _title = new(By.XPath("//*[@data-test='title']"));

//        public static void Login(User user)
//        {
//            _userNameField.SendValue(user.Name);
//            _passwordField.SendValue(user.Password);
//            _loginButton.ClickElement();
//        }

//        public static string GetTitleText() => _title.GetElementText();
//    }
//}