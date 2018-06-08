using DummyFramework.Core;

namespace AutomatedTests.PageObjects.ChallengeSection
{
    public partial class TableArrays
    {
        public void WaitForDisplayed()
        {
            ElementFinder.WaitForDisplayed(By.CssSelector("[data-test-id='table-body-arrays']"));
        }
    }
}