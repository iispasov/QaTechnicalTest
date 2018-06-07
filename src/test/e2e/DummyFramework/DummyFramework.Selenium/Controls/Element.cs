using System;
using System.Collections.Generic;
using DummyFramework.Core.Controls;
using DummyFramework.Core.Driver;
using DummyFramework.Selenium.TestEngine;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using By = DummyFramework.Core.By;

namespace DummyFramework.Selenium.Controls
{
    public class Element : IElement
    {
        protected IWebDriver Driver;
        protected IWebElement InternalElement;
        protected ElementFinderService ElementFinderService;

        public Element(IWebDriver driver, IWebElement element)
        {
            Driver = driver;
            InternalElement = element;
            ElementFinderService = new ElementFinderService();
        }

        public bool IsVisible => InternalElement.Displayed;

        public bool IsEnabled => InternalElement.Enabled;

        public int Width => InternalElement.Size.Width;

        public string CssClass => InternalElement.GetAttribute("className");

        public string Content => InternalElement.Text;

        public string GetAttribute(string name)
        {
            return InternalElement.GetAttribute(name);
        }

        public void WaitForExists()
        {
            throw new NotImplementedException();
        }

        public void WaitForNotExists()
        {
            throw new NotImplementedException();
        }

        public void Click()
        {
            InternalElement.Click();
        }

        public void MouseClick()
        {
            var builder = new Actions(Driver);
            builder.MoveToElement(InternalElement).Click().Build().Perform();
        }

        TElement IElementFinderService.Find<TElement>(By by)
        {
            return ElementFinderService.Find<TElement>(InternalElement, by);
        }

        IEnumerable<TElement> IElementFinderService.FindAll<TElement>(By by)
        {
            return ElementFinderService.FindAll<TElement>(InternalElement, by);
        }

        public bool IsElementPresent(By by)
        {
            return ElementFinderService.IsElementPresent(InternalElement, by);
        }
    }
}