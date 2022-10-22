﻿using JWT_SmartClean.CommonUI;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWT_SmartClean
{
    public partial class FLogin : UIForm
    {
        public bool ChangeUser = false;
        public FLogin(bool _ChangeUser=false)
        {
            InitializeComponent();
            Util.initDB();
            ChangeUser = _ChangeUser;
            lbTitle.Text = SoftConfig._SoftName;
            if (_ChangeUser)
            {
                this.Text = "切换用户";
            }
        }

        private void uiTxtUserNo_TextChanged(object sender, EventArgs e)
        {
            //查询用户名
            if (uiTxtUserNo.Text=="000")
            {
                lbUserName.Text = "管理员";
                return;
            }
            var u = SoftConfig.db.User.Where(x => x.UserCode == uiTxtUserNo.Text).ToList();
            if (u != null && u.Count > 0)
            {
                lbUserName.Text = u[0].UserName;
            }
            else
                lbUserName.Text = "";
        }

        private void uiTxtPsw_Click(object sender, EventArgs e)
        {

            using (FKeyBoardNum f=new FKeyBoardNum("请输入密码"))
            {
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    uiTxtPsw.Text = f.output;
                }
                else
                    uiTxtPsw.Text = "";
            }
        }

        private void uiTxtUserNo_Click(object sender, EventArgs e)
        {
            using (FKeyBoardNum f = new FKeyBoardNum("请输入账号"))
            {
                if (f.ShowDialog() == DialogResult.Yes)
                {
                    uiTxtUserNo.Text = f.output;
                }
                else
                    uiTxtUserNo.Text = "";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (uiTxtUserNo.Text=="000"&& uiTxtPsw.Text=="000")
            {
                SoftConfig.user.No = "000";
                SoftConfig.user.Name = "admin";
                SoftConfig.user.Psw = "000";
                FLoad fload = new FLoad();
                Task.Run(() => {
                    Thread.Sleep(1000);
                    fload.IsFinished = true;
                });
                fload.ShowDialog();

                FMain_Device f = new FMain_Device();
                f.Show();
                this.Hide();
                return;
            }
            var u = SoftConfig.db.User.Where(x => x.UserCode == uiTxtUserNo.Text).ToList();
            if (u != null && u.Count > 0)
            {
                if (u[0].UserPsw == uiTxtPsw.Text)
                {
                    SoftConfig.user.No = u[0].UserCode;
                    SoftConfig.user.Name = u[0].UserName;
                    SoftConfig.user.Psw = u[0].UserPsw;
                    if (ChangeUser)//切换用户
                    {
                        Close();
                        return;
                    }
                    else
                    {
                        FLoad fload = new FLoad();
                        Task.Run(() => {
                            Thread.Sleep(1000);
                            fload.IsFinished = true;
                        });
                        fload.ShowDialog();
                    }

                    FMain_Device f = new FMain_Device();
                    f.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("账号密码有误");
                    return;
                }
            }
            else
            {
                MessageBox.Show("账号密码有误");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiTxtPsw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键
            {
                btnLogin.PerformClick();
            }
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {
            FUpdateLog f = new FUpdateLog();
            f.ShowDialog();
        }
    }
}
