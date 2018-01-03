using System;
using System.ComponentModel.Composition;
using MonoFramework;
using NEEQMM;
using NEEQMM.Command;

namespace NEEQMMBacktestingAdapter
{
    /// <summary>
    /// 在单一节点中实现<see cref="IMMBroker"/> 和 <see cref="IMMFeed"/>
    /// </summary>

    [Export(typeof(IUnit))]
    public class Adapter : IUnit, IMMBroker, IMMFeed
    {
        public IUnitContext Context { get; set; }

        public string[] SubscribeTopics => throw new NotImplementedException();

        public string[] DescribeTopics => throw new NotImplementedException();

        public Adapter()
        {
        }

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


        public void OnMessage(MMQuoteCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
