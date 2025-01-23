using OpenQA.Selenium;
using SeleniumStarterKit.src.Pages;
using SeleniumStarterKit.src.Utilities;

namespace SeleniumStarterKit.src.Tests
{
    public class Tests
    {


        private IWebDriver Driver;

        // Name of pages needed for test
        private VariablePage variablePage;


        [SetUp]
        public void Setup()
        {
            Driver = DriverPage.GetDriver();
            variablePage = new VariablePage(Driver);

        }

        [Test]
        public void Test1()
        {
            string url = "https://www.skool.com/breakintotech/about";
            Driver.Navigate().GoToUrl(url);

            Assert.Pass();
        }

        [TearDown]
        public void CloseBrowser()
        {
            Driver.Dispose();
            DriverPage.CloseBrowser();
        }
    }
}