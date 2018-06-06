namespace DummyFramework.TestBase
{
    public interface ITestBehaviourObserver
    {
        void Subscribe(IExecutionProvider provider);

        void Unsubscribe(IExecutionProvider provider);
    }
}