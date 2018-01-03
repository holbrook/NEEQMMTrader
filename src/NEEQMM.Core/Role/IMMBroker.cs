using System;
using MonoFramework;
using NEEQMM.Command;

namespace NEEQMM
{
    public interface IMMBroker: IRole, IMessageHandler<MMQuoteCommand>
    {
    }
}
