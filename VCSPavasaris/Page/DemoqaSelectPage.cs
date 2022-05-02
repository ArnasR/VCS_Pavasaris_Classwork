﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace VCSPavasaris.Page
{
    class DemoqaSelectPage : BasePage
    {
        private const string PageAddress = "https://demoqa.com/select-menu";

        private static IWebElement _popup => Driver.FindElement(By.Id("close-fixedban"));
        private SelectElement _dropDown => new SelectElement(Driver.FindElement(By.Id("oldSelectMenu")));
        private SelectElement _multiDropDown => new SelectElement(Driver.FindElement(By.Id("cars")));

        public DemoqaSelectPage(IWebDriver webdriver) : base(webdriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public void ClosePopUp()
        {
            GetWait(10).Until(d => _popup.Displayed);
            _popup.Click();
        }
    }
}