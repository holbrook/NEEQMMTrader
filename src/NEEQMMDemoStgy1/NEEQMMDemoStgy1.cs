using System;
using MonoFramework;
using NEEQMM;
using NEEQMM.API;
using NEEQMM.Message;

namespace NEEQMMDemoStgy1
{
    public class NEEQMMDemoStgy1 : IStrategy, IMessageHandler<MMTick>
    {
        public NEEQMMDemoStgy1()
        {
        }

        public void Initialize(IStrategyContext context)
        {
            throw new NotImplementedException();
        }

        public void OnMessage(MMTick message)
        {
            Console.WriteLine("Stgy1 received MMTick");
        }
    }
}
