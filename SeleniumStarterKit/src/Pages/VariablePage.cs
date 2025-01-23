using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumStarterKit.src.Pages
{
    public class VariablePage : BasePage
    {

        public VariablePage(IWebDriver driver) : base(driver)
        {
            // Empty 

        }

        // WebElements
        private By NameOfElement => By.XPath("");
        private IWebElement NameOfWebElement => Driver.FindElement(NameOfElement);



        // Methods
        public void MethodThatClicksSomething()
        {
            Wait.UntilVisible(NameOfElement);
            NameOfWebElement.Click();

        }


        // More Methods
        // ...

    }
}
