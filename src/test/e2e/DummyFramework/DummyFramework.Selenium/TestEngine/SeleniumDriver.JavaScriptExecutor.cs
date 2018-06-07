using OpenQA.Selenium.Support.Extensions;

namespace DummyFramework.Selenium.TestEngine
{
    public partial class SeleniumDriver
    {
        public T ExecuteScript<T>(string script)
        {
            return _driver.ExecuteJavaScript<T>(script);
        }
    }
}