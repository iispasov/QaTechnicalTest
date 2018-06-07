using DummyFramework.Core.Enums;
using DummyFramework.ExecutionEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Unity;

namespace DummyFramework.TestBase.Behaviours
{
    public class ExecutionEngineBehaviourObserver : TestBehaviourObserverBase
    {
        private readonly List<ITestExecutionEngine> _testExecutionEngines;

        public ExecutionEngineBehaviourObserver(IUnityContainer container)
        {
            _testExecutionEngines = container.ResolveAll<ITestExecutionEngine>().ToList();
        }

        protected override void PreTestFixtureInit(object sender, TestExecutionEventArgs e)
        {
            ThrowExceptionExecutionEngineNotSet(e.MemberInfo);
            InitializeDriver(e.MemberInfo);7
        }

        protected override void PreTestInit(object sender, TestExecutionEventArgs e)
        {
            InitializeDriver(e.MemberInfo);
        }

        private static void ThrowExceptionExecutionEngineNotSet(MemberInfo memberInfo)
        {
            if (!Attribute.IsDefined(memberInfo, typeof(ExecutionEngineAttribute), true))
            {
                throw new Exception("You have to set execution engine for you test fixture class.");
            }
        }

        private void InitializeDriver(MemberInfo memberInfo)
        {
            var browser = GetBrowserType(memberInfo);

            if (browser == Browsers.NotSet)
            {
                return;
            }
            foreach (var engine in _testExecutionEngines)
            {
                if (!engine.IsSelected(memberInfo))
                {
                    continue;
                }
                engine.RegisterDependencies(browser);

                break;
            }
        }

        private Browsers GetBrowserType(MemberInfo memberInfo)
        {
            if (memberInfo == null)
            {
                throw new ArgumentNullException(nameof(memberInfo));
            }

            var browserSettingsAttribute = memberInfo.GetCustomAttribute<ExecutionEngineAttribute>(true);

            return browserSettingsAttribute?.Browser ?? Browsers.NotSet;
        }

        private Browsers ConfigureBrowser(MemberInfo memberInfo)
        {
            var methodLevelBrowser = GetBrowserType(memberInfo);
            var classLevelBrowser = GetBrowserType(memberInfo.DeclaringType);

            return methodLevelBrowser != Browsers.NotSet && methodLevelBrowser != classLevelBrowser ? methodLevelBrowser : Browsers.NotSet;
        }
    }
}