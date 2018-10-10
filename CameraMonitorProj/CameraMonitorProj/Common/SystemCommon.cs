using CameraMonitorproj.Form;
using CameraMonitorProj.Model;
using CameraMonitorProj.Util;
using CYQ.Data;
using HPSocketCS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Common
{
    public static class SystemCommon
    {

        /// <summary>
        /// TCP 客户端
        /// </summary>
        public static TcpPackClient Client { get; set; }

        /// <summary>
        /// 主窗体
        /// </summary>
        public static FrmMain Main { get; set; }

        /// <summary>
        /// 获取或设置单位 ID
        /// </summary>
        private static string _unitId = string.Empty;
        public static string OrganizeId
        {
            get
            {
                if (string.IsNullOrEmpty(_unitId))
                    return AppConfig.GetApp("DefaultUnitId");
                return _unitId;
            }
            private set
            {
                _unitId = value;
            }
        }

        /// <summary>
        /// 获取或设置单位名称
        /// </summary>
        private static string _unitName = string.Empty;
        public static string OrganizeName
        {
            get
            {
                if (string.IsNullOrEmpty(_unitName))
                    return AppConfig.GetApp("DefaultUnitName");
                return _unitName;
            }
            private set
            {
                _unitName = value;
            }
        }

        /// <summary>
        /// 登录用户
        /// </summary>
        public static Base_User LoginUser { get; set; }

        /// <summary>
        /// 登录单位
        /// </summary>
        public static Base_Organize LoginUnit { get; set; }

        /// <summary>
        /// 登录状态
        /// </summary>
        public static LoginStateEnum LoginState { get; set; }

        /// <summary>
        /// 登录哨位
        /// </summary>
        //public static WJ_SW SentryPost { get; set; }

        /// <summary>
        /// 本机 IP 地址
        /// </summary>
        public static string LocalIP { get; set; }

        /// <summary>
        /// 系统连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return SystemInit.ConnectionString;
            }
        }

        public delegate void UpdateSelectedUnit(string organizeId);
        public static UpdateSelectedUnit UnitChangedHandler;

        /// <summary>
        /// 刷新单位信息
        /// </summary>
        public static void Update(string organizeId)
        {
            OrganizeId = organizeId;
            OrganizeName = SqlHelper.GetOrganizeNameById(organizeId);

            if (UnitChangedHandler != null)
                UnitChangedHandler(organizeId);
        }

        #region Soket 消息处理
        /// <summary>
        /// 接收到 Socket 消息委托
        /// </summary>
        /// <param name="organizeId"></param>
        public delegate void MsgHandler(string receiveStr);
        private static MsgHandler _msgEventHandler;

        /// <summary>
        /// 添加 Socket 消息监听
        /// </summary>
        /// <param name="eventHandler"></param>
        public static void AddObserver(MsgHandler eventHandler)
        {
            _msgEventHandler += eventHandler;
        }

        /// <summary>
        /// 移除 Socket 消息监听
        /// </summary>
        /// <param name="eventHandler"></param>
        public static void RemoveObserver(MsgHandler eventHandler)
        {
            _msgEventHandler -= eventHandler;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="receiveStr"></param>
        public static void ReceiveMsg(string receiveStr)
        {
            if (_msgEventHandler != null)
                _msgEventHandler(receiveStr);
        }
        #endregion
    }
}
