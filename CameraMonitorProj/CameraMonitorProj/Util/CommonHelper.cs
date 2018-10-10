using CameraMonitorProj.Common;
using CameraMonitorProj.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Util
{
    public static class CommonHelper
    {

        /// <summary>
        /// 写入配置文件
        /// </summary>
        /// <param name="strKey"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool WriteAppSettings(string strKey, string value)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                AppSettingsSection appSettings = config.GetSection("appSettings") as AppSettingsSection;
                appSettings.Settings.Remove(strKey);
                appSettings.Settings.Add(strKey, value);
                config.Save(ConfigurationSaveMode.Full);
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 获取登录状态
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string GetLoginState(LoginStateEnum state)
        {
            try
            {
                switch (state)
                {
                    case LoginStateEnum.Default:
                        return "默认";
                    case LoginStateEnum.Check:
                        return "审核";
                    case LoginStateEnum.Edit:
                        return "编辑";
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                return string.Empty;
            }
        }

        /// <summary>
        /// 获取用户权限
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public static LoginStateEnum GetLoginStateByUserId(string userId)
        {
            DataTable dt = SqlHelper.GetPriorityByUserId(SystemCommon.LoginUser.UserId);
            if (dt == null || dt.Rows == null || dt.Rows.Count == 0)
                return LoginStateEnum.Default;

            string power = dt.Rows[0]["QX"].ToString();
            if (string.IsNullOrEmpty(power))
                return LoginStateEnum.Default;

            switch (power)
            {
                case "0":
                case "3":
                    return LoginStateEnum.Default;
                case "1":
                    return LoginStateEnum.Edit;
                case "2":
                    return LoginStateEnum.Check;
            }
            return LoginStateEnum.Default;
        }

        /// <summary>
        /// 获取单位级别
        /// </summary>
        /// <param name="organizeId"></param>
        /// <returns></returns>
        public static UnitLevelEnum GetUnitLavel(string organizeId)
        {
            string level = SqlHelper.GetOrganizeEnCode(organizeId);
            if (string.IsNullOrEmpty(level))
                return UnitLevelEnum.Squadron;

            switch (level)
            {
                case "总队":
                    return UnitLevelEnum.GeneralTeam;
                case "支队":
                    return UnitLevelEnum.Detachment;
                case "中队":
                case "大队":
                    return UnitLevelEnum.Squadron;
            }

            return UnitLevelEnum.Squadron;
        }

    }
}
