using DummyFramework.Core.Controls;
using OpenQA.Selenium;
using Unity;

namespace DummyFramework.Selenium.Controls
{
    public class Button : ContentElement, IButton
    {
        public Button(IWebDriver driver, IWebElement element, IUnityContainer container) : base(driver, element, container)
        {
        }
    }
}