using CameraMonitorProj.Model;
using CameraMonitorProj.Util;
using CYQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Common
{
    public static class UserLoginCommon
    {
        /// <summary>
        /// 用户登录记录
        /// </summary>
        /// <param name="isLogin"></param>
        public static void UserLogin(bool isLogin)
        {
            try
            {
                SendLoginState(isLogin);
                RecordLoginState(isLogin);
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                //DSkin.Forms.DSkinMessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private static void SendLoginState(bool isLogin)
        {
           CommonInfo commInfo = new CommonInfo
            {
               Time = DateTime.Now,
                Info = CYQ.Data.Tool.JsonHelper.ToJson(new UserLoginInfo
                {
                    Time = DateTime.Now,
                    UserId = (SystemCommon.LoginUser == null || string.IsNullOrEmpty(SystemCommon.LoginUser.UserId)) ? "" : SystemCommon.LoginUser.UserId,
                    ClientIP = string.IsNullOrEmpty(SystemCommon.LocalIP) ? "" : SystemCommon.LocalIP,
                    //SentryId = (SystemCommon.SentryPost == null || string.IsNullOrEmpty(SystemCommon.SentryPost.ID)) ? "" : SystemCommon.SentryPost.ID,
                    UnitId = (SystemCommon.LoginUnit == null || string.IsNullOrEmpty(SystemCommon.LoginUnit.OrganizeId)) ? "" : SystemCommon.LoginUnit.OrganizeId,
                    IsLogin = isLogin
                }),
               OrderType = ZCommonOrderType.UserLogin
            };

            byte[] byteInfo = Encoding.Default.GetBytes(CYQ.Data.Tool.JsonHelper.ToJson(commInfo));

            // 发送
            if (SystemCommon.Client.Send(byteInfo, byteInfo.Length))
            {
                //MessageBox.Show("发送成功");
            }
            else
            {
                //MessageBox.Show("发送失败");
            }
        }

        private static void RecordLoginState(bool isLogin)
        {
            using (MAction action = new MAction("WJ_KC_PKRWB_LOG"))
            {
                action.BeginTransation();
                action.Set("ID", Guid.NewGuid().ToString());
                action.Set("IP", string.IsNullOrEmpty(SystemCommon.LocalIP) ? "" : SystemCommon.LocalIP);
                action.Set("SJ", DateTime.Now);
                action.Set("ZT", isLogin ? 0 : 1);
                action.Set("DLYHID", (SystemCommon.LoginUser == null || string.IsNullOrEmpty(SystemCommon.LoginUser.UserId)) ? "" : SystemCommon.LoginUser.UserId);
                action.Set("UNITID", (SystemCommon.LoginUnit == null || string.IsNullOrEmpty(SystemCommon.LoginUnit.OrganizeId)) ? "" : SystemCommon.LoginUnit.OrganizeId);
                action.Set("UNITBM", (SystemCommon.LoginUnit == null || string.IsNullOrEmpty(SystemCommon.LoginUnit.OrganizeId)) ? "" : SqlHelper.GetOrganizeCodeById(SystemCommon.LoginUnit.OrganizeId));
                action.Insert(InsertOp.None);
                action.EndTransation();
            }
        }
    }
}
