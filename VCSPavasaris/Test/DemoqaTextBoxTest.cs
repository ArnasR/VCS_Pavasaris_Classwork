using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSPavasaris.Page;

namespace VCSPavasaris.Test
{
    class DemoqaTextBoxTest : BaseTest
    {
        [Test]
        public static void TestFullNameInputField()
        {
            string fullName = "Arnas";

            _demoqaTextBoxPage.NavigateToDefaultPage();
            _demoqaTextBoxPage.InsertTextToFullNameField(fullName);
            _demoqaTextBoxPage.ClickSubmitButton();

            _demoqaTextBoxPage.VerifyFullNameResult(fullName);
        }
    }
}
