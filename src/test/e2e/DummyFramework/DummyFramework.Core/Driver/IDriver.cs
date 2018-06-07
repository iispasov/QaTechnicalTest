namespace DummyFramework.Core.Driver
{
    public interface IDriver : IElementFinderService,
        INavigationService,
        IJavaScriptExecutor,
        IBrowserService
    {
    }
}