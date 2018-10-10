using CameraMonitorProj.Common;
using CameraMonitorProj.Form;
using CameraMonitorProj.Model;
using CameraMonitorProj.Util;
using CYQ.Data;
using DSkin.DirectUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraMonitorproj.Form
{
    public partial class FrmLogin : DSkin.Forms.DSkinForm
    {
        public FrmLogin()
        {
            InitializeComponent();
            PopuUIHelper.PictureBoxMouseEnterAndLeaveEnvent(this.picClose);
            PopuUIHelper.PictureBoxMouseEnterAndLeaveEnvent(this.picLogin);
            PopuUIHelper.PictureBoxMouseEnterAndLeaveEnvent(this.picLoginState);
            SystemCommon.LoginState = LoginStateEnum.Default;

        }

        private void chkMima_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkMima.Checked && chkZdLogin.Checked)
            {
                chkZdLogin.Checked = false;
            }
        }

        private void chkZdLogin_CheckedChanged(object sender, EventArgs e)
        {
            chkMima.Checked = chkZdLogin.Checked ? true : chkMima.Checked;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            var prcs = Process.GetProcesses();
            foreach (var p in prcs.Where(p => p.ProcessName.Contains("CameraMonitorProj")))
            {
                p.Kill();
                break;
            }
        }

        void Animation_AnimationEnd(object sender, DSkin.Animations.AnimationEventArgs e)
        {
            UserLoginCommon.UserLogin(true);
            SystemCommon.LoginState = CommonHelper.GetLoginStateByUserId(SystemCommon.LoginUser.UserId);
            FrmMain main = new FrmMain();
            main.Show();
            SystemInit.Init();
            this.Hide();
        }

        private void picLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbUser.Text.Trim()) || string.IsNullOrEmpty(this.tbPsd.Text.Trim()))
            {
                this.lbTip.Text = "提示：账号密码不能为空";
                return;
            }

            bool loginResult = CheckUserDataValid(this.tbUser.Text.Trim(), this.tbPsd.Text.Trim());
            if (!loginResult)
            {
                this.lbTip.Text = "登录失败，请确认登录用户名密码!";
                return;
            }

            this.lbTip.Text = "登录成功，请稍后...";
            CommonHelper.WriteAppSettings("IsSavePassword", chkMima.Checked.ToString().ToLower());
            CommonHelper.WriteAppSettings("LoginAccount", DESEncryptHelper.Encrypt(tbUser.Text));
            CommonHelper.WriteAppSettings("LoginPassword", DESEncryptHelper.Encrypt(tbPsd.Text));

            this.Animation.Effect = new DSkin.Animations.FadeinFadeoutEffect();
            this.Animation.AnimationEnd += Animation_AnimationEnd;
            this.Animation.Asc = false;
            this.Animation.Start();
        }

        public bool CheckUserDataValid(string userName, string password)
        {
            string secretkey = "";
            string passWord = "";
            using (MAction action = new MAction("Base_User"))
            {
                if (action.Fill($"Account='{userName}'"))
                {
                    secretkey = action.Data["Secretkey"].StringValue;
                    passWord = action.Data["Password"].StringValue;
                    SystemCommon.LoginUser = action.Data.ToEntity<Base_User>();
                    SystemCommon.LoginUnit = SqlHelper.GetOrganizeById(action.Data["OrganizeId"].StringValue);
                }
                else
                    return false;//没有此账号
            }
            string checkPassWord = MD5(password, 32);
            return MD5(DESEncryptHelper.Encrypt(checkPassWord.ToLower(), secretkey).ToLower(), 32).ToLower().Equals(passWord);
        }

        public string MD5(string str, int code)
        {
            if (code == 16)
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5").Substring(8, 16);
            if (code == 32)
                return System.Web.Security.FormsAuthentication.HashPasswordForStoringInConfigFile(str, "MD5");
            return string.Empty;
        }

        private void FrmLogin_Shown(object sender, EventArgs e)
        {
            chkMima.Checked = CYQ.Data.AppConfig.GetApp("IsSavePassword").ToString().Equals("true");
            if (chkMima.Checked)
            {
                string strAccount = CYQ.Data.AppConfig.GetApp("LoginAccount");
                if (!string.IsNullOrEmpty(strAccount))
                    this.tbUser.Text = DESEncryptHelper.Decrypt(strAccount);
                string strPsd = CYQ.Data.AppConfig.GetApp("LoginPassword");
                if (!string.IsNullOrEmpty(strPsd))
                    this.tbPsd.Text = DESEncryptHelper.Decrypt(strPsd);
            }
        }

        private void tbKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.picLogin_Click(null, null);
        }

        private bool isShow = false;
        private FrmLoginState frmState;
        private void picLoginState_Click(object sender, EventArgs e)
        {
            if (frmState == null)
            {
                frmState = new FrmLoginState();
                frmState.SelectedHandler += new Action<LoginStateEnum>(delegate (LoginStateEnum loginState) {
                    isShow = !isShow;
                    switch (loginState)
                    {
                        case LoginStateEnum.Default:
                            picLoginState.BackgroundImage = (Bitmap)CameraMonitorProj.Properties.Resources.ResourceManager.GetObject("stateDefault");
                            break;
                        case LoginStateEnum.Edit:
                            picLoginState.BackgroundImage = (Bitmap)CameraMonitorProj.Properties.Resources.ResourceManager.GetObject("stateEdit");
                            break;
                        case LoginStateEnum.Check:
                            picLoginState.BackgroundImage = (Bitmap)CameraMonitorProj.Properties.Resources.ResourceManager.GetObject("stateCheck");
                            break;
                    }
                    frmState.Hide();
                });
            }

            if (!isShow)
            {
                frmState.Location = new Point(this.Location.X + 540, this.Location.Y + 360);
                frmState.Show(this);
            }
            else
                frmState.Hide();
            isShow = !isShow;
        }
    }
}
