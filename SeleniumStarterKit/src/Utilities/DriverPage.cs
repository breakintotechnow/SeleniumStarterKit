using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumStarterKit.src.Utilities
{
    public class DriverPage
    {

        private static IWebDriver Driver;

        public static IWebDriver GetDriver()
        {

            if (Driver == null)
            {
                InitializeDriver();
            }

            return Driver;

        }


        public static void InitializeDriver()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--incognito");

            Driver = new ChromeDriver(options);

        }

        public static void CloseBrowser()
        {

            if (Driver != null)
            {

                Driver.Quit();
                Driver = null;
            }
        }
    }
}
