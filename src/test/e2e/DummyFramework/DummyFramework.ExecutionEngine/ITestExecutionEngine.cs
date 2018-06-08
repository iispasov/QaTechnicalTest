using System.Reflection;
using DummyFramework.Core.Enums;

namespace DummyFramework.ExecutionEngine
{
    public interface ITestExecutionEngine
    {
        bool IsSelected(MemberInfo memberInfo);

        void RegisterDependencies(Browsers browserSettings);
    }
}