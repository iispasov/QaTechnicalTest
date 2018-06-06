namespace DummyFramework.Core.Controls
{
    public interface IContentElement : IElement
    {
        new string Content { get; }

        new bool IsEnabled { get; }

        void Hover();

        void Focus();
    }
}