using System;
using System.Reflection;

namespace DummyFramework.TestBase
{
    public class TestExecutionEventArgs : EventArgs
    {
        public TestExecutionEventArgs(string testName, MemberInfo memberInfo)
        {
            TestName = testName;
            MemberInfo = memberInfo;
        }

        public virtual string TestName { get; }

        public virtual MemberInfo MemberInfo { get; }
    }
}