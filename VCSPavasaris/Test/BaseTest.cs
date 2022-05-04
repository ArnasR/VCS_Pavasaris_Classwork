using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSPavasaris.Drivers;
using VCSPavasaris.Page;

namespace VCSPavasaris.Test
{
    class BaseTest
    {
        protected static IWebDriver Driver;

        public static DemoqaTextBoxPage _demoqaTextBoxPage;
        public static DemoqaCheckBoxPage _demoqaCheckBoxPage;
        public static DemoqaSelectPage _demoqaSelectPage;


        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _demoqaTextBoxPage = new DemoqaTextBoxPage(Driver);
            _demoqaCheckBoxPage = new DemoqaCheckBoxPage(Driver);
            _demoqaSelectPage = new DemoqaSelectPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
          Driver.Quit();
        }

    }
}
