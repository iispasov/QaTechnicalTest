using DummyFramework.Core.Driver;

namespace DummyFramework.Core
{
    public abstract class WebPageBase : PageObjectBase
    {
        protected WebPageBase(IElementFinderService elementFinder, INavigationService navigationService) : base(elementFinder)
        {
            NavigationService = navigationService;
        }

        protected INavigationService NavigationService { get; private set; }
    }
}