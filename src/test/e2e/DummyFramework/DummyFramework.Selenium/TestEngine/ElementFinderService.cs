using System;
using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using DummyFramework.Core.Controls;
using DummyFramework.Selenium.Controls;
using By = DummyFramework.Core.By;

namespace DummyFramework.Selenium.TestEngine
{
    public class ElementFinderService
    {
        private readonly IUnityContainer _container;

        public ElementFinderService(IUnityContainer container)
        {
            _container = container;
        }

        public TElement Find<TElement>(ISearchContext searchContext, By by) where TElement : class, IElement
        {
            var element = searchContext.FindElement(by.ToSeleniumBy());
            var result = ResolveElement<TElement>(searchContext, element);

            return result;
        }

        public IEnumerable<TElement> FindAll<TElement>(ISearchContext searchContext, By by) where TElement : class, IElement
        {
            var elements = searchContext.FindElements(by.ToSeleniumBy());

            return elements.Select(currentElement => ResolveElement<TElement>(searchContext, currentElement));
        }

        public bool IsElementPresent(ISearchContext searchContext, By by)
        {
            var element = Find<Element>(searchContext, by);

            return element.IsVisible;
        }

        public void WaitForDisplayed(IWebDriver driver, By by, TimeSpan timeout)
        {
            var wait = new WebDriverWait(driver, timeout)
            {
                PollingInterval = TimeSpan.FromSeconds(1.0)
            };

            wait.Until(x =>
            {
                var executor = (IJavaScriptExecutor)x;
                var element = x.FindElement(by.ToSeleniumBy());

                return (bool) executor.ExecuteScript(
                    @"var rect = arguments[0].getBoundingClientRect();

                    return (
                        rect.top >= 0 &&
                        rect.left >= 0 &&
                        rect.bottom <= (window.innerHeight || document.documentElement.clientHeight) &&
                        rect.right <= (window.innerWidth || document.documentElement.clientWidth)
                    );", element);
            });
        }

        private TElement ResolveElement<TElement>(ISearchContext searchContext, IWebElement element) where TElement : class, IElement
        {
            var result = _container.Resolve<TElement>(new ResolverOverride[]
            {
                new ParameterOverride("driver", searchContext),
                new ParameterOverride("element", element)
            });

            return result;
        }
    }
}