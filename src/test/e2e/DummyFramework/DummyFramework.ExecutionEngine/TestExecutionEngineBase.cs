using System.Reflection;
using Unity;
using DummyFramework.Core.Driver;
using DummyFramework.Core.Enums;

namespace DummyFramework.ExecutionEngine
{
    public abstract class TestExecutionEngineBase<TExecutionEngineAttribute> : ITestExecutionEngine
        where TExecutionEngineAttribute : ExecutionEngineAttribute
    {
        protected readonly IUnityContainer Container;
        protected IDriver Driver;

        protected TestExecutionEngineBase(IUnityContainer container)
        {
            Container = container;
        }

        public bool IsSelected(MemberInfo memberInfo)
        {
            var isSetOnMethodLevel = TryGetExecutionEngineAttribute(memberInfo);
            var isSetOnClassLevel = TryGetExecutionEngineAttribute(memberInfo.DeclaringType);

            return isSetOnMethodLevel || isSetOnClassLevel;
        }

        public abstract void RegisterDependencies(Browsers browserSettings);

        private static bool TryGetExecutionEngineAttribute(MemberInfo currentType)
        {
            var classExecutionEngineAttribute = currentType?.GetCustomAttribute<TExecutionEngineAttribute>(true);

            return classExecutionEngineAttribute != null;
        }
    }
}