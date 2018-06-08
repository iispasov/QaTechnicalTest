using DummyFramework.Core;

namespace AutomatedTests.PageObjects.ChallengeSection
{
    public partial class ChallengeSection
    {
        public void WaitForDisplayed()
        {
            ElementFinder.WaitForDisplayed(By.CssSelector("#challenge > div > div > h1"));
        }
    }
}