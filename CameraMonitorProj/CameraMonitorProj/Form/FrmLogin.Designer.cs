namespace CameraMonitorproj.Form
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.picClose = new DSkin.Controls.DSkinPictureBox();
            this.lbTip = new DSkin.Controls.DSkinLabel();
            this.tbPsd = new DSkin.Controls.DSkinTextBox();
            this.tbUser = new DSkin.Controls.DSkinTextBox();
            this.picLogin = new DSkin.Controls.DSkinPictureBox();
            this.chkZdLogin = new DSkin.Controls.DSkinCheckBox();
            this.chkMima = new DSkin.Controls.DSkinCheckBox();
            this.dSkinPictureBox6 = new DSkin.Controls.DSkinPictureBox();
            this.dSkinPictureBox4 = new DSkin.Controls.DSkinPictureBox();
            this.picLoginState = new DSkin.Controls.DSkinPictureBox();
            this.SuspendLayout();
            // 
            // picClose
            // 
            this.picClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picClose.BackgroundImage")));
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Image = null;
            this.picClose.Images = null;
            this.picClose.Location = new System.Drawing.Point(855, 11);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(26, 26);
            this.picClose.TabIndex = 13;
            this.picClose.Text = "dSkinPictureBox1";
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // lbTip
            // 
            this.lbTip.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.lbTip.ForeColor = System.Drawing.Color.Red;
            this.lbTip.Location = new System.Drawing.Point(394, 426);
            this.lbTip.Name = "lbTip";
            this.lbTip.Size = new System.Drawing.Size(2, 23);
            this.lbTip.TabIndex = 12;
            // 
            // tbPsd
            // 
            this.tbPsd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbPsd.BitmapCache = false;
            this.tbPsd.BorderColor = System.Drawing.Color.Transparent;
            this.tbPsd.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbPsd.Borders.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbPsd.Borders.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbPsd.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbPsd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbPsd.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.tbPsd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.tbPsd.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbPsd.Location = new System.Drawing.Point(599, 246);
            this.tbPsd.Multiline = true;
            this.tbPsd.Name = "tbPsd";
            this.tbPsd.PasswordChar = '*';
            this.tbPsd.Size = new System.Drawing.Size(207, 30);
            this.tbPsd.TabIndex = 11;
            this.tbPsd.Text = "0000";
            this.tbPsd.TransparencyKey = System.Drawing.Color.Empty;
            this.tbPsd.WaterColor = System.Drawing.Color.Transparent;
            this.tbPsd.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbPsd.WaterText = "";
            this.tbPsd.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.tbPsd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeyDown);
            // 
            // tbUser
            // 
            this.tbUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbUser.BitmapCache = false;
            this.tbUser.BorderColor = System.Drawing.Color.Transparent;
            this.tbUser.Borders.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbUser.Borders.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbUser.Borders.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbUser.Borders.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbUser.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbUser.Font = new System.Drawing.Font("微软雅黑", 13F);
            this.tbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.tbUser.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.tbUser.Location = new System.Drawing.Point(599, 194);
            this.tbUser.Multiline = true;
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(207, 30);
            this.tbUser.TabIndex = 10;
            this.tbUser.Text = "10012114";
            this.tbUser.TransparencyKey = System.Drawing.Color.Empty;
            this.tbUser.WaterColor = System.Drawing.Color.Transparent;
            this.tbUser.WaterFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbUser.WaterText = "";
            this.tbUser.WaterTextOffset = new System.Drawing.Point(0, 0);
            this.tbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeyDown);
            // 
            // picLogin
            // 
            this.picLogin.BackgroundImage = global::CameraMonitorProj.Properties.Resources.loginBtn;
            this.picLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLogin.Image = null;
            this.picLogin.Images = null;
            this.picLogin.Location = new System.Drawing.Point(626, 332);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(150, 34);
            this.picLogin.TabIndex = 17;
            this.picLogin.Click += new System.EventHandler(this.picLogin_Click);
            this.picLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeyDown);
            // 
            // chkZdLogin
            // 
            this.chkZdLogin.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkZdLogin.Checked = false;
            this.chkZdLogin.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.chkZdLogin.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.chkZdLogin.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.chkZdLogin.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.chkZdLogin.CheckRectBackColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.chkZdLogin.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(188)))));
            this.chkZdLogin.CheckRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.chkZdLogin.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.chkZdLogin.CheckRectWidth = 14;
            this.chkZdLogin.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.chkZdLogin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.chkZdLogin.ForeColor = System.Drawing.Color.White;
            this.chkZdLogin.InnerPaddingWidth = 2;
            this.chkZdLogin.InnerRectInflate = 3;
            this.chkZdLogin.Location = new System.Drawing.Point(713, 292);
            this.chkZdLogin.Name = "chkZdLogin";
            this.chkZdLogin.Size = new System.Drawing.Size(93, 27);
            this.chkZdLogin.SpaceBetweenCheckMarkAndText = 3;
            this.chkZdLogin.TabIndex = 53;
            this.chkZdLogin.Text = "自动登录";
            this.chkZdLogin.TextColorDisabled = System.Drawing.Color.Gray;
            this.chkZdLogin.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.chkZdLogin.Visible = false;
            this.chkZdLogin.CheckedChanged += new System.EventHandler(this.chkZdLogin_CheckedChanged);
            // 
            // chkMima
            // 
            this.chkMima.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chkMima.Checked = true;
            this.chkMima.CheckFlagColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(151)))), ((int)(((byte)(2)))));
            this.chkMima.CheckFlagColorDisabled = System.Drawing.Color.Gray;
            this.chkMima.CheckRectBackColorDisabled = System.Drawing.Color.Silver;
            this.chkMima.CheckRectBackColorHighLight = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.chkMima.CheckRectBackColorNormal = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(239)))), ((int)(((byte)(219)))));
            this.chkMima.CheckRectBackColorPressed = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(226)))), ((int)(((byte)(188)))));
            this.chkMima.CheckRectColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(121)))));
            this.chkMima.CheckRectColorDisabled = System.Drawing.Color.Gray;
            this.chkMima.CheckRectWidth = 14;
            this.chkMima.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMima.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.chkMima.ForeColor = System.Drawing.Color.White;
            this.chkMima.InnerPaddingWidth = 2;
            this.chkMima.InnerRectInflate = 3;
            this.chkMima.Location = new System.Drawing.Point(599, 292);
            this.chkMima.Name = "chkMima";
            this.chkMima.Size = new System.Drawing.Size(93, 27);
            this.chkMima.SpaceBetweenCheckMarkAndText = 3;
            this.chkMima.TabIndex = 52;
            this.chkMima.Text = "记住密码";
            this.chkMima.TextColorDisabled = System.Drawing.Color.Gray;
            this.chkMima.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.chkMima.CheckedChanged += new System.EventHandler(this.chkMima_CheckedChanged);
            this.chkMima.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbKeyDown);
            // 
            // dSkinPictureBox6
            // 
            this.dSkinPictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dSkinPictureBox6.BackgroundImage")));
            this.dSkinPictureBox6.Image = null;
            this.dSkinPictureBox6.Images = null;
            this.dSkinPictureBox6.Location = new System.Drawing.Point(552, 195);
            this.dSkinPictureBox6.Name = "dSkinPictureBox6";
            this.dSkinPictureBox6.Size = new System.Drawing.Size(24, 30);
            this.dSkinPictureBox6.TabIndex = 63;
            this.dSkinPictureBox6.Text = "dSkinPictureBox6";
            // 
            // dSkinPictureBox4
            // 
            this.dSkinPictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("dSkinPictureBox4.BackgroundImage")));
            this.dSkinPictureBox4.Image = null;
            this.dSkinPictureBox4.Images = null;
            this.dSkinPictureBox4.Location = new System.Drawing.Point(552, 248);
            this.dSkinPictureBox4.Name = "dSkinPictureBox4";
            this.dSkinPictureBox4.Size = new System.Drawing.Size(22, 24);
            this.dSkinPictureBox4.TabIndex = 64;
            this.dSkinPictureBox4.Text = "dSkinPictureBox4";
            // 
            // picLoginState
            // 
            this.picLoginState.BackgroundImage = global::CameraMonitorProj.Properties.Resources.stateDefault;
            this.picLoginState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLoginState.Image = null;
            this.picLoginState.Images = null;
            this.picLoginState.Location = new System.Drawing.Point(552, 340);
            this.picLoginState.Name = "picLoginState";
            this.picLoginState.Size = new System.Drawing.Size(22, 22);
            this.picLoginState.TabIndex = 65;
            this.picLoginState.Text = "dSkinPictureBox5";
            this.picLoginState.Click += new System.EventHandler(this.picLoginState_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::CameraMonitorProj.Properties.Resources.login;
            this.CaptionHeight = 4;
            this.ClientSize = new System.Drawing.Size(976, 525);
            this.ControlBox = false;
            this.Controls.Add(this.picLoginState);
            this.Controls.Add(this.dSkinPictureBox4);
            this.Controls.Add(this.dSkinPictureBox6);
            this.Controls.Add(this.chkZdLogin);
            this.Controls.Add(this.chkMima);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.lbTip);
            this.Controls.Add(this.tbPsd);
            this.Controls.Add(this.tbUser);
            this.DoubleClickMaximized = false;
            this.DrawIcon = false;
            this.HaloColor = System.Drawing.Color.Transparent;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogin";
            this.Text = "";
            this.Shown += new System.EventHandler(this.FrmLogin_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DSkin.Controls.DSkinPictureBox picClose;
        private DSkin.Controls.DSkinLabel lbTip;
        private DSkin.Controls.DSkinTextBox tbPsd;
        private DSkin.Controls.DSkinTextBox tbUser;
        private DSkin.Controls.DSkinPictureBox picLogin;
        private DSkin.Controls.DSkinCheckBox chkZdLogin;
        private DSkin.Controls.DSkinCheckBox chkMima;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox6;
        private DSkin.Controls.DSkinPictureBox dSkinPictureBox4;
        private DSkin.Controls.DSkinPictureBox picLoginState;
    }
}