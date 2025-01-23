using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumStarterKit.src.Utilities
{
    public class WaitUtilities
    {


        public IWebDriver Driver;
        private WebDriverWait Wait;

        public WaitUtilities(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WebDriverWait(driver, TimeSpan.FromSeconds(40));
        }


        public void UntilVisible(By locator)
        {
            Wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }


    }
}
