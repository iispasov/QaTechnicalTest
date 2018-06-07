namespace DummyFramework.Core.Driver
{
    public interface IBrowser
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