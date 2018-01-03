using System;
using MonoFramework;
using MonoTrader.Message;
using MonoTrader.Role;
using NEEQMM;
using NEEQMM.Command;

namespace MonoTrader.API
{
    public class DemoBroker : IMMBroker
    {
        public string[] Roles => throw new NotImplementedException();

        public string[] SubscribeTopics => throw new NotImplementedException();

        public string[] DescribeTopics => throw new NotImplementedException();

        IUnitContext Context { get; set; }

        public void OnMessage(Order order){}
        public void OnMessage(Position position){}
        public void OnMessage(Instrument inst){}


        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }

        public void Initialize(dynamic param)
        {
            throw new NotImplementedException();
        }

        public void OnMessage(MMQuoteCommand message)
        {
            throw new NotImplementedException();
        }
    }
}
