using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEQMM.Message
{
    /// <summary>
    /// 报单量状态
    /// </summary>
    public enum VolumeStatus
    {
        未知 = 0,        // 未知
        正常 = 1,      // 正常
        部分成交 = 2,     // 部分成交
        失效 = 3        // 需要重新报价
    }

    /// <summary>
    /// 做市状态
    /// 在聚合根中计算，然后广播出去
    /// </summary>
    
    public class MMStatus
    {
        public VolumeStatus AskVolumeStatus { get; set; }
        public VolumeStatus BidVolumeStatus { get; set; }

        public VolumeStatus GlobalVolumeStatus
        {
            get
            {
                if (AskVolumeStatus == VolumeStatus.未知 || BidVolumeStatus == VolumeStatus.未知)
                    return VolumeStatus.未知;
                if (AskVolumeStatus == VolumeStatus.失效 || BidVolumeStatus == VolumeStatus.失效)
                    return VolumeStatus.失效;
                if (AskVolumeStatus == VolumeStatus.部分成交 || BidVolumeStatus == VolumeStatus.部分成交)
                    return VolumeStatus.部分成交;
                return VolumeStatus.正常;
            }
        }
    }
}
