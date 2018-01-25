using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Autotest1
{
    [Binding]
    public class GoogleSearchVerificationSteps
    {
        IWebDriver driver;
        [Given]
        public void Given_I_am_on_Google_page()
        {
            driver = new ChromeDriver();
            driver.Url = "http://www.gogole.com";
        }
        
        [When]
        public void When_I_type_hello_world_in_Search_Box()
        {
            IWebElement ElementObj = driver.FindElement(By.Name("q"));
            
            ElementObj.SendKeys("Hello World");
            ElementObj.Submit();
        }

        [Then]
        public void Then_I_should_see_Hello_world_in_search_Box()
        {
            IWebElement ElementObj = driver.FindElement(By.Name("q"));

            string content = ElementObj.GetAttribute("value");
            Assert.AreEqual("Hello World", content);

            driver.Close();
            driver.Quit();
        }
    }
}
