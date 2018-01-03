using System;
using MonoFramework;

namespace NEEQMM.Command
{
    public class MMQuoteResult : ResultBase
    {
        public string OrderID { get; set; }

        public MMQuoteResult(int code, string msg, string orderID) : base(code, msg)
        {
            OrderID = orderID;
        }
    }

    public class MMQuoteCommand:ICommand
    {
        public MMQuoteCommand()
        {
        }

        public MMQuoteResult ExecutionResult { get; set; }
    }
}
