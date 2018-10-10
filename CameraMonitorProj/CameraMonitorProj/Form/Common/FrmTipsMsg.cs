using CameraMonitorproj.Form;
using CameraMonitorProj.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorProj.Form.Common
{
    public partial class FrmTipsMsg : FrmBase
    {
        public FrmTipsMsg()
        {
            InitializeComponent();
            PopuUIHelper.CloseButtonMouseEnterAndLeaveEvent(this.picBoxClose);

            this.lbTime.Text = string.Empty;
            this.lbTitle.Text = string.Empty;
            this.tbContent.Text = string.Empty;
            this.lbUnit.Text = string.Empty;
            this.lbLink.Text = string.Empty;

            #region 关闭窗体特效
            CloseBox.MouseClick += (s, e) =>
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                }
                e.Handled = true;
                ShowShadow = false;
                //窗体关闭特效
                int left = Left;
                DoEffect(() =>
                {
                    if (Left > 4)
                    {
                        Opacity = 1.0 * Left / left;
                        Left -= Left / 5;
                        return true;
                    }
                    Close();

                    return false;
                });
            };

            #endregion
        }
        
        /// <summary>
        /// 设置通知内容
        /// </summary>
        /// <param name="title">标题</param>
        /// <param name="unit">单位</param>
        /// <param name="time">时间</param>
        /// <param name="content">内容</param>
        /// <param name="url">链接</param>
        public void SetMsg(string title, string unit, string time, string content, string url)
        {
            if (!string.IsNullOrEmpty(title) && title.Length > 13)
                title = title.Substring(0, 13) + "...";
            this.lbTitle.Text = title;
            this.lbUnit.Text = unit;
            this.lbTime.Text = time;
            if (!string.IsNullOrEmpty(content) && content.Length > 30)
                content = content.Substring(0, 30) + "...";
            this.tbContent.Text = content;
            this.lbLink.Text = url;
        }

        private void picBoxClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Close_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTipsMsg_SizeChanged(object sender, EventArgs e)
        {
        }

        private void lbLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.lbLink.Text);
        }

        private void FrmTipsMsg_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            ShowShadow = false;
            //窗体关闭特效
            int left = Left;
            DoEffect(() =>
            {
                if (Left > 4)
                {
                    Opacity = 1.0 * Left / left;
                    Left -= Left / 5;
                    return true;
                }
                Close();

                return false;
            });
        }

        private void FrmTipsMsg_Load(object sender, EventArgs e)
        {
            #region 窗体右下角向上显示特效
            //自定义特效
            Opacity = 0;
            Rectangle rect = Screen.PrimaryScreen.WorkingArea;

            int xPos = Screen.PrimaryScreen.WorkingArea.Width - this.Width;
            int yPos = Screen.PrimaryScreen.WorkingArea.Height;

            this.Location = new Point(xPos, yPos);
            int endTop = Screen.PrimaryScreen.WorkingArea.Height - Height;
            DoEffect(() =>
            {
                if (Top > (endTop))
                {
                    Opacity = 1 - 1.0 * (Height - endTop) / (rect.Height - Height - endTop);
                    if ((Top - endTop) < 5)
                    {
                        Top -= (Top - endTop);
                    }
                    else
                    {
                        Top -= ((Top - endTop) / 5);
                    }
                    return true;
                }
                Opacity = 1;
                ShowShadow = true;
                //timer1.Enabled = true;
                return false;
            });
            #endregion
        }
    }
}
