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

        private static IWebElement _popup => Driver.FindElement(By.Id("close-fixedban"));

        private IReadOnlyCollection<IWebElement> _checkBoxes => Driver.FindElements(By.ClassName("rct-text"));

        private IWebElement _actualResult => Driver.FindElement(By.Id("result"));

        public DemoqaCheckBoxPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();
        }

        public void ClickExpandAllButton()
        {
            _expandAllButton.Click();
        }

        public void ClickOnTwoCheckBoxes(string firstChoice, string secondChoice)
        {
            foreach (IWebElement checkBox in _checkBoxes)
            {
                IWebElement checkBoxElement = checkBox.FindElement(By.ClassName("rct-checkbox"));

                if (checkBox.Text.Equals(firstChoice))
                {
                    checkBoxElement.Click();
                }
                if (checkBox.Text.Equals(secondChoice))
                {
                    checkBoxElement.Click();
                }
            }
        }

        public void VerifyResults(string expectedResult)
        {
            string testResult = _actualResult.Text;

            Assert.IsTrue(_actualResult.Text.Contains(expectedResult), "Result is Incorrect");
        }

    }
}
