using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using SeleniumStarterKit.src.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumStarterKit.src.Pages
{
    public class BasePage
    {

        public WaitUtilities Wait;
        public IWebDriver Driver;
        public Actions actions;

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            this.Wait = new WaitUtilities(Driver);
            this.actions = new Actions(Driver);

        }

    }
}
