using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Test
{
    class DemoqaSelectTest : BaseTest
    {

        [Test]
        public static void TestSelectByValue()
        {
            _demoqaSelectPage.NavigateToDefaultPage();
            _demoqaSelectPage.SelectFromDropDownByValue("6");
            _demoqaSelectPage.VerifySingleSelectResult("White");
        }

        [Test]
        public static void TestSelectByText()
        {
            _demoqaSelectPage.NavigateToDefaultPage();
            _demoqaSelectPage.SelectFromDropDownByText("Black");
            _demoqaSelectPage.VerifySingleSelectResult("Black");
        }

        [TestCase("Audi", "Volvo", "Opel")]
        public static void TestSelectMultiDropDownByText(params string[] element)
        {
            _demoqaSelectPage.NavigateToDefaultPage();
            _demoqaSelectPage.SelectMultiDropDown(element.ToList());
            _demoqaSelectPage.VerifyMultiSelectDropDown("Audi Volvo Opel");
        }
    }
}
