using DummyFramework.Core;
using DummyFramework.Core.Controls;
using DummyFramework.Core.Driver;

namespace AutomatedTests.PageObjects.HomeSection
{
    public partial class HomeSection : PageObjectBase
    {
        public HomeSection(IElementFinderService elementFinder) : base(elementFinder)
        {
        }

        public IButton ButtonRenderChallenge => ElementFinder.Find<IButton>(By.CssSelector("[data-test-id='render-challenge']"));
    }
}