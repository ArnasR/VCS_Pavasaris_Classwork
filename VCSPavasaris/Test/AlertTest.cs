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
            _alertPage.NavigateToDefaultPage();
            _alertPage.ClickFirstAlertButton();
        }
    }
}
