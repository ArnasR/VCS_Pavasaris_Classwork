using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OpenQA.Selenium;

namespace VCSPavasaris.Tools
{
    class MakeScreenshot
    {
        public static void TakeScreenshot(IWebDriver webDriver)
        {
            Console.WriteLine(Assembly.GetExecutingAssembly().Location);
            string a = Assembly.GetExecutingAssembly().Location.ToString();

        }

        
       
    }
}
