using System;
using Coypu.Queries;

namespace Coypu.Actions
{
    public abstract class BrowserAction : Query<object>
    {
        public TimeSpan Timeout { get; private set; }
        public TimeSpan RetryInterval { get; private set; }

        protected BrowserAction(Options options)
        {
            Timeout = options.Timeout;
            RetryInterval = options.RetryInterval;
        }

        public abstract void Act();

        public void Run()
        {
            Act();
        }

        public object ExpectedResult
        {
            get { return null; }
        }

        public object Result
        {
            get { return null; }
        }
    }
}