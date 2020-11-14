using System.Threading;
using NUnit.Framework;
using Selenium.core;
using Selenium.pages;

namespace Selenium.tests
{
    [TestFixture]
    [Parallelizable]
    public class DiceSearchTest : TestBase
    {
        [Test]
        public void TestMethod()
        {
            var page = new HomePage(Driver);
            page.OpenDicePage();
            page.SearchByJobByState("Sdet");
            page.CollectedAllFoundedJobs();
            //Thread.Sleep(1000000);
        }
    }
}