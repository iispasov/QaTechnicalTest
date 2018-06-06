using DummyFramework.Core.Driver;

namespace DummyFramework.Core.Controls
{
    public interface IElement : IElementFinder
    {
        bool IsVisible { get; }

        bool IsEnabled { get; }

        int Width { get; }

        string CssClass { get; }

        string Content { get; }

        string GetAttribute(string name);

        void WaitForExists();

        void WaitForNotExists();

        void Click();

        void MouseClick();
    }
}