using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using DummyFramework.Core.Controls;
using DummyFramework.Selenium.Controls;
using By = DummyFramework.Core.By;

namespace DummyFramework.Selenium.TestEngine
{
    public class ElementFinderService
    {
        public TElement Find<TElement>(ISearchContext searchContext, By by) where TElement : class, IElement
        {
            var element = searchContext.FindElement(by.ToSeleniumBy());
            var result = CreateWebElement<TElement>(searchContext, element);

            return result;
        }

        public IEnumerable<TElement> FindAll<TElement>(ISearchContext searchContext, By by) where TElement : class, IElement
        {
            var elements = searchContext.FindElements(by.ToSeleniumBy());

            return elements.Select(currentElement => CreateWebElement<TElement>(searchContext, currentElement)).ToList();
        }

        public bool IsElementPresent(ISearchContext searchContext, By by)
        {
            var element = Find<Element>(searchContext, by);

            return element.IsVisible;
        }

        private static TElement CreateWebElement<TElement>(ISearchContext searchContext, IWebElement webElement) where TElement : class, IElement
        {
            var result = Activator.CreateInstance(typeof(TElement), searchContext, webElement);

            return (TElement) result;
        }
    }
}