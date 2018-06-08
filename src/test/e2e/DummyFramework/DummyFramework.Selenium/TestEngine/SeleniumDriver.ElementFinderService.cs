using System;
using System.Collections.Generic;
using DummyFramework.Core;
using DummyFramework.Core.Driver;

namespace DummyFramework.Selenium.TestEngine
{
    public partial class SeleniumDriver
    {
        TElement IElementFinderService.Find<TElement>(By by)
        {
            return _elementFinderService.Find<TElement>(_driver, by);
        }

        IEnumerable<TElement> IElementFinderService.FindAll<TElement>(By by)
        {
            return _elementFinderService.FindAll<TElement>(_driver, by);
        }

        public bool IsElementPresent(By by)
        {
            return _elementFinderService.IsElementPresent(_driver, by);
        }

        public void WaitForDisplayed(By by)
        {
            _elementFinderService.WaitForDisplayed(_driver, by, TimeSpan.FromSeconds(BrowserSettings.ScriptTimeout));
        }
    }
}