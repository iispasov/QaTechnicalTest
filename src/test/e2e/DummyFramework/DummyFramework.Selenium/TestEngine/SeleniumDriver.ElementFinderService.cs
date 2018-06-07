﻿using DummyFramework.Core.Driver;
using System.Collections.Generic;

namespace DummyFramework.Selenium.TestEngine
{
    public partial class SeleniumDriver
    {
        TElement IElementFinderService.Find<TElement>(Core.By by)
        {
            return _elementFinderService.Find<TElement>(_driver, by);
        }

        IEnumerable<TElement> IElementFinderService.FindAll<TElement>(Core.By by)
        {
            return _elementFinderService.FindAll<TElement>(_driver, by);
        }

        public bool IsElementPresent(Core.By by)
        {
            return _elementFinderService.IsElementPresent(_driver, by);
        }
    }
}