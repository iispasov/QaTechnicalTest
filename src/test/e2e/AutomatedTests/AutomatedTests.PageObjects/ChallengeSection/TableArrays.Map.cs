using System.Collections.Generic;
using DummyFramework.Core;
using DummyFramework.Core.Controls;
using DummyFramework.Core.Driver;

namespace AutomatedTests.PageObjects.ChallengeSection
{
    public partial class TableArrays : PageObjectBase
    {
        public TableArrays(IElementFinderService elementFinder) : base(elementFinder)
        {
        }

        public IEnumerable<IElement> GetTableRows() => ElementFinder.FindAll<IElement>(By.CssSelector("[data-test-id='table-body-arrays'] tr"));

        public IEnumerable<IElement> GetRowCells(int rowIndex) => ElementFinder.FindAll<IElement>(By.CssSelector($"[data-test-id*='array-item-{rowIndex}']"));
    }
}