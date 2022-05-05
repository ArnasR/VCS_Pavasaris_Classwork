using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Drivers
{
    class CustomDriver
    {
        public static IWebDriver GetChromeDriver()
        {
           return GetDriver(Browsers.Chrome);
        }

        public static IWebDriver GetFirefoxDriver()
        {
            return GetDriver(Browsers.Firefox);
        }

        public static IWebDriver GetIncognitoChrome()
        {
            return GetDriver(Browsers.IncognitoChrome);
        }

        private static IWebDriver GetDriver(Browsers browser)
        {
            IWebDriver webDriver = null;

            switch (browser)
            {
                case Browsers.Chrome:
                    webDriver = new ChromeDriver();
                    break;
                case Browsers.Firefox:
                    webDriver = new FirefoxDriver();
                    break;
                case Browsers.IncognitoChrome:
                    webDriver = GetChromeWithIncognitoOption();
                    break;
                default:
                    webDriver = new ChromeDriver();
                    break;
            }

            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            webDriver.Manage().Window.Maximize();

            return webDriver;
        }

        private static IWebDriver GetChromeWithIncognitoOption()
        {
            ChromeOptions options = new ChromeOptions();

           // options.AddArgument("incognito");
            options.AddArguments("headless", "incognito");

            return new ChromeDriver(options);
        }

    }
}
