using System;
using MonoFramework;

namespace NEEQMM.API
{
    public interface IStrategy :IRole
    {
        void Initialize(IStrategyContext context);
    }
}
