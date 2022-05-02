using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Page
{
    class DemoqaCheckBoxPage : BasePage
    {
        private const string PageAddress = "https://demoqa.com/checkbox";

        private IWebElement _expandAllButton => Driver.FindElement(By.CssSelector("#tree-node > div > button.rct-option.rct-option-expand-all"));
        
        public DemoqaCheckBoxPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void ClickExpandAllButton()
        {
            _expandAllButton.Click();
        }

    }
}
