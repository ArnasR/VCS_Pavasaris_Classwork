using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Test
{
    class AlertTest : BaseTest
    {
        [Test]
        public static void TestFirstAlert()
        {
            _alertPage.NavigateToDefaultPage()
                .ClickFirstAlertButton()
                .AcceptFirstAlert();
        }

        [Test]
        public static void TestSecondAlert()
        {
            _alertPage.NavigateToDefaultPage()
                .ClickSecondAlertButton()
                .CancelSecondAlertButton()
                .VerifySecondAlertText("Cancel");
            _demoqaSelectPage
                .NavigateToDefaultPage();
        }
    }
}
