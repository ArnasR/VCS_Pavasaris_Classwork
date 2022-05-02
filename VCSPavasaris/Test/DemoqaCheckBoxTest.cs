using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using VCSPavasaris.Page;

namespace VCSPavasaris.Test
{
    class DemoqaCheckBoxTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            _driver.Quit();
        }

        [Test]
        public static void TestExpandAllButton()
        {
            DemoqaCheckBoxPage checkBoxPage = new DemoqaCheckBoxPage(_driver);

            checkBoxPage.NavigateToDefaultPage();
            checkBoxPage.ClosePopUp();
            checkBoxPage.ClickExpandAllButton();
        }

    }
}
