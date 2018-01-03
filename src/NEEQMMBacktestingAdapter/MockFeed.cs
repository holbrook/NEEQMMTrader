using System;
using System.ComponentModel.Composition;
using MonoFramework;
using NEEQMM;
using NEEQMM.Command;

namespace NEEQMMBacktestingAdapter
{
    [Export(typeof(IUnit))]
    public class MockFeed: IUnit, IMMFeed
    {
        public MockFeed()
        {
        }

        public IUnitContext Context => throw new NotImplementedException();

        public string[] Roles => throw new NotImplementedException();

        public string[] SubscribeTopics => throw new NotImplementedException();

        public string[] DescribeTopics => throw new NotImplementedException();

        public void Initialize(dynamic param)
        {
            //throw new NotImplementedException();
        }

        public void Start()
        {
            //throw new NotImplementedException();
        }

        public void Stop()
        {
            //throw new NotImplementedException();
        }

        public void Execute(MMQuoteCommand cmd)
        {
            //throw new NotImplementedException();
        }
    }
}
