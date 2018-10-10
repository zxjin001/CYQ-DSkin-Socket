using CameraMonitorProj.Common;
using DSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorproj.Form
{
    public partial class FrmMain : FrmBase
    {
        public FrmMain()
        {
            InitializeComponent();
            SystemCommon.Main = this;
        }

        /// <summary>
        /// 顶部面板
        /// </summary>
        public DSkinPanel TopPanel {
            get {
                return this.plTitle;
            }
        }

        /// <summary>
        /// 左面板
        /// </summary>
        public DSkinPanel LeftPanel
        {
            get {
                return this.plLeft;
            }
        }

        /// <summary>
        /// 右面版
        /// </summary>
        public DSkinPanel RightPanel
        {
            get {
                return this.plRight;
            }
        }

        /// <summary>
        /// 底部面板
        /// </summary>
        public DSkinPanel BottomPanel
        {
            get {
                return this.plBottom;
            }
        }

        /// <summary>
        /// 主面板
        /// </summary>
        public DSkinPanel MainPanel
        {
            get {
                return this.plMain;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            UISwitchCommon.SystemInitControl();
        }
    }
}
