using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris
{
    class Uzduotis1
    {
        private static IWebDriver driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://testsheepnz.github.io/BasicCalculator.html#main-body";
        }

        //25 + 25.5 Integers only disabled = 50.5
        //5 + 25,5 + Integers only enabled = 30
        //1.99 + 0.959 Integers only disabled = 2.949
        //-1 + -9.99 + Integers only enabled = -10

        [TestCase("25", "25.5", "50.5", false, TestName = "25 + 25,5 Integers only disabled = 50,5")]
        [TestCase("5", "25.5", "30", true, TestName = "5 + 25,5 + Integers only enabled = 30")]
        [TestCase("1.99", "0.959", "2.949",false, TestName = "1,99 + 0,959 Integers only disabled = 2,949")]
        [TestCase("-1", "-9.99", "-10", true, TestName = "-1 + -9,99 + Integers only enabled = -10")]
        public static void TestSum(string firstValue, string secondValue, string expectedResult, bool isIntegersEnabled)
        {
            IWebElement firstInput = driver.FindElement(By.Id("number1Field"));
            firstInput.Clear();
            firstInput.SendKeys(firstValue);

            IWebElement secondInput = driver.FindElement(By.Id("number2Field"));
            secondInput.Clear();
            secondInput.SendKeys(secondValue);

            IWebElement integersOnlyCheckBox = driver.FindElement(By.Id("integerSelect"));
            if(isIntegersEnabled != integersOnlyCheckBox.Selected)
            {
                integersOnlyCheckBox.Click();
            }

            IWebElement submitButton = driver.FindElement(By.Id("calculateButton"));
            submitButton.Click();

            IWebElement actualResult = driver.FindElement(By.Id("numberAnswerField"));
            Assert.AreEqual(expectedResult, actualResult.GetAttribute("value").ToString(), "Sum is wrong!");
        }

        [OneTimeTearDown]
        public static void OneTimeTearDown()
        {
            driver.Quit();
        }

    }
}
