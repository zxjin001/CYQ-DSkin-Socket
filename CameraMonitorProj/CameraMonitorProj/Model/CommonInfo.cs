using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Model
{
    /// <summary>
    /// 发送服务端信息格式
    /// </summary>
    public class CommonInfo
    {
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 信息内容
        /// </summary>
        public string Info { get; set; }

        /// <summary>
        /// 信息类型
        /// </summary>
        public ZCommonOrderType OrderType { get; set; }
    }
}
