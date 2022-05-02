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
    }
}
