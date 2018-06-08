namespace DummyFramework.Core.Driver
{
    public interface INavigationService
    {
        string Url { get; }

        string Title { get; }

        void NavigateByAbsoluteUrl(string absoluteUrl, bool useDecodedUrl = true);

        void WaitForUrl(string url);

        void WaitForPartialUrl(string url);
    }
}