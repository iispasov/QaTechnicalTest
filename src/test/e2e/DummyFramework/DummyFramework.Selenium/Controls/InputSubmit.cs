using DummyFramework.Core.Controls;
using OpenQA.Selenium;
using Unity;

namespace DummyFramework.Selenium.Controls
{
    public class InputSubmit : ContentElement, IInputSubmit
    {
        public InputSubmit(IWebDriver driver, IWebElement element, IUnityContainer container) : base(driver, element, container)
        {
        }
    }
}