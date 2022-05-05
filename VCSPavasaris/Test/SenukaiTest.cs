using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VCSPavasaris.Test
{
    class SenukaiTest : BaseTest
    {
        [Test]
        public static void AcceptCokies()
        {
            _senukaiPage.NavigateToDefaultPage();
            _senukaiPage.AcceptCookies();
        }
    }
}
