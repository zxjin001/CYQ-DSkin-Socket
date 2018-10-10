using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CameraMonitorproj.Common
{
    public abstract class SingleInstance
    {

        private const int WS_SHOWNORMAL = 1;
        private const int WS_SHOWMINIMIZED = 2;
        private const int WS_SHOWMAXIMIZED = 3;
        [DllImport("User32.dll")]
        private static extern bool ShowWindowAsync(IntPtr hWnd, int cmdShow);
        [DllImport("User32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);
        //标志文件名称
        private static string runFlagFullname = null;
        //声明同步基元
        private static Mutex mutex = null;

        #region api

        public static Process GetRunningInstance()
        {
            Process currentProcess = Process.GetCurrentProcess();//获取当前进程
            //获取当前运行程序完全限定名
            string currentFileName = currentProcess.MainModule.FileName;
            int currentProcessID = currentProcess.Id;
            //获取进程名为ProcessName的Process数组。
            Process[] processes = Process.GetProcessesByName(currentProcess.ProcessName);
            //遍历有相同进程名称正在运行的进程
            foreach (Process process in processes)
            {
                if (process.MainModule.FileName == currentFileName && process.Id != currentProcessID)
                    return process;//返回已运行的进程实例
            }
            return null;
        }

        public static bool HandleRunningInstance(Process instance)
        {
            //确保窗口没有被最小化或最大化
            ShowWindowAsync(instance.MainWindowHandle, WS_SHOWMAXIMIZED);
            //设置真实例程为foreground window
            return SetForegroundWindow(instance.MainWindowHandle);
        }

        public static bool HandleRunningInstance()
        {
            Process p = GetRunningInstance();
            return (p == null) ? false : HandleRunningInstance(p);
        }
        #endregion

        #region Mutex

        public static bool CreateMutex()
        {
            return CreateMutex(Assembly.GetEntryAssembly().FullName);
        }

        public static bool CreateMutex(string name)
        {
            try
            {
                bool result = false;
                mutex = new Mutex(true, name, out result);
                return result;
            }
            catch
            {
                return false;
            }
        }

        public static void ReleaseMutex()
        {
            if (mutex != null) mutex.Close();
        }
        #endregion

        #region 设置标志

        public static bool InitRunFlag()
        {
            if (File.Exists(RunFlag))
            {
                return false;
            }
            using (FileStream fs = new FileStream(RunFlag, FileMode.Create))
            {
            }
            return true;
        }

        public static void DisposeRunFlag()
        {
            if (File.Exists(RunFlag))
            {
                File.Delete(RunFlag);
            }
        }

        public static string RunFlag
        {
            get
            {
                if (runFlagFullname == null)
                {
                    string assemblyFullName = Assembly.GetEntryAssembly().FullName;
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
                    runFlagFullname = Path.Combine(path, assemblyFullName);
                }
                return runFlagFullname;
            }
            set
            {
                runFlagFullname = value;
            }
        }
        #endregion
    }
}
