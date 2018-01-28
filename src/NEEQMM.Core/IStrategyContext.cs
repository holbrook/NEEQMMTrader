using System;
using NEEQMM.Message;

namespace NEEQMM
{
    public interface IStrategyContext
    {
        void Subscribe(string code, Frequency freq);
    }
}
