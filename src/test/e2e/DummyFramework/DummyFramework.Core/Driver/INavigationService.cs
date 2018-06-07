namespace DummyFramework.Core.Driver
{
    public interface INavigationService
    {
        string Url { get; }

        string Title { get; }

        void Navigate(string relativeUrl, string currentLocation, bool sslEnabled = false);

        void NavigateByAbsoluteUrl(string absoluteUrl, bool useDecodedUrl = true);

        void Navigate(string currentLocation, bool sslEnabled = false);

        void WaitForUrl(string url);

        void WaitForPartialUrl(string url);
    }
}