using DummyFramework.Core.Controls;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace DummyFramework.Selenium.Controls
{
    public class ContentElement : Element, IContentElement
    {
        public ContentElement(IWebDriver driver, IWebElement element) : base(driver, element)
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