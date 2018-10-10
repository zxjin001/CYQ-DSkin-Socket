using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CameraMonitorProj.Common
{
    public static class UISwitchCommon
    {
        /// <summary>
        /// 系统初始化主界面
        /// </summary>
        public static void SystemInitControl()
        {
            try
            {
                if (SystemCommon.Main == null)
                    return;

                ////主面板
                //CtlMainCameras mainCameras = new CtlMainCameras
                //{
                //    Dock = System.Windows.Forms.DockStyle.Fill
                //};
                //mainCameras.InitCameras(4);
                //SystemCommon.Main.MainPanel.Controls.Clear();
                //SystemCommon.Main.MainPanel.Controls.Add(mainCameras);

                ////右面版
                //CtlCourseInfo courseInfo = new CtlCourseInfo
                //{
                //    Dock = System.Windows.Forms.DockStyle.Fill
                //};
                //SystemCommon.Main.RightPanel.Controls.Clear();
                //SystemCommon.Main.RightPanel.Controls.Add(courseInfo);

                ////左面板
                //CtlUnitListInfo unitInfo = new CtlUnitListInfo {
                //    Dock = System.Windows.Forms.DockStyle.Fill
                //};
                //unitInfo.Init();
                //SystemCommon.Main.LeftPanel.Controls.Clear();
                //SystemCommon.Main.LeftPanel.Controls.Add(unitInfo);

                ////顶部面板
                //SystemCommon.Main.TopPanel.Controls.Clear();
                //SystemCommon.Main.TopPanel.Controls.Add(new CtlTitle { Dock = System.Windows.Forms.DockStyle.Fill });

                //底部状态栏
                SystemCommon.Main.BottomPanel.Height = 2;
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
    }
}
