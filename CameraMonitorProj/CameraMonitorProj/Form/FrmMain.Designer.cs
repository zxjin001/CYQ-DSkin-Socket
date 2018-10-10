namespace CameraMonitorproj.Form
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.plBase = new DSkin.Controls.DSkinPanel();
            this.plMain = new DSkin.Controls.DSkinPanel();
            this.plRight = new DSkin.Controls.DSkinPanel();
            this.plLeft = new DSkin.Controls.DSkinPanel();
            this.plBottom = new DSkin.Controls.DSkinPanel();
            this.plTitle = new DSkin.Controls.DSkinPanel();
            this.plBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // plBase
            // 
            this.plBase.BackColor = System.Drawing.Color.Transparent;
            this.plBase.Controls.Add(this.plMain);
            this.plBase.Controls.Add(this.plRight);
            this.plBase.Controls.Add(this.plLeft);
            this.plBase.Controls.Add(this.plBottom);
            this.plBase.Controls.Add(this.plTitle);
            this.plBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plBase.Location = new System.Drawing.Point(4, 8);
            this.plBase.Name = "plBase";
            this.plBase.RightBottom = ((System.Drawing.Image)(resources.GetObject("plBase.RightBottom")));
            this.plBase.Size = new System.Drawing.Size(1912, 1027);
            this.plBase.TabIndex = 0;
            this.plBase.Text = "dSkinPanel1";
            // 
            // plMain
            // 
            this.plMain.BackColor = System.Drawing.Color.Transparent;
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(383, 93);
            this.plMain.Name = "plMain";
            this.plMain.RightBottom = ((System.Drawing.Image)(resources.GetObject("plMain.RightBottom")));
            this.plMain.Size = new System.Drawing.Size(1144, 908);
            this.plMain.TabIndex = 7;
            this.plMain.Text = "dSkinPanel1";
            // 
            // plRight
            // 
            this.plRight.BackColor = System.Drawing.Color.Transparent;
            this.plRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plRight.Location = new System.Drawing.Point(1527, 93);
            this.plRight.Name = "plRight";
            this.plRight.RightBottom = ((System.Drawing.Image)(resources.GetObject("plRight.RightBottom")));
            this.plRight.Size = new System.Drawing.Size(385, 908);
            this.plRight.TabIndex = 6;
            this.plRight.Text = "dSkinPanel1";
            // 
            // plLeft
            // 
            this.plLeft.BackColor = System.Drawing.Color.Transparent;
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(0, 93);
            this.plLeft.Name = "plLeft";
            this.plLeft.RightBottom = ((System.Drawing.Image)(resources.GetObject("plLeft.RightBottom")));
            this.plLeft.Size = new System.Drawing.Size(383, 908);
            this.plLeft.TabIndex = 5;
            this.plLeft.Text = "dSkinPanel1";
            // 
            // plBottom
            // 
            this.plBottom.BackColor = System.Drawing.Color.Transparent;
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom.Location = new System.Drawing.Point(0, 1001);
            this.plBottom.Name = "plBottom";
            this.plBottom.RightBottom = ((System.Drawing.Image)(resources.GetObject("plBottom.RightBottom")));
            this.plBottom.Size = new System.Drawing.Size(1912, 26);
            this.plBottom.TabIndex = 4;
            this.plBottom.Text = "dSkinPanel1";
            // 
            // plTitle
            // 
            this.plTitle.BackColor = System.Drawing.Color.Transparent;
            this.plTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTitle.Location = new System.Drawing.Point(0, 0);
            this.plTitle.Name = "plTitle";
            this.plTitle.RightBottom = ((System.Drawing.Image)(resources.GetObject("plTitle.RightBottom")));
            this.plTitle.Size = new System.Drawing.Size(1912, 93);
            this.plTitle.TabIndex = 0;
            this.plTitle.Text = "dSkinPanel1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(89)))));
            this.CaptionHeight = 4;
            this.ClientSize = new System.Drawing.Size(1920, 1039);
            this.Controls.Add(this.plBase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.plBase.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinPanel plBase;
        private DSkin.Controls.DSkinPanel plMain;
        private DSkin.Controls.DSkinPanel plRight;
        private DSkin.Controls.DSkinPanel plLeft;
        private DSkin.Controls.DSkinPanel plBottom;
        private DSkin.Controls.DSkinPanel plTitle;
    }
}