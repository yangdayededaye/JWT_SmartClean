﻿using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWT_SmartClean
{
    public partial class FChangePsw : UIForm
    {
        public FChangePsw()
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtOldPsw.Text == "" || txtNewPsw.Text == "" || txtNewPswValid.Text == "")
            {
                MessageBox.Show("请输入完整");
                return;
            }

            if (txtNewPsw.Text != txtNewPswValid.Text)
            {
                MessageBox.Show("两次输入不一致");
                return;
            }

            if (txtOldPsw.Text != SoftConfig.user.Psw)
            {
                MessageBox.Show("原密码有误");
                return;
            }

            var u = SoftConfig.db.User.Where(x => x.UserCode == SoftConfig.user.No).ToList();
            u[0].UserPsw = txtNewPswValid.Text;
            SoftConfig.user.Psw = txtNewPswValid.Text;
            SoftConfig.db.SaveChanges();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
