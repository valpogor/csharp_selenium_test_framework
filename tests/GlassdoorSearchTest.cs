using System.Threading;
using NUnit.Framework;
using Selenium.core;
using Selenium.pages;

namespace Selenium.tests
{
    [TestFixture]
    [Parallelizable]
    public class GlassdoorSearchTest : TestBase
    {
        [Test]
        public void TestMethod()
        {
            var page = new HomePage(Driver);
            page.OpenGlassdoorPage();
            page.SearchByJobByState("Sdet");
            page.CollectedAllFoundedJobs();
            //Thread.Sleep(1000000);

        }
    }
}