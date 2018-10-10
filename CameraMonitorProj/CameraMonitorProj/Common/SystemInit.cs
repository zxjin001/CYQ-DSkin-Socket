using CameraMonitorProj.Model;
using CameraMonitorProj.Util;
using CYQ.Data;
using HPSocketCS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CameraMonitorProj.Common
{
    public static class SystemInit
    {
        /// <summary>
        /// 初始化项目
        /// </summary>
        public static void Init()
        {
            InitSocketClient();
            GetCameraConfigInfo();
            CheckUnReceiveNotice();
            SystemCommon.AddObserver(SocketMsgCommon.ReceiveNotice);
            SystemCommon.Update(SystemCommon.LoginUnit.OrganizeId);
        }

        private static void InitSocketClient()
        {
            try
            {
                if (SystemCommon.Client == null)
                {
                    SystemCommon.Client = new TcpPackClient();
                    SystemCommon.Client.MaxPackSize = 0x1000;
                    SystemCommon.Client.PackHeaderFlag = 0xff;
                    SystemCommon.Client.OnPrepareConnect += new TcpClientEvent.OnPrepareConnectEventHandler(OnPrepareConnect);
                    SystemCommon.Client.OnConnect += new TcpClientEvent.OnConnectEventHandler(OnConnect);
                    SystemCommon.Client.OnSend += new TcpClientEvent.OnSendEventHandler(OnSend);
                    SystemCommon.Client.OnReceive += new TcpClientEvent.OnReceiveEventHandler(OnReceive);
                    SystemCommon.Client.OnClose += new TcpClientEvent.OnCloseEventHandler(OnClose);

                    string serverIP = AppConfig.GetApp("ServerIP");
                    int serverPort = AppConfig.GetAppInt("ServerPort", 0);
                    bool isAsync = Convert.ToBoolean(AppConfig.GetApp("IsAsync"));

                    if (SystemCommon.Client.Connect(serverIP, (ushort)serverPort, isAsync))
                    { }
                    else
                    { }
                }
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private static HandleResult OnPrepareConnect(TcpClient sender, IntPtr socket)
        {
            return HandleResult.Ok;
        }

        private static HandleResult OnConnect(TcpClient sender)
        {
            // 已连接 到达一次
            return HandleResult.Ok;
        }

        private static HandleResult OnSend(TcpClient sender, byte[] bytes)
        {
            // 客户端发数据了
            return HandleResult.Ok;
        }

        private static HandleResult OnReceive(TcpClient sender, byte[] bytes)
        {
            string msg = System.Text.Encoding.Default.GetString(bytes);
            SystemCommon.ReceiveMsg(msg);
            CYQ.Data.Log.WriteLogToTxt(msg);
            return HandleResult.Ok;
        }

        private static HandleResult OnClose(TcpClient sender, SocketOperation enOperation, int errorCode)
        {
            return HandleResult.Ok;
        }

        /// <summary>
        /// 获取连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                string connStr = ConfigurationManager.AppSettings["ConnectionString"];
                string conStrEncrypt = ConfigurationManager.AppSettings["ConStringEncrypt"];
                if (conStrEncrypt == "true")
                {
                    if (connStr != "")
                        connStr = Util.DESEncryptHelper.Decrypt(connStr);
                }
                return connStr;
            }
        }

        /// <summary>
        /// 获取摄像头信息
        /// </summary>
        private static void GetCameraConfigInfo()
        {
         
        }

        public static void CheckUnReceiveNotice()
        {
            try
            {
                DataTable dt = SqlHelper.GetUnReceiveNoticeInfoByUserId(SystemCommon.LoginUser.UserId);
                if (dt == null || dt.Rows == null || dt.Rows.Count == 0)
                    return;

                for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                {
                    string updateSql = string.Format("UPDATE WJ_KC_NoticeReceive SET State='{0}', ReceiveTime='{1}' WHERE Id='{2}'", "1", DateTime.Now.ToString(), dt.Rows[rowIndex]["Id"].ToString());
                    SqlHelper.ExecuteSql(updateSql);
                }
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

    }
}
