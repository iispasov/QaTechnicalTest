using System;
using DummyFramework.Core.Enums;
using DummyFramework.ExecutionEngine.Enums;

namespace DummyFramework.ExecutionEngine
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ExecutionEngineAttribute : Attribute
    {
        public ExecutionEngineAttribute(ExecutionEngineType executionEngineType, Browsers browser)
        {
            Browser = browser;
            ExecutionEngineType = executionEngineType;
        }

        public ExecutionEngineAttribute(Browsers browser) : this(ExecutionEngineType.WebDriver, browser)
        {
        }

        public Browsers Browser { get; set; }

        public ExecutionEngineType ExecutionEngineType { get; set; }
    }
}