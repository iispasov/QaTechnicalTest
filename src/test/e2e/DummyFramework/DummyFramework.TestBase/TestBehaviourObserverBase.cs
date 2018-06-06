namespace DummyFramework.TestBase
{
    public class TestBehaviourObserverBase : ITestBehaviourObserver
    {
        public void Subscribe(IExecutionProvider provider)
        {
            provider.PreTestFixtureInitEvent += PreTestFixtureInit;
            provider.PostTestFixtureInitEvent += PostTestFixtureInit;
            provider.PreTestFixtureCleanupEvent += PreTestFixtureCleanup;
            provider.PostTestFixtureCleanupEvent += PostTestFixtureCleanup;
            provider.PreTestInitEvent += PreTestInit;
            provider.PostTestInitEvent += PostTestInit;
            provider.PreTestCleanupEvent += PreTestCleanup;
            provider.PostTestCleanupEvent += PostTestCleanup;
        }

        public void Unsubscribe(IExecutionProvider provider)
        {
            provider.PreTestFixtureInitEvent -= PreTestFixtureInit;
            provider.PostTestFixtureInitEvent -= PostTestFixtureInit;
            provider.PreTestFixtureCleanupEvent -= PreTestFixtureCleanup;
            provider.PostTestFixtureCleanupEvent -= PostTestFixtureCleanup;
            provider.PreTestInitEvent -= PreTestInit;
            provider.PostTestInitEvent -= PostTestInit;
            provider.PreTestCleanupEvent -= PreTestCleanup;
            provider.PostTestCleanupEvent -= PostTestCleanup;
        }

        protected virtual void PreTestFixtureInit(object sender, TestExecutionEventArgs e)
        {
        }

        protected virtual void PostTestFixtureInit(object sender, TestExecutionEventArgs e)
        {
        }

        protected virtual void PreTestFixtureCleanup(object sender, TestExecutionEventArgs e)
        {
        }

        protected virtual void PostTestFixtureCleanup(object sender, TestExecutionEventArgs e)
        {
        }

        protected virtual void PreTestInit(object sender, TestExecutionEventArgs e)
        {
        }

        protected virtual void PostTestInit(object sender, TestExecutionEventArgs e)
        {
        }

        protected virtual void PreTestCleanup(object sender, TestExecutionEventArgs e)
        {
        }

        protected virtual void PostTestCleanup(object sender, TestExecutionEventArgs e)
        {
        }
    }
}