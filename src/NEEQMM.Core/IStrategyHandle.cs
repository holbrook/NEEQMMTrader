using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEQMM
{
    /// <summary>
    /// 定义策略需要接收哪些类型的消息。消息必须是<see cref="IStrategyMessage"/>类型。
    /// </summary>
    /// <typeparam name="TMessage"></typeparam>
    public interface IStrategyHandle<TMessage>
        where TMessage: IStrategyMessage
    {
        void OnMessage(IStrategyContext context, TMessage message);
    }
}
