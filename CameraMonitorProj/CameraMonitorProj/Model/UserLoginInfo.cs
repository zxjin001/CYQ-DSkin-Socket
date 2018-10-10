using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Model
{
    /// <summary>
    /// 登录用户信息
    /// </summary>
    public class UserLoginInfo
    {
        /// <summary>
        /// 登录/退出时间
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 用户 ID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// 单位 ID
        /// </summary>
        public string UnitId { get; set; }

        /// <summary>
        /// 哨位 ID
        /// </summary>
        public string SentryId { get; set; }

        /// <summary>
        /// 客户端 IP
        /// </summary>
        public string ClientIP { get; set; }

        /// <summary>
        /// 登录 / 退出
        /// </summary>
        public bool IsLogin { get; set; }
    }
}
