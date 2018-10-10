using CameraMonitorProj.Form.Common;
using CameraMonitorProj.Model;
using CameraMonitorProj.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Common
{
    public class SocketMsgCommon
    {
        public static void ReceiveNotice(string receiveStr)
        {
            try
            {
                CommonInfo receiveInfo = CYQ.Data.Tool.JsonHelper.ToEntity<CommonInfo>(receiveStr);
                if (receiveInfo.OrderType == ZCommonOrderType.Notice)
                {
                    //信息中不包含用户 Id 直接忽略
                    if (!receiveInfo.Info.Contains(SystemCommon.LoginUser.UserId))
                        return;

                    if (!receiveStr.Contains("NoticeReply"))
                    {
                        SocketMsgReceiveModel noticeModel = CYQ.Data.Tool.JsonHelper.ToEntity<SocketMsgReceiveModel>(receiveInfo.Info);
                        DataTable dt = SqlHelper.GetNoticeById(noticeModel.NoticeId);
                        if (dt == null || dt.Rows == null || dt.Rows.Count == 0)
                            return;

                        for (int rowIndex = 0; rowIndex < dt.Rows.Count; rowIndex++)
                        {
                            string title = dt.Rows[rowIndex]["Title"].ToString();
                            string unitName = dt.Rows[rowIndex]["FullName"].ToString();
                            string userName = dt.Rows[rowIndex]["RealName"].ToString();
                            string sendTime = dt.Rows[rowIndex]["SendTime"].ToString();
                            SystemCommon.Main.Invoke(new ShowMsg(ShowUnConfigInfo), unitName + " " + userName, "收到通告", title, sendTime);

                            string updateSql = string.Format("UPDATE WJ_KC_NoticeReceive SET State='{0}', ReceiveTime='{1}' WHERE NoticeId='{2}' AND UserId='{3}'", "1", DateTime.Now.ToString(), noticeModel.NoticeId, SystemCommon.LoginUser.UserId);
                            SqlHelper.ExecuteSql(updateSql);
                        }
                    }
                    else
                    {
                        SocketMsgReplyModel noticeModel = CYQ.Data.Tool.JsonHelper.ToEntity<SocketMsgReplyModel>(receiveInfo.Info);
                        DataTable dt = SqlHelper.GetNoticeReceiveInfoByReceiveId(noticeModel.ReceiveId);
                        if (dt == null || dt.Rows == null || dt.Rows.Count == 0)
                            return;

                        string unitName = dt.Rows[0]["FullName"].ToString();
                        string userName = dt.Rows[0]["RealName"].ToString();
                        string replyTime = dt.Rows[0]["ReplyTime"].ToString();
                        SystemCommon.Main.Invoke(new ShowMsg(ShowUnConfigInfo), unitName + " " + userName, "通告回复", "收到一条通告回复，请在通告管理中查看详情", replyTime);
                    }
                }
            }
            catch (Exception ex)
            {
                DSkin.Forms.DSkinMessageBox.Show(ex.Message);
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private static FrmTipsMsg _frmNotify = null;
        public delegate void ShowMsg(string unitName, string title, string content, string time);
        private static void ShowUnConfigInfo(string unitName, string title, string content, string time)
        {
            if (_frmNotify != null)
            {
                _frmNotify.Dispose();
                _frmNotify = null;
            }

            _frmNotify = new FrmTipsMsg();
            _frmNotify.SetMsg(title, unitName, time, content, string.Empty);
            _frmNotify.Show(SystemCommon.Main);
        }
    }

    class SocketMsgReplyModel
    {
        /// <summary>
        /// 接收通知 ID
        /// </summary>
        public string ReceiveId { get; set; }

        /// <summary>
        /// 通知回复
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 通知发送用户 ID
        /// </summary>
        public string UserId { get; set; }
    }

    class SocketMsgReceiveModel
    {
        /// <summary>
        /// 通知 Id
        /// </summary>
        public string NoticeId { get; set; }

        /// <summary>
        /// 用户 Id 集合
        /// </summary>
        public List<string> UserIdList { get; set; }
    }
}
