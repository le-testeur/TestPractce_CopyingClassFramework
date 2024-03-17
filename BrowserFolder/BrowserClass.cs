using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TestPractce_CopyingClassFramework.DriverFolder;

namespace TestPractce_CopyingClassFramework.BrowserFolder
{
    public enum BrowserTypes
    {
        Chrome,
        Firefox,
        Edge,
    }

    public class BrowserClass : BaseDriver
    {
        //CrossBrowser Testing
        [SetUp]
        public void Setup()
        {
            ReActivateMyDriver();
            //driver = SelectBrowser(BrowserTypes.Chrome, chromeOptions(), null, null);
        }

        public IWebDriver SelectBrowser(BrowserTypes browsertype, ChromeOptions coptions, FirefoxOptions foptions = null, EdgeOptions eoptions = null)
        {
            return browsertype == BrowserTypes.Chrome
                ? driver = new ChromeDriver(coptions)
                : browsertype == BrowserTypes.Firefox
                ? driver = new FirefoxDriver(foptions)
                : browsertype == BrowserTypes.Edge
                ? driver = new EdgeDriver(eoptions)
                : throw new NoSuchDriverException("driver does not exist");
        }

        public ChromeOptions chromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("-start-maximized", "-incognito");
            options.AddArgument("disable-infobars");
            options.AddExcludedArgument("enable automation");
            return options;
        }

        public FirefoxOptions firefoxOptions()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("height = 1080", "width = 1920");
            options.AddArgument("disable-infobars");
            return options;
        }

        public EdgeOptions edgeOptions()
        {
            EdgeOptions options = new EdgeOptions();
            options.AddArguments("-start-maximized", "-incognito");
            options.AddArgument("disable-infobars");
            options.AddExcludedArgument("enable-automation");
            return options;
        }

        public IWebDriver ReActivateMyDriver()
        {
            if (driver == null)
            {
                SelectBrowser(BrowserTypes.Chrome, chromeOptions(), null, null);
            }
            return driver;

        }

        [TearDown]
        public void QuitBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            driver = null!;
        }
    }
}