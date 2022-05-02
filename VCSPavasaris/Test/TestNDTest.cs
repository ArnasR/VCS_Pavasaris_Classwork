using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VCSPavasaris.Page;

namespace VCSPavasaris.Test
{
    class TestNDTest : BaseTest
    {
        [Test]
        public static void ExampleTest()
        {
            testNDPage testNDPage = new testNDPage(Driver);

            testNDPage.NavigateToDefaultPage();
            testNDPage.ClosePopUp();
            testNDPage.ClickExpandAllButton();

        }

    }
}
