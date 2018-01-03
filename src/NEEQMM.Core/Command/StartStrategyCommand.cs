using System;
using MonoFramework;

namespace NEEQMM.Command
{
    public class StartStrategyCommand:ICommand
    {
        public ResultBase ExecutionResult { get; set; }

        public StartStrategyCommand()
        {
            
        }
    }
}
