using System;
using System.Web;
using OpenQA.Selenium.Support.UI;

namespace DummyFramework.Selenium.TestEngine
{
    public partial class SeleniumDriver
    {
        public string Url => _driver.Url;

        public string Title => _driver.Title;

        public void NavigateByAbsoluteUrl(string absoluteUrl, bool useDecodedUrl = true)
        {
            var url = absoluteUrl;
            
            if(useDecodedUrl)
            {
                url = HttpUtility.UrlDecode(url);
            }
            _driver.Navigate().GoToUrl(url);
        }

        public void WaitForPartialUrl(string url)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(BrowserSettings.ScriptTimeout));

            wait.Until(x => x.Url.Contains(url));
        }

        public void WaitForUrl(string url)
        {
            var wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(BrowserSettings.ScriptTimeout));

            wait.Until(x => string.Compare(x.Url, url, StringComparison.InvariantCultureIgnoreCase) == 0);
        }
    }
}