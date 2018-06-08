using System;
using OpenQA.Selenium;
using DummyFramework.Core.Enums;

namespace DummyFramework.Selenium
{
    public static class ByExtensions
    {
        public static By ToSeleniumBy(this Core.By by)
        {
            switch (by.Type)
            {
                case SearchType.Id:
                {
                    return By.Id(by.Value);
                }
                case SearchType.Name:
                {
                    return By.Name(by.Value);
                }
                case SearchType.Tag:
                {
                    return By.TagName(by.Value);
                }
                case SearchType.CssSelector:
                {
                    return By.CssSelector(by.Value);
                }
                case SearchType.XPath:
                {
                    return By.XPath(by.Value);
                }
                default:
                {
                    throw new Exception($"Unknown search type: {by.Type}!");
                }
            }
        }
    }
}