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

        [Test]
        public static void FailingTest()
        {
            _demoqaCheckBoxPage.NavigateToDefaultPage();
            Assert.IsTrue(false);
        }
    }
}
