using DummyFramework.Core;

namespace DummyFramework.Selenium.TestEngine
{
    public partial class SeleniumDriver
    {
        public BrowserSettings BrowserSettings { get; }

        public void Quit()
        {
            _driver.Quit();
        }

        public void ClickBackButton()
        {
            _driver.Navigate().Back();
        }

        public void ClickForwardButton()
        {
            _driver.Navigate().Forward();
        }

        public void ClickRefreshButton()
        {
            _driver.Navigate().Refresh();
        }

        public void MaximizeBrowserWindow()
        {
            _driver.Manage().Window.Maximize();
        }
    }
}