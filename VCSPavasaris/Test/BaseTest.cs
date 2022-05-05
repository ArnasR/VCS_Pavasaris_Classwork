using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSPavasaris.Drivers;
using VCSPavasaris.Page;
using VCSPavasaris.Tools;

namespace VCSPavasaris.Test
{
    class BaseTest
    {
        //Kill all chrome instances using CMD: taskkill /F /IM chromedriver.exe /T

        protected static IWebDriver Driver;

        public static DemoqaTextBoxPage _demoqaTextBoxPage;
        public static DemoqaCheckBoxPage _demoqaCheckBoxPage;
        public static DemoqaSelectPage _demoqaSelectPage;
        public static SenukaiPage _senukaiPage;


        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            Driver = CustomDriver.GetChromeDriver();

            _demoqaTextBoxPage = new DemoqaTextBoxPage(Driver);
            _demoqaCheckBoxPage = new DemoqaCheckBoxPage(Driver);
            _demoqaSelectPage = new DemoqaSelectPage(Driver);
            _senukaiPage = new SenukaiPage(Driver);
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
         // Driver.Quit();
        }

        [TearDown]
        public static void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                MakeScreenshot.TakeScreenshot(Driver);
            }
        }

    }
}
