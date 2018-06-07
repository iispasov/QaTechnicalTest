using DummyFramework.Core.Enums;
using DummyFramework.ExecutionEngine;

namespace DummyFramework.Selenium
{
    public class WebDriverExecutionEngineAttribute : ExecutionEngineAttribute
    {
        public WebDriverExecutionEngineAttribute(Browsers browser = Browsers.Chrome) : base(browser)
        {
            Browser = browser;
        }
    }
}