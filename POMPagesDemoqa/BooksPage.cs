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
    public class BooksPage : BasePageClass
    {
        public BooksPage(IWebDriver driver) : base(driver)
        {
        }

        IWebElement validateUserName => driver.FindElement(By.Id("userName-value"));

        public void CaptureUserName()
        {
            driver.WaitForElementToBeVisible(By.Id("userName-value"));
            Console.WriteLine(validateUserName.Text);
        }

        public bool UserNameIsDisplayed() => validateUserName.Displayed;


  
        
        //public bool ValidateUserName()
        //{
            
        //    //IWebElement userName = new MyMethods().FindMyElement(driver,
        //    //    By.XPath("(//label[@class='form-label'])[.='TestUser']"));
        //    driver.WaitForElementToBeVisible(By.XPath("(//label[@class='form-label'])[.='TestUser']"));
        //    return userName.Displayed;
            
        //}
       

        //public string ValidateUserName()
        //{
        //    var isUserNameDisplayed = new MyMethods().FindMyElement(driver, By.XPath("(//label[@class='form-label'])[3]))"));
        //    Thread.Sleep(2000);
        //    return isUserNameDisplayed.Text;
           
            
        //}
    }
}
