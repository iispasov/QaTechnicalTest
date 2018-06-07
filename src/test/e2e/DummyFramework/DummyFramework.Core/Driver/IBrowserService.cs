namespace DummyFramework.Core.Driver
{
    public interface IBrowserService
    {
        BrowserSettings BrowserSettings { get; }

        void Quit();

        void ClickBackButton();

        void ClickForwardButton();

        void ClickRefreshButton();

        void MaximizeBrowserWindow();
    }
}