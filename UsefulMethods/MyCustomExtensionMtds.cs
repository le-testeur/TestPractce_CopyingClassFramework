using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractce_CopyingClassFramework.UsefulMethods
{
    public static class MyCustomExtensionMtds
    {
        public static WebDriverWait WaitForElement(this IWebDriver driver, By locator )
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(locator)).Click();
            return waitForElement;
        }

        public static WebDriverWait WaitForElementToBeVisible(this IWebDriver driver, By locator)
        {
            WebDriverWait waitForElement = new WebDriverWait(driver, TimeSpan.FromSeconds(60));
            waitForElement.Until(ExpectedConditions.ElementIsVisible(locator));
            return waitForElement;
        }

        public static void ElementScrollintoView(this IWebDriver driver, IWebElement component)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true)", component);
        }
    }
}
