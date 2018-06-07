using DummyFramework.Core;
using DummyFramework.Core.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Safari;
using System;
using Unity;

namespace DummyFramework.Selenium.TestEngine
{
    public partial class SeleniumDriver : IDriver
    {
        private readonly ElementFinderService _elementFinderService;
        private IWebDriver _driver;

        public SeleniumDriver(IUnityContainer container, BrowserSettings browserSettings)
        {
            ResolveBrowser(browserSettings);
            _elementFinderService = new ElementFinderService(container);
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(browserSettings.ElementsWaitTimeout);
        }

        private void ResolveBrowser(BrowserSettings browserSettings)
        {
            switch (browserSettings.Type)
            {
                case Core.Enums.Browsers.NotSet:
                {
                    break;
                }
                case Core.Enums.Browsers.Chrome:
                {
                     _driver = new ChromeDriver();
                    break;
                }
                case Core.Enums.Browsers.Firefox:
                {
                    _driver = new FirefoxDriver();
                    break;
                }
                case Core.Enums.Browsers.InternetExplorer:
                {
                    _driver = new InternetExplorerDriver();
                    break;
                }
                case Core.Enums.Browsers.Safari:
                {
                    _driver = new SafariDriver();
                    break;
                }
                case Core.Enums.Browsers.NoBrowser:
                {
                    break;
                }
            }
        }
    }
}