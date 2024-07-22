using Homework_25.Factory;
using OpenQA.Selenium;

namespace Homework_25.Pages
{
    internal abstract class BasePage
    {
        protected static IWebDriver driver => Driver.GetDriver();


        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        public static void Refresh() => Driver.GetDriver().Navigate().Refresh();

        public abstract BasePage IsPageOpened();
        //public abstract BasePage OpenURL();
    }
}
