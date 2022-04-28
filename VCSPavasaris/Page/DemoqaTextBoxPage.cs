using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Page
{
    class DemoqaTextBoxPage
    {
        private static IWebDriver _driver;

        private static IWebElement _fullNameInput => _driver.FindElement(By.Id("userName"));
        private static IWebElement submitButton => _driver.FindElement(By.CssSelector("#submit"));
        private static IWebElement nameResult => _driver.FindElement(By.Id("name"));
        private static IWebElement popup => _driver.FindElement(By.Id("close-fixedban"));

        public DemoqaTextBoxPage(IWebDriver webDriver)
        {
            _driver = webDriver;
        }



    }
}