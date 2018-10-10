using CameraMonitorproj.Common;
using CameraMonitorproj.Form;
using CameraMonitorProj.Common;
using CYQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorproj
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int argsCount = args.Length;
            string argInstanceType = (argsCount <= 0) ? "" : args[0];

            if (argInstanceType == "-Multi")
            {
                StartupApplication();
            }
            else if (SingleInstance.CreateMutex())
            {
                StartupApplication();
                SingleInstance.ReleaseMutex();
            }
            else
            {
                if (!SingleInstance.HandleRunningInstance())
                {
                    //MessageBox.Show("该应用程序已经启动！", "启动", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private static void StartupApplication()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                //处理UI线程异常
                Application.ThreadException += Application_ThreadException;
                //处理非UI线程异常
                AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                CYQ.Data.AppConfig.SetConn("Conn", SystemCommon.ConnectionString);
                CYQ.Data.AppConfig.Cache.IsAutoCache = false;
                Application.Run(new FrmLogin());
            }
            catch (Exception ex)
            {
                Log.WriteLogToTxt(ex);
            }
        }

        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Log.WriteLogToTxt(e.ToString(), LogType.Error);
        }
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            Log.WriteLogToTxt(e.Exception);
        }
    }
}
