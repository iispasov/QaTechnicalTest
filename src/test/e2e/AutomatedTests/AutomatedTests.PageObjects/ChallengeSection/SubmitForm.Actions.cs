namespace AutomatedTests.PageObjects.ChallengeSection
{
    public partial class SubmitForm
    {
        public void EnterTextInputSubmit(int index, string text)
        {
            GetInputSubmit(index).SendKeys(text);
        }

        public void ClickButtonSubmitAnswers()
        {
            ButtonSubmitAnswers.Click();
        }
    }
}