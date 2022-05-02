using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Page
{
    class testNDPage : BasePage
    {
        private IWebElement _expandAllButton => Driver.FindElement(By.CssSelector("button.rct-option:nth-child(1)"));
        //IWebElement submitButton = driver.FindElement(By.CssSelector("button.rct-option:nth-child(1)"));
        //submitButton.Click();

        //    // paspaudzia command
        //IWebElement submitButton1 = driver.FindElement(By.CssSelector("li.rct-node-leaf:nth-child(2) > span:nth-child(1) > label:nth-child(2)"));
        //submitButton1.Click();


        public testNDPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = "https://demoqa.com/checkbox";
        }
        public void ClosePopUp()
        {
            IWebElement poppup = Driver.FindElement(By.Id("close-fixedban"));
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));
            wait.Until(d => poppup.Displayed);
            poppup.Click();
        }

        public void ClickExpandAllButton()
        {
            _expandAllButton.Click();
        }

    }
}
