using DSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorProj.Util
{
    public class PopuUIHelper
    {
        /// <summary>
        /// 给关闭按钮设置鼠标移入移出颜色
        /// </summary>
        /// <param name="picBox"></param>
        public static void CloseButtonMouseEnterAndLeaveEvent(DSkin.Controls.DSkinPictureBox picBox)
        {
            picBox.MouseEnter += new EventHandler(delegate (object sender, EventArgs e) {
                picBox.BackColor = Color.FromArgb(150, 200, 0, 0);
                picBox.Cursor = System.Windows.Forms.Cursors.Hand;
            });
            picBox.MouseLeave += new EventHandler(delegate (object sender, EventArgs e) {
                picBox.BackColor = Color.Transparent;
            });
        }

        /// <summary>
        /// 设置文本标签鼠标移入移出事件
        /// </summary>
        /// <param name="label"></param>
        public static void LabelMouseEnterAndLeaveEnvent(DSkin.Controls.DSkinLabel label)
        {
            Color orignalColor = label.ForeColor;
            label.MouseEnter += new  EventHandler(delegate (object sender, EventArgs e) {
                label.Cursor = System.Windows.Forms.Cursors.Hand;
                label.ForeColor = Color.Yellow;  
                label.Font = new Font(label.Font.Name, label.Font.Size + 1);
                label.Location = new Point(label.Location.X, label.Location.Y - 1);
            });
            label.MouseLeave += new EventHandler(delegate (object sender, EventArgs e) {
                label.ForeColor = orignalColor;
                label.Font = new Font(label.Font.Name, label.Font.Size - 1);
                label.Location = new Point(label.Location.X, label.Location.Y + 1);
            });
        }

        public static void LabelMouseEnterAndLeaveEnvent(DuiLabel label)
        {
            Color orignalColor = label.ForeColor;
            label.MouseEnter += new EventHandler<MouseEventArgs>(delegate (object sender, MouseEventArgs e) {
                label.Cursor = System.Windows.Forms.Cursors.Hand;
                label.ForeColor = Color.Yellow;
                //label.Font = new Font(label.Font.Name, label.Font.Size + 1);
                //label.Location = new Point(label.Location.X, label.Location.Y - 1);
            });
            label.MouseLeave += new EventHandler(delegate (object sender, EventArgs e) {
                label.ForeColor = orignalColor;
                //label.Font = new Font(label.Font.Name, label.Font.Size - 1);
                //label.Location = new Point(label.Location.X, label.Location.Y + 1);
            });
        }

        /// <summary>
        /// 图片框鼠标移入移出事件
        /// </summary>
        /// <param name="pic"></param>
        public static void PictureBoxMouseEnterAndLeaveEnvent(DSkin.Controls.DSkinPictureBox pic)
        {
            pic.MouseEnter += new EventHandler(delegate (object sender, EventArgs e) {
                pic.Cursor = System.Windows.Forms.Cursors.Hand;
                pic.Size = new Size(pic.Size.Width + 2, pic.Size.Height + 2);
                pic.Location = new Point(pic.Location.X - 1, pic.Location.Y - 1);
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            });
            pic.MouseLeave += new EventHandler(delegate (object sender, EventArgs e) {
                pic.Size = new Size(pic.Size.Width - 2, pic.Size.Height - 2);
                pic.Location = new Point(pic.Location.X + 1, pic.Location.Y + 1);
            });
        }

        public static void PictureBoxMouseEnterAndLeaveEnvent(DSkin.DirectUI.DuiBaseControl pic)
        {
            pic.MouseEnter += new EventHandler<MouseEventArgs>(delegate (object sender, MouseEventArgs e)
            {
                pic.Cursor = System.Windows.Forms.Cursors.Hand;
                pic.Size = new Size(pic.Size.Width + 4, pic.Size.Height + 4);
                pic.Location = new Point(pic.Location.X - 2, pic.Location.Y - 2);
            });
            pic.MouseLeave += new EventHandler(delegate (object sender, EventArgs e) {
                pic.Size = new Size(pic.Size.Width - 4, pic.Size.Height - 4);
                pic.Location = new Point(pic.Location.X + 2, pic.Location.Y + 2);
            });
        }

        /// <summary>
        /// 按钮鼠标移入移出事件
        /// </summary>
        /// <param name="btn"></param>
        public static void ClickButtonMouseEnterAndLeaveEvent(DSkin.Controls.DSkinButton btn)
        {
            Color orignalForeColor = btn.ForeColor;
            Color buttonBorderColor = btn.ButtonBorderColor;
            btn.MouseEnter += new EventHandler(delegate (object sender, EventArgs e) {
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.ButtonBorderColor = Color.Green;
                btn.ForeColor = Color.Yellow;
            });
            btn.MouseLeave += new EventHandler(delegate (object sender, EventArgs e) {
                btn.ButtonBorderColor = buttonBorderColor;
                btn.ForeColor = orignalForeColor;
            });
        }

        /// <summary>
        /// 按钮鼠标移入移出事件
        /// </summary>
        /// <param name="btn"></param>
        public static void ButtonMouseEnterAndLeaveEvent(DSkin.Controls.DSkinButton btn)
        {
            Color orignalForeColor = btn.ForeColor;
            btn.MouseEnter += new EventHandler(delegate (object sender, EventArgs e) {
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.ForeColor = Color.Yellow;
            });
            btn.MouseLeave += new EventHandler(delegate (object sender, EventArgs e) {
                btn.ForeColor = orignalForeColor;
            });
        }

        /// <summary>
        /// 设置滚动条
        /// </summary>
        /// <param name="listBox"></param>
        public static void SetListBoxScrollBar(DSkin.Controls.DSkinListBox listBox)
        {
            listBox.ShowScrollBar = true;
            listBox.ScrollBarWidth = 11;
            listBox.AutoHideScrollBar = true;
            listBox.DoSmoothScroll(20);
            //listBox.SmoothScroll = true;
            listBox.InnerScrollBar.ArrowNormalColor = System.Drawing.Color.FromArgb(26, 84, 164);
            listBox.InnerScrollBar.ArrowHoverColor = System.Drawing.Color.FromArgb(26, 84, 164);
            listBox.InnerScrollBar.ArrowPressColor = System.Drawing.Color.FromArgb(26, 84, 164);
            listBox.InnerScrollBar.ScrollBarNormalColor = System.Drawing.Color.FromArgb(100, 26, 84, 164);
            listBox.InnerScrollBar.ScrollBarHoverColor = System.Drawing.Color.FromArgb(100, 26, 84, 164);
            listBox.InnerScrollBar.ScrollBarPressColor = System.Drawing.Color.FromArgb(100, 26, 84, 164);
            listBox.InnerScrollBar.BackColor = System.Drawing.Color.FromArgb(50, 0, 46, 115);

            listBox.InnerScrollBar.Fillet = true;
        }

        public static DuiBaseControl CreateBaseControl(string text, string name, int width, int height, Color backColor, Color borderColor)
        {
            DuiBaseControl item = new DuiBaseControl
            {
                BackColor = backColor,
                Width = width,
                Text = text,
                Name = name,
                Height = height,
                ShowBorder = !borderColor.Equals(Color.Transparent)
            };
            item.Borders.AllColor = borderColor;
            return item;
        }

        public static DuiLabel CreateLabel(DuiBaseControl baseItem, Point location, Size size, string name, string text, Color foreColor, Font font, Color borderColor, string toolTip)
        {
            DuiLabel label = new DuiLabel
            {
                Location = location,
                Size = size,
                Name = name,
                Text = text,
                ForeColor = foreColor,
                Font = font,
                BackColor = Color.Transparent,
                ShowBorder = !borderColor.Equals(Color.Transparent),
                ToolTip = toolTip
            };
            label.Borders.AllColor = borderColor;
            baseItem.Controls.Add(label);
            return label;
        }

        public static DuiBaseControl CreatePicture(DuiBaseControl baseItem, string name, string text, Point location, Size size, string bgImgName)
        {
            DuiBaseControl baseCtl = new DuiBaseControl
            {
                Location = location,
                Size = size,
                Name = name,
                Text = text,
                BackgroundImage = (Bitmap)Properties.Resources.ResourceManager.GetObject(bgImgName),
                BackgroundImageLayout = ImageLayout.Stretch,
                BackColor = Color.Transparent,
            };
            baseItem.Controls.Add(baseCtl);
            return baseCtl;
        }
    }
}
