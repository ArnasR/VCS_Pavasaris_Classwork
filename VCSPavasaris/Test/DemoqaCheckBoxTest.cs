using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using VCSPavasaris.Page;

namespace VCSPavasaris.Test
{
    class DemoqaCheckBoxTest : BaseTest
    {
        [Test]
        public static void TestExpandAllButton()
        {
            _demoqaCheckBoxPage.NavigateToDefaultPage();
            _demoqaCheckBoxPage.ClosePopUp();
            _demoqaCheckBoxPage.ClickExpandAllButton();
        }

        [TestCase("Desktop", "Downloads", "\r\ndesktop\r\nnotes\r\ncommands\r\ndownloads\r\nwordFile\r\nexcelFile", TestName = "Desktop, Downloads")]
        [TestCase("Notes", "General", "\r\nnotes\r\ngeneral", TestName = "Notes, General")]
        public static void TestCheckBox2(string firstChoice, string secondChoice, string result)
        {
            _demoqaCheckBoxPage.NavigateToDefaultPage();
            _demoqaCheckBoxPage.ClickExpandAllButton();
            _demoqaCheckBoxPage.ClickOnTwoCheckBoxes(firstChoice, secondChoice);
            _demoqaCheckBoxPage.VerifyResults(result);
        }
    }
}
