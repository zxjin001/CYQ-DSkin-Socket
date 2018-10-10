namespace CameraMonitorProj.Form
{
    partial class FrmLoginState
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoginState));
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.lboxState = new DSkin.Controls.DSkinListBox();
            this.dSkinPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lboxState)).BeginInit();
            this.SuspendLayout();
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Controls.Add(this.lboxState);
            this.dSkinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dSkinPanel1.Location = new System.Drawing.Point(4, 8);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(71, 178);
            this.dSkinPanel1.TabIndex = 0;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // lboxState
            // 
            this.lboxState.BackColor = System.Drawing.Color.Transparent;
            this.lboxState.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxState.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lboxState.ForeColor = System.Drawing.Color.Transparent;
            this.lboxState.Location = new System.Drawing.Point(0, 0);
            this.lboxState.Name = "lboxState";
            this.lboxState.ScrollBarWidth = 12;
            this.lboxState.Size = new System.Drawing.Size(71, 178);
            this.lboxState.TabIndex = 31;
            this.lboxState.Text = "dSkinListBox1";
            this.lboxState.Value = 0D;
            // 
            // FrmLoginState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.CaptionColor = System.Drawing.Color.Transparent;
            this.CaptionHeight = 4;
            this.ClientSize = new System.Drawing.Size(79, 190);
            this.ControlBox = false;
            this.Controls.Add(this.dSkinPanel1);
            this.DrawIcon = false;
            this.HaloColor = System.Drawing.Color.Transparent;
            this.Name = "FrmLoginState";
            this.ShadowColor = System.Drawing.Color.Transparent;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "";
            this.dSkinPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lboxState)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinPanel dSkinPanel1;
        private DSkin.Controls.DSkinListBox lboxState;
    }
}