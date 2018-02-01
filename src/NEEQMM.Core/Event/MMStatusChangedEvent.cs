using MonoFramework;
using NEEQMM.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEQMM.Event
{   
    public class MMStatusChangedEvent : IEvent
    {
        public string Code { get; private set; }
        public MMStatus Status { get; private set; }

        public MMStatusChangedEvent(string code, MMStatus status)
        {
            Code = code;
            Status = status;
        }
    }
}
