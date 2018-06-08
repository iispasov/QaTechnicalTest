using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Unity;
using DummyFramework.Core.Controls;

namespace DummyFramework.Selenium.Controls
{
    public class ContentElement : Element, IContentElement
    {
        public ContentElement(IWebDriver driver, IWebElement element, IUnityContainer container) : base(driver, element, container)
        {
        }

        public new string Content => InternalElement.Text;

        public new bool IsEnabled => InternalElement.Enabled;

        public void Focus()
        {
            new Actions(Driver).MoveToElement(InternalElement).Perform();
        }

        public void Hover()
        {
            new Actions(Driver).MoveToElement(InternalElement).Perform();
        }
    }
}