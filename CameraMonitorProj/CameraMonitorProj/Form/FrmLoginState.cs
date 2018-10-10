using CameraMonitorproj.Form;
using CameraMonitorProj.Common;
using CameraMonitorProj.Model;
using DSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorProj.Form
{
    public partial class FrmLoginState : DSkin.Forms.DSkinForm
    {
        public FrmLoginState()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// 选中登录模式句柄
        /// </summary>
        public Action<LoginStateEnum> SelectedHandler;

        private void Init()
        {
            this.lboxState.Items.Clear();
            //默认
            DuiBaseControl defaultCtl = CreateBaseCtl("默认", "default");
            CreateLabel(defaultCtl, new Point(15, 5), new Size(this.lboxState.Width, 32), "default", "默认", 12, "");
            this.lboxState.Items.Add(defaultCtl);
            //编辑
            DuiBaseControl editCtl = CreateBaseCtl("编辑", "edit");
            CreateLabel(editCtl, new Point(15, 5), new Size(this.lboxState.Width, 32), "edit", "编辑", 12, "");
            this.lboxState.Items.Add(editCtl);

            //审核
            DuiBaseControl checkCtl = CreateBaseCtl("审核", "check");
            CreateLabel(checkCtl, new Point(15, 5), new Size(this.lboxState.Width, 32), "check", "审核", 12, "");
            this.lboxState.Items.Add(checkCtl);
        }

        private DuiBaseControl CreateBaseCtl(string text, string name)
        {
            DuiBaseControl item = new DuiBaseControl();
            item.Name = name;
            item.Text = text;
            item.Width = this.lboxState.Width;
            item.Height = 35;
            item.Cursor = Cursors.Hand;
            item.BackColor = Color.Transparent;
            item.MouseEnter += new EventHandler<MouseEventArgs>(delegate (object obj, MouseEventArgs args)
            {
                item.BackColor = Color.FromArgb(50, 255, 255, 255);
            });
            item.MouseLeave += new EventHandler(delegate (object obj, EventArgs args)
            {
                item.BackColor = Color.Transparent;
            });
            item.MouseClick += new EventHandler<DuiMouseEventArgs>(delegate (object obj, DuiMouseEventArgs args)
            {
            });
            return item;
        }

        private DuiLabel CreateLabel(DuiBaseControl baseItem, Point location, Size size, string name, string text, int fontSize, string toolTip)
        {
            DuiLabel item = new DuiLabel
            {
                Location = location,
                Size = size,
                Name = name,
                Text = text,
                ForeColor = Color.Tan,
                BackColor = Color.Transparent,
                Font = new Font("微软雅黑", fontSize),
                ToolTip = toolTip,
                Cursor = Cursors.Hand
            };

            item.MouseEnter += new EventHandler<MouseEventArgs>(delegate (object obj, MouseEventArgs args)
            {
                baseItem.BackColor = Color.FromArgb(50, 255, 255, 255);
            });
            item.MouseLeave += new EventHandler(delegate (object obj, EventArgs args)
            {
                baseItem.BackColor = Color.Transparent;
            });
            item.MouseClick += new EventHandler<DuiMouseEventArgs>(delegate (object obj, DuiMouseEventArgs args)
            {
                switch (name)
                {
                    case "default":
                        SystemCommon.LoginState = LoginStateEnum.Default;
                        break;
                    case "edit":
                        SystemCommon.LoginState = LoginStateEnum.Edit;
                        break;
                    case "check":
                        SystemCommon.LoginState = LoginStateEnum.Check;
                        break;
                }
                if (this.SelectedHandler != null)
                    this.SelectedHandler(SystemCommon.LoginState);
            });
            baseItem.Controls.Add(item);
            return item;
        }
    }
}
