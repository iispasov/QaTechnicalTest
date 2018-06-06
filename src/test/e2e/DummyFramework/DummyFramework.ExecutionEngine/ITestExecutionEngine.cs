using DummyFramework.Core.Enums;
using System.Reflection;

namespace DummyFramework.ExecutionEngine
{
    public interface ITestExecutionEngine
    {
        bool IsSelected(MemberInfo memberInfo);

        void RegisterDependencies(Browsers browserSettings);
    }
}