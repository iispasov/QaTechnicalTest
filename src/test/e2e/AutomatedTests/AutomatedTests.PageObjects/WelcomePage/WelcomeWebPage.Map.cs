using DummyFramework.Core;
using DummyFramework.Core.Driver;

namespace AutomatedTests.PageObjects.WelcomePage
{
    public partial class WelcomeWebPage : WebPageBase
    {
        public WelcomeWebPage(IElementFinderService elementFinder, INavigationService navigationService) : base(elementFinder, navigationService)
        {
        }
    }
}