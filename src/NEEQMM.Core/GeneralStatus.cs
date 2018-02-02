using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEEQMM
{
    /// <summary>
    /// 通用的返回，包括状态码和消息
    /// </summary>
    public class GeneralStatus
    {
        public int Code { get; private set; }
        public string Message { get; private set; }

        public GeneralStatus(int code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
