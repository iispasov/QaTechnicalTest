using System.Reflection;
using Unity;
using NUnit.Framework;
using DummyFramework.Core.Driver;
using DummyFramework.Utilities;

namespace DummyFramework.TestBase
{
    [TestFixture]
    public class TestBase
    {
        private readonly TestExecutionProvider _currentTestExecutionProvider;
        private IDriver _driver;

        public TestBase()
        {
            if (!UnityContainerFactory.IsContainerEmpty())
            {
                UnityContainerFactory.ResetContainer();
            }

            Container = UnityContainerFactory.GetCurrentContainer();
            Container.RegisterInstance(Container);
            _currentTestExecutionProvider = new TestExecutionProvider();
        }

        protected IDriver Driver => _driver ?? (_driver = Container.Resolve<IDriver>());
        protected IUnityContainer Container { get; }
        private static string TestName => TestContext.CurrentContext.Test.Name;

        [SetUp]
        protected void CoreTestInit()
        {
            var testInfo = GetCurrentTestInfo();

            _currentTestExecutionProvider.PreTestInit(TestName, testInfo);
            TestInit();
            _currentTestExecutionProvider.PostTestInit(TestName, testInfo);
        }

        [TearDown]
        protected void CoreTestCleanup()
        {
            var testInfo = GetCurrentTestInfo();

            _currentTestExecutionProvider.PreTestCleanup(TestName, testInfo);
            TestCleanup();
            _currentTestExecutionProvider.PostTestCleanup(TestName, testInfo);
        }

        [OneTimeSetUp]
        protected void CoreTestFixtureInit()
        {
            var fixtureClassInfo = GetType();

            InitializeTestExecutionBehaviours(_currentTestExecutionProvider);

            _currentTestExecutionProvider.PreTestFixtureInit(fixtureClassInfo);
            TestFixtureInit();
            _currentTestExecutionProvider.PostTestFixtureInit(fixtureClassInfo);
        }

        [OneTimeTearDown]
        protected void CoreTestFixtureCleanup()
        {
            var fixtureClassInfo = GetType();

            _currentTestExecutionProvider.PreTestFixtureCleanup(fixtureClassInfo);
            TestFixtureCleanup();
            _currentTestExecutionProvider.PostTestFixtureCleanup(fixtureClassInfo);
        }

        protected virtual void TestInit()
        {
        }

        protected virtual void TestCleanup()
        {
        }

        protected virtual void TestFixtureInit()
        {
        }

        protected virtual void TestFixtureCleanup()
        {
        }

        private static void InitializeTestExecutionBehaviours(IExecutionProvider testExecutionProvider)
        {
            var observers = UnityContainerFactory.GetCurrentContainer().ResolveAll<ITestBehaviourObserver>();

            foreach (var observer in observers)
            {
                observer.Subscribe(testExecutionProvider);
            }
        }

        private MethodInfo GetCurrentTestInfo()
        {
            return GetType().GetMethod(TestContext.CurrentContext.Test.MethodName);
        }
    }
}