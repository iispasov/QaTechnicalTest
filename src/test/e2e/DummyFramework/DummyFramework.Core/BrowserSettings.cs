using DummyFramework.Core.Enums;
using System;

namespace DummyFramework.Core
{
    public sealed class BrowserSettings
    {
        public BrowserSettings(Browsers type, int pageLoadTimeout = 60, int scriptTimeout = 60, int elementsWaitTimeout = 60)
        {
            Type = type;
            PageLoadTimeout = pageLoadTimeout;
            ScriptTimeout = scriptTimeout;
            ElementsWaitTimeout = elementsWaitTimeout;
        }

        public static BrowserSettings DefaultChromeSettings => new BrowserSettings(Browsers.Chrome)
        {
            BrowserExeDirectory = string.Empty,
            PageLoadTimeout = 60,
            ScriptTimeout = 60,
            ElementsWaitTimeout = 60
        };

        public static BrowserSettings DefaultFirefoxSettings => new BrowserSettings(Browsers.Firefox)
        {
            BrowserExeDirectory = Environment.CurrentDirectory,
            PageLoadTimeout = 60,
            ScriptTimeout = 60,
            ElementsWaitTimeout = 60
        };

        public static BrowserSettings DefaultInternetExplorerSettings => new BrowserSettings(Browsers.InternetExplorer)
        {
            BrowserExeDirectory = Environment.CurrentDirectory,
            PageLoadTimeout = 60,
            ScriptTimeout = 60,
            ElementsWaitTimeout = 60
        };

        public Browsers Type { get; private set; }

        public int ScriptTimeout { get; set; }

        public int PageLoadTimeout { get; set; }

        public int ElementsWaitTimeout { get; set; }

        public string BrowserExeDirectory { get; set; }
    }
}