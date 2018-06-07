using DummyFramework.Core.Controls;
using OpenQA.Selenium;

namespace DummyFramework.Selenium.Controls
{
    public class Button : ContentElement, IButton
    {
        public Button(IWebDriver driver, IWebElement element) : base(driver, element)
        {
        }
    }
}