using System.Threading;
using NUnit.Framework;
using Selenium.core;
using Selenium.pages;

namespace Selenium.tests
{
    [TestFixture]
    [Parallelizable]
    public class IndeedSearchTest : TestBase
    {
        [Test]
        public void TestMethod()
        {
            var page = new HomePage(Driver);
            page.OpenIndeedPage();
            page.SearchByJobByState("Sdet");
            page.CollectedAllFoundedJobs();
            //Thread.Sleep(1000000);

        }
    }
}