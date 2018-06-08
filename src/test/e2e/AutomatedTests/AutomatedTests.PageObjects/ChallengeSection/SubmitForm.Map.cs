using DummyFramework.Core;
using DummyFramework.Core.Controls;
using DummyFramework.Core.Driver;

namespace AutomatedTests.PageObjects.ChallengeSection
{
    public partial class SubmitForm : PageObjectBase
    {
        public SubmitForm(IElementFinderService elementFinder) : base(elementFinder)
        {
        }

        public IInputSubmit GetInputSubmit(int index) => ElementFinder.Find<IInputSubmit>(By.CssSelector($"input[data-test-id='submit-{index}']"));

        public IButton ButtonSubmitAnswers => ElementFinder.Find<IButton>(By.CssSelector("button[data-test-id='submit-answers-button']"));
    }
}