using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Test
{
    class SebCalcTest : BaseTest
    {
        [Test]
        public static void TestLoanCalculator()
        {
            _sebCalcPage.NavigateToDefaultPage()
                .InsertIncome("1000")
                .SelectFromCityDropDownByValue("Klaipeda")
                .ClickCalculateButton()
                .CheckIfICanGetLoan("79 105");
        }
    }
}
