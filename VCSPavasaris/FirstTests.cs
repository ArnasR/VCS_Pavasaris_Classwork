using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace VCSPavasaris
{
    class FirstTests
    {
        [Test]
        public static void TestIf4IsEven()
        {
            int leftOver = 4 % 2;

            Assert.AreEqual(0, leftOver, "4 Is not even");
        }

        [Test]
        public static void TestNowIs19()
        {
            DateTime currentTime = DateTime.Now;

            Assert.AreEqual(20, currentTime.Hour, "Dabar Ne 19 valanda");
        }

        [Test]
        public static void TestIf995IsEven()
        {
            int leftOver = 995 % 3;
            Assert.AreEqual(0, leftOver, "Someting went wrong");
        }

        [Test]
        public static void TestIfTodayIsMonday()
        {
            DateTime currentTime = DateTime.Now;
            Assert.AreEqual(DayOfWeek.Monday, currentTime.DayOfWeek, "Today Is not Monday");
        }

        [Test]
        public static void TestWait()
        {
            Thread.Sleep(2000);
        }
    }
}
