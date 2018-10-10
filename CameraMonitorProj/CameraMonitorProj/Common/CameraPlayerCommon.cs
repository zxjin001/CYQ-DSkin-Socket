using CameraMonitorProj.Model;
using CameraMonitorProj.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorProj.Common
{
    public static class CameraPlayerCommon
    {

        public static void PlayerCamera(string cameraId, DSkin.Controls.DSkinPanel playerPanel, MouseEventHandler mouseClick)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                //DSkin.Forms.DSkinMessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        private static void StopPlay(DSkin.Controls.DSkinPanel playerPanel)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                CYQ.Data.Log.WriteLogToTxt(ex.Message + Environment.NewLine + ex.StackTrace);
                //DSkin.Forms.DSkinMessageBox.Show(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

    }
}
