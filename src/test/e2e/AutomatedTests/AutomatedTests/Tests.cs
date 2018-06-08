using System;
using Unity;
using NUnit.Framework;
using AutomatedTests.PageObjects.WelcomePage;
using AutomatedTests.Challenges;
using DummyFramework.TestBase;
using DummyFramework.Selenium;
using DummyFramework.ExecutionEngine;
using DummyFramework.TestBase.Behaviours;


namespace AutomatedTests
{
    [WebDriverExecutionEngine]
    public class Tests : TestBase
    {
        private readonly AutomationChallenges _challenges;

        public Tests()
        {
            Container.RegisterType<ITestBehaviourObserver, ExecutionEngineBehaviourObserver>(Guid.NewGuid().ToString());
            Container.RegisterType<ITestExecutionEngine, TestExecutionEngine>(Guid.NewGuid().ToString());
            _challenges = new AutomationChallenges(Container);
        }

        protected override void TestInit()
        {
            Driver.MaximizeBrowserWindow();
            var webPage = Container.Resolve<WelcomeWebPage>();
            webPage.Navigate();
        }

        protected override void TestCleanup()
        {
            Driver.Quit();
        }

        [TestCase("Iskren")]
        public void DummyTest(string name)
        {
            _challenges.StartChallengeOne();
            _challenges.StartChallengeTwo();
            _challenges.StartChallengeThree();
            _challenges.SubmitAnswers(name);        
        }
    }
}