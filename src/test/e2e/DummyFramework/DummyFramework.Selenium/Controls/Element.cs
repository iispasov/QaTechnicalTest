using System;
using System.Collections.Generic;
using Unity;
using OpenQA.Selenium;
using DummyFramework.Core.Controls;
using DummyFramework.Core.Driver;
using DummyFramework.Selenium.TestEngine;

using By = DummyFramework.Core.By;

namespace DummyFramework.Selenium.Controls
{
    public class Element : IElement
    {
        protected IWebDriver Driver;
        protected IWebElement InternalElement;
        protected ElementFinderService ElementFinderService;

        public Element(IWebDriver driver, IWebElement element, IUnityContainer container)
        {
            Driver = driver;
            InternalElement = element;
            ElementFinderService = new ElementFinderService(container);
        }

        public bool IsVisible => InternalElement.Displayed;

        public bool IsEnabled => InternalElement.Enabled;

        public string Content => InternalElement.Text;

        public string GetAttribute(string name)
        {
            return InternalElement.GetAttribute(name);
        }

        public void Click()
        {
            InternalElement.Click();
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

        public void WaitForDisplayed(By by)
        {
            ElementFinderService.WaitForDisplayed(Driver, by, TimeSpan.FromSeconds(30));
        }
    }
}