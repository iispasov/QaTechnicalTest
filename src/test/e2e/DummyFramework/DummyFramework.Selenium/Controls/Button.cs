using OpenQA.Selenium;
using Unity;
using DummyFramework.Core.Controls;

namespace DummyFramework.Selenium.Controls
{
    public class Button : ContentElement, IButton
    {
        public Button(IWebDriver driver, IWebElement element, IUnityContainer container) : base(driver, element, container)
        {
        }
    }
}