namespace AutomatedTests.PageObjects.WelcomePage
{
    public partial class WelcomeWebPage
    {
        public void Navigate()
        {
            NavigationService.NavigateByAbsoluteUrl(Constants.RenderChallengeUrl);
        }
    }
}