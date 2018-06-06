using DummyFramework.Core.Controls;
using DummyFramework.Core.Enums;

namespace DummyFramework.Core
{
    public class By
    {
        public By(SearchType type, string value) : this(type, value, null)
        {
        }

        public By(SearchType type, string value, IElement parent)
        {
            Type = type;
            Value = value;
            Parent = parent;
        }

        public SearchType Type { get; private set; }

        public string Value { get; private set; }

        public IElement Parent { get; private set; }

        public static By Id(string id)
        {
            return new By(SearchType.Id, id);
        }

        public static By Id(string id, IElement parentElement)
        {
            return new By(SearchType.Id, id, parentElement);
        }

        public static By Name(string name)
        {
            return new By(SearchType.Name, name);
        }

        public static By Name(string name, IElement parentElement)
        {
            return new By(SearchType.Name, name, parentElement);
        }

        public static By XPath(string xpath)
        {
            return new By(SearchType.XPath, xpath);
        }

        public static By XPath(string xpath, IElement parentElement)
        {
            return new By(SearchType.XPath, xpath, parentElement);
        }

        public static By CssSelector(string cssSelector)
        {
            return new By(SearchType.CssSelector, cssSelector);
        }

        public static By CssSelector(string cssSelector, IElement parentElement)
        {
            return new By(SearchType.CssSelector, cssSelector, parentElement);
        }
    }
}