using System;
using Selenium.core.browsers;
using OpenQA.Selenium;
using System.Collections.Generic;
using Selenium.core;

namespace Selenium.pages
{
    public class HomePage
    {
        private readonly IBrowser _browser;

        public HomePage(IBrowser browser)
        {
            _browser = browser;
        }

        public RegisterPage OpenGlassdoorPage()
        {
            Console.WriteLine("Navigating to Glassdoor page");
            _browser.Page.GoToUrl("https://www.glassdoor.com/sitedirectory/title-jobs.htm");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenIndeedPage()
        {
            Console.WriteLine("Navigating to Indeed page");
            _browser.Page.GoToUrl("https://www.indeed.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenDicePage()
        {
            Console.WriteLine("Navigating to Dice page");
            _browser.Page.GoToUrl("https://www.dice.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage OpenMonsterPage()
        {
            Console.WriteLine("Navigating to Monster page");
            _browser.Page.GoToUrl("https://www.monster.com");
            return new RegisterPage(_browser);
        }

        public RegisterPage SearchByJobByState(String jobs)
        {
            Console.WriteLine("Search By Job");
            _browser.Page.FindElement(By.XPath("//input[contains(@placeholder, 'itle')]")).SendKeys(jobs);
            _browser.Page.FindElement(By.XPath("//input[contains(@placeholder, 'itle')]")).SendKeys(Keys.Enter);
            return new RegisterPage(_browser);
        }

        public RegisterPage CollectedAllFoundedJobs()
        {
            Console.WriteLine("Collected founded All Jobs");

            IList<IWebElement> positions = _browser.Page.FindAllElements(By.XPath("//a[contains(@class, 'title')]"));
            IList<IWebElement> companies = _browser.Page.FindAllElements(By.XPath("//a[contains(@class, 'inserted')]"));
            IList<IWebElement> companies2 = _browser.Page.FindAllElements(By.XPath("//*[contains(@class, 'company')]"));
            IList<IWebElement> location = _browser.Page.FindAllElements(By.XPath("//a[contains(@id, 'ocation')]"));

            List<string> pos = new List<string>();
            List<string> com = new List<string>();
            List<string> com2 = new List<string>();
            List<string> loc = new List<string>();
            foreach (IWebElement element in positions)
            {
                pos.Add(element.Text);
                Console.WriteLine(element.Text);
            }
            foreach (IWebElement element in companies)
            {
                com.Add(element.Text);
                Console.WriteLine(element.Text);
            }
            foreach (IWebElement element in companies2)
            {
                com2.Add(element.Text);
                Console.WriteLine(element.Text);
            }
            foreach (IWebElement element in location)
            {
                loc.Add(element.Text);
                Console.WriteLine(element.Text);
            }
            Logger.WriteLine("==========================================================");
            Logger.Write("Loading 'AttendPunch'".PadRight(35, '.'));
            Logger.WriteLine("OK.");

            Logger.SaveLog(true);

            return new RegisterPage(_browser);
        }
    }
}