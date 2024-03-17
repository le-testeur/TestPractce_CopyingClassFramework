using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractce_CopyingClassFramework.DriverFolder;
using TestPractce_CopyingClassFramework.UsefulMethods;

namespace TestPractce_CopyingClassFramework.POMPagesDemoqa
{
    public class LoginPage : BasePageClass
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        //IWebElement findMultipleLoginButtons => driver.FindElements(By.Id("login")).ElementAt(5);
        IWebElement userNameField => new MyMethods().FindMyElement(driver, By.CssSelector("#userName"));
        IWebElement passWordField => new MyMethods().FindMyElement(driver, By.CssSelector("#password"));
        IWebElement loginButton => new MyMethods().FindMyElement(driver, By.CssSelector("#login"));


        public void GoToDemoqaLoginSite() => new MyMethods().NavigateToDemoqaSite(driver);

        public void LoginToFields()
        {
            driver.ElementScrollintoView(userNameField);
            userNameField.SendKeys(new jsConfigClass().GetJsonData("env:Username"));
            passWordField.SendKeys(new jsConfigClass().GetJsonData("env:Password"));
            loginButton.Click();
        }

        //public void WaitForConsentButtonAndClick() 
        //{ 
           //driver.WaitForElement(By.XPath("//button//p[contains(text(),'Consent')]"));
            
        //} 

        //public void EnterUserName() 
        //{
            
        //    var userNameField = new MyMethods().FindMyElement(driver, By.CssSelector("#userName"));
        //    userNameField.SendKeys(new jsConfigClass().GetJsonData("env:Username"));
        //}

        public void EnterUsernameAndPassword()
        {
            driver.ElementScrollintoView(userNameField);
            userNameField.SendKeys(new jsConfigClass().GetJsonData("env:Username"));
            passWordField.SendKeys(new jsConfigClass().GetJsonData("env:Password"));
        }

        public void ClickLoginButton() 
        {
            var findLoginButton = new MyMethods().FindMyElement(driver, By.CssSelector("#login"));
            findLoginButton.Click();
        }

        //public IWebElement ClickLoginButton(IWebDriver driver, By locator)
        //{
        //    var findMultipleLoginButtons = driver.FindElements(By.Id("login")).ElementAt(5);
        //    findMultipleLoginButtons.Click();
        //    return findMultipleLoginButtons;

        //}
    }
}
