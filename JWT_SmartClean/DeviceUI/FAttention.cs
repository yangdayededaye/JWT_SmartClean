using JWT_SmartClean.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWT_SmartClean
{
    public partial class FAttention : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public FAttention(string strTitle)
        {
            InitializeComponent();
            lbState.Text = strTitle;
            asc.controllInitializeSize(this);
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnNG_Click(object sender, EventArgs e)
        {
            //写NG
            
            this.DialogResult = DialogResult.OK;
        }

        private void FAttention_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this.Width, this.Height, this);
        }
    }
}
