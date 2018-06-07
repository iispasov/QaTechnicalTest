using DummyFramework.Core.Controls;
using System.Collections.Generic;

namespace DummyFramework.Core.Driver
{
    public interface IElementFinderService
    {
        TElement Find<TElement>(By by) where TElement : class, IElement;

        IEnumerable<TElement> FindAll<TElement>(By by) where TElement : class, IElement;

        bool IsElementPresent(By by);
    }
}