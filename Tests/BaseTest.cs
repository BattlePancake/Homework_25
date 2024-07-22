using Homework_25.Factory;
using Homework_25.Pages;

namespace Homework_25.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            BasePage.OpenPage();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
