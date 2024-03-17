using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractce_CopyingClassFramework.DriverFolder
{
    public class BasePageClass
    {
        public IWebDriver driver;
        public BasePageClass(IWebDriver driver)
        {
            this.driver = driver;
        }
    }
}
