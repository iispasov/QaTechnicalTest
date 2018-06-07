using System.Collections.Generic;
using System.Linq;
using Unity;
using Unity.Resolution;
using OpenQA.Selenium;
using DummyFramework.Core.Controls;
using DummyFramework.Selenium.Controls;
using By = DummyFramework.Core.By;
using OpenQA.Selenium.Support.UI;

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

        public void WaitForDisplayed(IWebDriver driver, By by)
        {
            var wait = new WebDriverWait(driver, driver.Manage().Timeouts().ImplicitWait);

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(by.ToSeleniumBy()));
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