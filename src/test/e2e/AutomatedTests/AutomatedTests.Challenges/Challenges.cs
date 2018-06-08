using System.Linq;
using Unity;
using AutomatedTests.PageObjects.ChallengeSection;
using AutomatedTests.PageObjects.HomeSection;

namespace AutomatedTests.Challenges
{
    public class AutomationChallenges
    {
        private IUnityContainer _container;

        public AutomationChallenges(IUnityContainer container)
        {
            _container = container;
        }

        public void StartChallengeOne()
        {
            var homeSection = _container.Resolve<HomeSection>();

            homeSection.ClickButtonRenderChallenge();
        }

        public void StartChallengeTwo()
        {
            var challengeSection = _container.Resolve<ChallengeSection>();

            challengeSection.WaitForDisplayed();
        }

        public void StartChallengeThree()
        {
            var tableArrays = _container.Resolve<TableArrays>();
            var rowCount = tableArrays.GetTableRows().Count();
            var submitAnswersForm = _container.Resolve<SubmitForm>();

            for (var i = 1; i <= rowCount; i++)
            {
                var cells = tableArrays.GetRowCells(i);
                var res = ArraysChallange.FindCenter(cells);

                submitAnswersForm.EnterTextInputSubmit(i, res.ToString());
            }
        }

        public void SubmitAnswers(string name)
        {
            var submitAnswersForm = _container.Resolve<SubmitForm>();

            submitAnswersForm.EnterTextInputSubmit(4, "Iskren");
            submitAnswersForm.ClickButtonSubmitAnswers();
        }
    }
}