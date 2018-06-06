namespace DummyFramework.Core.Driver
{
    public interface IJavaScriptExecutor
    {
        T ExecuteScript<T>(string script);
    }
}