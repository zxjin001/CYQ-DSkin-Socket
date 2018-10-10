namespace CameraMonitorProj.Form.Common
{
    partial class FrmTipsMsg
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipsMsg));
            this.timer_Close = new System.Windows.Forms.Timer(this.components);
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.dSkinPanel3 = new DSkin.Controls.DSkinPanel();
            this.lbLink = new System.Windows.Forms.LinkLabel();
            this.tbContent = new DSkin.Controls.DSkinTextBox();
            this.lbUnit = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel6 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel4 = new DSkin.Controls.DSkinLabel();
            this.lbTime = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel9 = new DSkin.Controls.DSkinLabel();
            this.lbTitle = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel3 = new DSkin.Controls.DSkinLabel();
            this.dSkinLabel2 = new DSkin.Controls.DSkinLabel();
            this.picBoxClose = new DSkin.Controls.DSkinPictureBox();
            this.lbMainTitle = new DSkin.Controls.DSkinLabel();
            this.dSkinPanel1.SuspendLayout();
            this.dSkinPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer_Close
            // 
            this.timer_Close.Enabled = true;
            this.timer_Close.Interval = 10000;
            this.timer_Close.Tick += new System.EventHandler(this.timer_Close_Tick);
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.dSkinPanel1.Controls.Add(this.dSkinPanel3);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel1.Location = new System.Drawing.Point(4, 34);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(385, 237);
            this.dSkinPanel1.TabIndex = 29;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // dSkinPanel3
            // 
            this.dSkinPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.dSkinPanel3.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(131)))), ((int)(((byte)(146)))));
            this.dSkinPanel3.Controls.Add(this.lbLink);
            this.dSkinPanel3.Controls.Add(this.tbContent);
            this.dSkinPanel3.Controls.Add(this.lbUnit);
            this.dSkinPanel3.Controls.Add(this.dSkinLabel6);
            this.dSkinPanel3.Controls.Add(this.dSkinLabel4);
            this.dSkinPanel3.Controls.Add(this.lbTime);
            this.dSkinPanel3.Controls.Add(this.dSkinLabel9);
            this.dSkinPanel3.Controls.Add(this.lbTitle);
            this.dSkinPanel3.Controls.Add(this.dSkinLabel3);
            this.dSkinPanel3.Controls.Add(this.dSkinLabel2);
            this.dSkinPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel3.Location = new System.Drawing.Point(0, 0);
            this.dSkinPanel3.Name = "dSkinPanel3";
            this.dSkinPanel3.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel3.RightBottom")));
            this.dSkinPanel3.Size = new System.Drawing.Size(385, 237);
            this.dSkinPanel3.TabIndex = 1;
            this.dSkinPanel3.Text = "dSkinPanel3";
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbLink.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbLink.LinkColor = System.Drawing.Color.SandyBrown;
            this.lbLink.Location = new System.Drawing.Point(125, 200);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(86, 21);
            this.lbLink.TabIndex = 50;
            this.lbLink.TabStop = true;
            this.lbLink.Text = "linkLabel1";
            this.lbLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLink_LinkClicked);
            // 
            // tbContent
            // 
            this.tbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.tbContent.BitmapCache = false;
            this.tbContent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(27)))), ((int)(((byte)(69)))));
            this.tbContent.Enabled = false;
            this.tbContent.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.tbContent.ForeColor = System.Drawing.Color.SandyBrown;
            this.tbContent.Location = new System.Drawing.Point(129, 127);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(243, 70);
            this.tbContent.TabIndex = 49;
            this.tbContent.Text = "通知内容通知内容通知内容内容通知通知内容通知内容通知内容内容通知内容通知内容内容通知内容通知内容通知内容内容通知内容通知内容通知内容";
            this.tbContent.TransparencyKey = System.Drawing.Color.Empty;
            this.tbContent.WaterColor = System.Drawing.Color.SandyBrown;
            this.tbContent.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbContent.WaterText = "";
            this.tbContent.WaterTextOffset = new System.Drawing.Point(0, 0);
            // 
            // lbUnit
            // 
            this.lbUnit.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbUnit.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbUnit.Location = new System.Drawing.Point(129, 19);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(72, 24);
            this.lbUnit.TabIndex = 48;
            this.lbUnit.Text = "郑州支队";
            // 
            // dSkinLabel6
            // 
            this.dSkinLabel6.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.dSkinLabel6.ForeColor = System.Drawing.Color.White;
            this.dSkinLabel6.Location = new System.Drawing.Point(63, 19);
            this.dSkinLabel6.Name = "dSkinLabel6";
            this.dSkinLabel6.Size = new System.Drawing.Size(60, 26);
            this.dSkinLabel6.TabIndex = 47;
            this.dSkinLabel6.Text = "单位：";
            // 
            // dSkinLabel4
            // 
            this.dSkinLabel4.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.dSkinLabel4.ForeColor = System.Drawing.Color.White;
            this.dSkinLabel4.Location = new System.Drawing.Point(27, 200);
            this.dSkinLabel4.Name = "dSkinLabel4";
            this.dSkinLabel4.Size = new System.Drawing.Size(96, 26);
            this.dSkinLabel4.TabIndex = 46;
            this.dSkinLabel4.Text = "详情连接：";
            // 
            // lbTime
            // 
            this.lbTime.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbTime.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbTime.Location = new System.Drawing.Point(129, 93);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(149, 24);
            this.lbTime.TabIndex = 45;
            this.lbTime.Text = "2018-6-15 9:20:00";
            // 
            // dSkinLabel9
            // 
            this.dSkinLabel9.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.dSkinLabel9.ForeColor = System.Drawing.Color.White;
            this.dSkinLabel9.Location = new System.Drawing.Point(63, 91);
            this.dSkinLabel9.Name = "dSkinLabel9";
            this.dSkinLabel9.Size = new System.Drawing.Size(60, 26);
            this.dSkinLabel9.TabIndex = 44;
            this.dSkinLabel9.Text = "时间：";
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbTitle.ForeColor = System.Drawing.Color.SandyBrown;
            this.lbTitle.Location = new System.Drawing.Point(129, 55);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(171, 24);
            this.lbTitle.TabIndex = 43;
            this.lbTitle.Text = "决赛拉姆将携名模持大";
            // 
            // dSkinLabel3
            // 
            this.dSkinLabel3.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.dSkinLabel3.ForeColor = System.Drawing.Color.White;
            this.dSkinLabel3.Location = new System.Drawing.Point(63, 127);
            this.dSkinLabel3.Name = "dSkinLabel3";
            this.dSkinLabel3.Size = new System.Drawing.Size(60, 26);
            this.dSkinLabel3.TabIndex = 42;
            this.dSkinLabel3.Text = "内容：";
            // 
            // dSkinLabel2
            // 
            this.dSkinLabel2.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.dSkinLabel2.ForeColor = System.Drawing.Color.White;
            this.dSkinLabel2.Location = new System.Drawing.Point(63, 55);
            this.dSkinLabel2.Name = "dSkinLabel2";
            this.dSkinLabel2.Size = new System.Drawing.Size(60, 26);
            this.dSkinLabel2.TabIndex = 41;
            this.dSkinLabel2.Text = "标题：";
            // 
            // picBoxClose
            // 
            this.picBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBoxClose.BackgroundImage")));
            this.picBoxClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxClose.Image = null;
            this.picBoxClose.Images = new System.Drawing.Image[] {
        null};
            this.picBoxClose.Location = new System.Drawing.Point(364, 6);
            this.picBoxClose.Name = "picBoxClose";
            this.picBoxClose.Size = new System.Drawing.Size(22, 22);
            this.picBoxClose.TabIndex = 27;
            this.picBoxClose.Text = "dSkinPictureBox2";
            this.picBoxClose.Click += new System.EventHandler(this.picBoxClose_Click);
            // 
            // lbMainTitle
            // 
            this.lbMainTitle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lbMainTitle.ForeColor = System.Drawing.Color.White;
            this.lbMainTitle.Location = new System.Drawing.Point(6, 6);
            this.lbMainTitle.Name = "lbMainTitle";
            this.lbMainTitle.Size = new System.Drawing.Size(72, 24);
            this.lbMainTitle.TabIndex = 28;
            this.lbMainTitle.Text = "提示信息";
            // 
            // FrmTipsMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 275);
            this.Controls.Add(this.dSkinPanel1);
            this.Controls.Add(this.picBoxClose);
            this.Controls.Add(this.lbMainTitle);
            this.Name = "FrmTipsMsg";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTipsMsg_FormClosing);
            this.Load += new System.EventHandler(this.FrmTipsMsg_Load);
            this.SizeChanged += new System.EventHandler(this.FrmTipsMsg_SizeChanged);
            this.dSkinPanel1.ResumeLayout(false);
            this.dSkinPanel3.ResumeLayout(false);
            this.dSkinPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinPictureBox picBoxClose;
        private DSkin.Controls.DSkinLabel lbMainTitle;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinPanel dSkinPanel3;
        private System.Windows.Forms.LinkLabel lbLink;
        private DSkin.Controls.DSkinTextBox tbContent;
        private DSkin.Controls.DSkinLabel lbUnit;
        private DSkin.Controls.DSkinLabel dSkinLabel6;
        private DSkin.Controls.DSkinLabel dSkinLabel4;
        private DSkin.Controls.DSkinLabel lbTime;
        private DSkin.Controls.DSkinLabel dSkinLabel9;
        private DSkin.Controls.DSkinLabel lbTitle;
        private DSkin.Controls.DSkinLabel dSkinLabel3;
        private DSkin.Controls.DSkinLabel dSkinLabel2;
        private System.Windows.Forms.Timer timer_Close;
    }
}