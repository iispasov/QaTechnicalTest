using DummyFramework.Core.Driver;

namespace DummyFramework.Core
{
    public abstract class PageObjectBase
    {
        protected PageObjectBase(IElementFinderService elementFinder)
        {
            ElementFinder = elementFinder;
        }

        protected IElementFinderService ElementFinder { get; private set; }
    }
}