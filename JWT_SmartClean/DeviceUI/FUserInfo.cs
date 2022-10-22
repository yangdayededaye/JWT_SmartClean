using EntityFramework.Extensions;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWT_SmartClean.DeviceUI
{
    public partial class FUserInfo : UIForm
    {
        public UserCls u = null;
        public FUserInfo(UserCls _u)
        {
            InitializeComponent();
            u = _u;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCode.Text == "" || txtName.Text == "")
            {
                ShowWarningTip("请输入完整");
                return;
            }

            if (txtCode.Text=="000")
            {
                ShowWarningTip("非法的账号");
                return;
            }

            if (u==null)
            {
                User b = new User();
                b.UserCode = txtCode.Text;
                b.UserName = txtName.Text;
                b.UserPY = txtPY.Text;
                SoftConfig.db.User.Add(b);
                SoftConfig.db.SaveChanges();

                ShowSuccessTip("添加成功");
            }
            else
            {
                SoftConfig.db.User.Where(x => x.ID == u.ID).Update(x => new User { UserCode=txtCode.Text,UserName = txtName.Text, UserPY = txtPY.Text });
                SoftConfig.db.SaveChanges();
                Util.initDB();
                ShowSuccessTip("修改成功");
            }
            
            Close();
        }

        private void FUserInfo_Load(object sender, EventArgs e)
        {
            if (u != null)
            {
                txtCode.Text = u.No;
                txtName.Text = u.Name;
                txtPY.Text = u.PY;
            }
        }
    }
}
