using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPractce_CopyingClassFramework.BrowserFolder;
using TestPractce_CopyingClassFramework.POMPagesDemoqa;
using TestPractce_CopyingClassFramework.UsefulMethods;

namespace TestPractce_CopyingClassFramework.POM_TestClass
{
    public class RunTests1 : BrowserClass
    {
        LoginPage lpage;
        BooksPage bpage;
        public RunTests1()
        {
            driver = ReActivateMyDriver();
            lpage = new LoginPage(driver);
            bpage = new BooksPage(driver);
        }

        [Test]
        public void RunDemoqaTests()
        {
            lpage.GoToDemoqaLoginSite();
            lpage.LoginToFields();

            bpage.CaptureUserName();
            confirmUserNameAssertion = bpage.UserNameIsDisplayed();
            Assert.That()
          
        }
    }
}
