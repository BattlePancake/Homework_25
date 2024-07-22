using Homework_25.Factory;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Homework_25.Elements
{
    internal class Element
    {
        private readonly By? _locator;
        private Actions actions = new Actions(Driver.GetDriver());

        public Element(By locator) => _locator = locator;

        public IWebElement FindWebElement
        {
            get
            {
                WaitWebElementPresent();
                return Driver.GetDriver().FindElement(_locator);
            }
        }

        public void WaitWebElementPresent() => Driver.GetWait(Driver.GetDriver()).Until(drv => 
        drv.FindElements(_locator).Count() > 0);

        public void SendValue(string value)
        {
            ScrollToElement();
            FindWebElement.SendKeys(value);
        }

        public void ClickElement()
        {
            ScrollToElement();
            FindWebElement.Click();
        }

        public string GetElementAttribute(string atr) => FindWebElement.GetAttribute(atr);

        public void ScrollToElement() => actions.MoveToElement(FindWebElement);

        public string GetElementText() => FindWebElement.Text;


    }
}