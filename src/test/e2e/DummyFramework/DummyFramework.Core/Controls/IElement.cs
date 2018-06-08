using DummyFramework.Core.Driver;

namespace DummyFramework.Core.Controls
{
    public interface IElement : IElementFinderService
    {
        bool IsVisible { get; }

        bool IsEnabled { get; }

        string Content { get; }

        string GetAttribute(string name);

        void Click();
    }
}