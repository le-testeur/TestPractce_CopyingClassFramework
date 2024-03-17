using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractce_CopyingClassFramework.BrowserFolder;
using TestPractce_CopyingClassFramework.DriverFolder;

namespace TestPractce_CopyingClassFramework.UsefulMethods
{
    public class MyMethods : BaseDriver
    {
        jsConfigClass jsClass = new jsConfigClass();
        //public IWebDriver driver;
        public void NavigateToDemoqaSite(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(jsClass.GetJsonData("env:DemoqaSite"));
        }

        public IWebElement FindMyElement(IWebDriver driver, By locator)
        {
            IWebElement element = driver.FindElement(locator);
            return element; 
        }

    }
}
