namespace DummyFramework.Core.Driver
{
    public interface IBrowserService
    {
        BrowserSettings BrowserSettings { get; }

        string SourceString { get; }

        void SwitchToDefault();

        void Quit();

        void ClickBackButton();

        void ClickForwardButton();

        void ClickRefreshButton();

        void MaximizeBrowserWindow();
    }
}