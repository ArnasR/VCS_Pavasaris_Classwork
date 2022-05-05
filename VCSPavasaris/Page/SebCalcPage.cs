using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Page
{
    class SebCalcPage : BasePage
    {
        private const string PageAddress = "https://www.seb.lt/privatiems/kreditai/busto-kreditas";

        private IWebElement _incomeInput => Driver.FindElement(By.Id("income"));
        private SelectElement _city => new SelectElement(Driver.FindElement(By.Id("city")));
        private IWebElement _calculateButton => Driver.FindElement(By.Id("calculate"));
        private IWebElement _resultTextElement => Driver.FindElement(By.CssSelector("#mortgageCalculatorStep2 > div.row > div > div:nth-child(5) > div > strong"));

        public SebCalcPage(IWebDriver webDriver) : base(webDriver) { }

        public SebCalcPage NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;

            return this;
        }

        public SebCalcPage InsertIncome(string income)
        {
            _incomeInput.Clear();
            _incomeInput.SendKeys(income);

            return this;
        }

        public SebCalcPage SelectFromCityDropDownByValue(string value)
        {
            _city.SelectByValue(value);

            return this;
        }

        public SebCalcPage ClickCalculateButton()
        {
            _calculateButton.Click();

            return this;
        }


    }
}
