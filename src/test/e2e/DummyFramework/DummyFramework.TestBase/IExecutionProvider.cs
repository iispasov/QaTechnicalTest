using System;

namespace DummyFramework.TestBase
{
    public interface IExecutionProvider
    {
        event EventHandler<TestExecutionEventArgs> PreTestFixtureInitEvent;

        event EventHandler<TestExecutionEventArgs> PostTestFixtureInitEvent;

        event EventHandler<TestExecutionEventArgs> PreTestFixtureCleanupEvent;

        event EventHandler<TestExecutionEventArgs> PostTestFixtureCleanupEvent;

        event EventHandler<TestExecutionEventArgs> PreTestInitEvent;

        event EventHandler<TestExecutionEventArgs> PostTestInitEvent;

        event EventHandler<TestExecutionEventArgs> PreTestCleanupEvent;

        event EventHandler<TestExecutionEventArgs> PostTestCleanupEvent;
    }
}