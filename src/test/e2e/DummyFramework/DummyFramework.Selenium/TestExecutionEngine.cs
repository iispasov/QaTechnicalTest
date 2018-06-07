using DummyFramework.Core;
using DummyFramework.Core.Controls;
using DummyFramework.Core.Driver;
using DummyFramework.Core.Enums;
using DummyFramework.ExecutionEngine;
using DummyFramework.Selenium.Controls;
using DummyFramework.Selenium.TestEngine;
using Unity;

namespace DummyFramework.Selenium
{
    public class TestExecutionEngine : TestExecutionEngineBase<ExecutionEngineAttribute>
    {
        public TestExecutionEngine(IUnityContainer container) : base(container)
        {
        }

        public override void RegisterDependencies(Browsers browserType)
        {
            var browserSettings = new BrowserSettings(browserType);

            Driver = new SeleniumDriver(Container, browserSettings);
            RegisterControls();
            RegisterDriver();
        }

        private void RegisterControls()
        {
            Container.RegisterType<IElement, Element>();
            Container.RegisterType<IContentElement, ContentElement>();
            Container.RegisterType<IButton, Button>();
        }

        private void RegisterDriver()
        {
            Container.RegisterInstance(Driver);
            Container.RegisterInstance<IElementFinderService>(Driver);
            Container.RegisterInstance<INavigationService>(Driver);
            Container.RegisterInstance<IJavaScriptExecutor>(Driver);
            Container.RegisterInstance<IBrowserService>(Driver);
        }
    }
}