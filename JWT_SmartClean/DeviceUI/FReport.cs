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
    public partial class FReport : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();

        public FReport()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);

        }

        private void FReport_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this.Width, this.Height, this);
        }



        
    }
}
