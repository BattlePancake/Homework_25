using Homework_25.Elements;
using Homework_25.Factory;
using Homework_25.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace Homework_25.Pages
{
    internal class LoginPagePattern : BasePage
    {
        private static Element _title = new(By.XPath("//*[@data-test='title']"));

        [FindsBy(How = How.XPath, Using = "//*[@id='user-name']")]
        public IWebElement? UserNameField;

        [FindsBy(How = How.XPath, Using = "//*[@id='password']")]
        public IWebElement? PasswordField;

        [FindsBy(How = How.XPath, Using = "//*[@id='login-button']")]
        public IWebElement? LoginButton;

        public LoginPagePattern()
        {
            PageFactory.InitElements(driver, this);
        }

        public LoginPagePattern FillUserName(User user)
        {
            UserNameField.SendKeys(user.Name);
            return this;
        }

        public LoginPagePattern FillPassword(User user)
        {
            PasswordField.SendKeys(user.Password);
            return this;
        }

        public LoginPagePattern ClickLoginButton()
        {
            LoginButton.Click();
            return this;
        }

        //public override BasePage OpenURL()
        //{
        //    driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        //    return this;
        //}

        public override BasePage IsPageOpened()
        {
            WebDriverWait iWait = new(driver, TimeSpan.FromSeconds(10));
            iWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@data-test='title']")));
            return this;
        }

        public static string GetProductText() => _title.GetElementText();
    }
}
