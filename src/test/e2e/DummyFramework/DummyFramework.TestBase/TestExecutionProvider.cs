using System;
using System.Reflection;

namespace DummyFramework.TestBase
{
    public class TestExecutionProvider : IExecutionProvider
    {
        public event EventHandler<TestExecutionEventArgs> PreTestFixtureInitEvent;

        public event EventHandler<TestExecutionEventArgs> PostTestFixtureInitEvent;

        public event EventHandler<TestExecutionEventArgs> PreTestFixtureCleanupEvent;

        public event EventHandler<TestExecutionEventArgs> PostTestFixtureCleanupEvent;

        public event EventHandler<TestExecutionEventArgs> PreTestInitEvent;

        public event EventHandler<TestExecutionEventArgs> PostTestInitEvent;

        public event EventHandler<TestExecutionEventArgs> PreTestCleanupEvent;

        public event EventHandler<TestExecutionEventArgs> PostTestCleanupEvent;

        public void PreTestFixtureInit(MemberInfo memberInfo)
        {
            RaiseTestEvent(PreTestFixtureInitEvent, null, memberInfo);
        }

        public void PostTestFixtureInit(MemberInfo memberInfo)
        {
            RaiseTestEvent(PostTestFixtureInitEvent, null, memberInfo);
        }

        public void PreTestFixtureCleanup(MemberInfo memberInfo)
        {
            RaiseTestEvent(PreTestFixtureCleanupEvent, null, memberInfo);
        }

        public void PostTestFixtureCleanup(MemberInfo memberInfo)
        {
            RaiseTestEvent(PostTestFixtureCleanupEvent, null, memberInfo);
        }

        public void PreTestInit(string testName, MemberInfo memberInfo)
        {
            RaiseTestEvent(PreTestInitEvent, testName, memberInfo);
        }

        public void PostTestInit(string testName, MemberInfo memberInfo)
        {
            RaiseTestEvent(PostTestInitEvent, testName, memberInfo);
        }

        public void PreTestCleanup(string testName, MemberInfo memberInfo)
        {
            RaiseTestEvent(PreTestCleanupEvent, testName, memberInfo);
        }

        public void PostTestCleanup(string testName, MemberInfo memberInfo)
        {
            RaiseTestEvent(PostTestCleanupEvent, testName, memberInfo);
        }

        private void RaiseTestEvent(EventHandler<TestExecutionEventArgs> eventHandler, string testName, MemberInfo memberInfo)
        {
            eventHandler?.Invoke(this, new TestExecutionEventArgs(testName, memberInfo));
        }
    }
}