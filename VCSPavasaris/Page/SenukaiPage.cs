using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Page
{
    class SenukaiPage : BasePage
    {
        private const string PageAddress = "https://www.senukai.lt/";

        public SenukaiPage(IWebDriver webDriver) : base(webDriver) { }

        public void NavigateToDefaultPage()
        {
            Driver.Url = PageAddress;
        }

        public static void AcceptCookies()
        {
            Cookie myCookie = new Cookie("CookieConsent",
                "{stamp:%27fa7QLrJfcVzeg80fv+nbGa59CfBADoTKaRo762aGTDKkyw/JEv1TEw==%27%2Cnecessary:true%2Cpreferences:true%2Cstatistics:false%2Cmarketing:true%2Cver:1%2Cutc:1651766507961%2Cregion:%27lt%27}",
                "www.senukai.lt",
                "/",
                DateTime.Now.AddDays(5));
        }

    }
}
