using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace VCSPavasaris.Tools
{
    class MakeScreenshot
    {
        public static void TakeScreenshot(IWebDriver webDriver)
        {
            Console.WriteLine(Assembly.GetExecutingAssembly().Location);

            Screenshot screenshot = webDriver.TakeScreenshot();

            string screenshotDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));


        }

        
       
    }
}
