using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Unity;
using DummyFramework.Core.Controls;

namespace DummyFramework.Selenium.Controls
{
    public class InputSubmit : ContentElement, IInputSubmit
    {
        public InputSubmit(IWebDriver driver, IWebElement element, IUnityContainer container) : base(driver, element, container)
        {
        }

        public void SendKeys(string text)
        {
            new Actions(Driver).MoveToElement(InternalElement).Click().SendKeys(text).Build().Perform();
        }
    }
}