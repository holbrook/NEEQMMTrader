using System;
using MonoFramework;
using NEEQMM;
using NEEQMM.API;
using NEEQMM.Message;

namespace NEEQMMDemoStgy1
{
    public class NEEQMMDemoStgy1 : IStrategy, IStrategyHandle<MMTick>
    {
        public NEEQMMDemoStgy1()
        {
        }

        public void Initialize(IStrategyContext context, dynamic config)
        {
            throw new NotImplementedException();
        }

        public void Start(IStrategyContext context)
        {
            throw new NotImplementedException();
        }

        public void Stop(IStrategyContext context)
        {
            throw new NotImplementedException();
        }

        public string ExplainConfig(dynamic config, string p = "  ")
        {
            throw new NotImplementedException();
        }

        public GeneralStatus ValidateConfig(dynamic config)
        {
            throw new NotImplementedException();
        }
        

        public void OnMessage(IStrategyContext context, MMTick message)
        {
            throw new NotImplementedException();
        }

        
    }
}
