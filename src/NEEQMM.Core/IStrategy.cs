using System;
using MonoFramework;

namespace NEEQMM.API
{
    public interface IStrategy
    {
        /// <summary>
        /// 初始化策略。只会在创建策略实例时调用一次
        /// </summary>
        /// <param name="context"></param>
        void Initialize(IStrategyContext context, dynamic config);

        void Start(IStrategyContext context);
        void Stop(IStrategyContext context);

        /// <summary>
        /// 解释策略参数
        /// </summary>
        /// <param name="config">需要解释的参数配置</param>
        /// <param name="p">前缀，默认为两个空格</param>
        /// <returns>一个用户可读的参数说明</returns>
        string ExplainConfig(dynamic config, string p = "  ");

        /// <summary>
        /// 验证策略参数。返回状态码为 0 表示正确
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        GeneralStatus ValidateConfig(dynamic config);
    }
}
