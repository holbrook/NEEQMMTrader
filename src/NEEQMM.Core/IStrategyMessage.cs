using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEQMM
{
    /// <summary>
    /// 一个标记接口，用于标记可以传递给策略的消息类。
    /// 策略通过实现 <see cref="IStrategyHandle"/> 接收指定类型的消息。
    /// </summary>
    public interface IStrategyMessage
    {
    }
}
