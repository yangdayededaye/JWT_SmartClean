using EntityFramework.Extensions;
using JWT_SmartClean.Service;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JWT_SmartClean
{
    public partial class FClean : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public LogCls log = LogCls.Instance;
        public Hsl hsl = Hsl.Instance;

        public CancellationTokenSource cts=new CancellationTokenSource();

        public FClean()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);
            this.WindowState = FormWindowState.Maximized;
        }
        

        private void FClean_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this.Width, this.Height, this);
        }

        private void FClean_Load(object sender, EventArgs e)
        {
            Task.Run(()=> {
                while (true)
                {
                    if (cts.Token.IsCancellationRequested)
                    {
                        return;
                    }
                    hsl.SendCommand("Check");
                    Task.Delay(200);
                    //刷新显示

                }
            },cts.Token);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        


        private void lbWarn_Click(object sender, EventArgs e)
        {
            //说明文字


            //工位
            uc_BoxSmall ub1 = new uc_BoxSmall();
            ub1.Location = new Point(100, 250);
            ub1.Size = new Size(110, 110);
            this.Controls.Add(ub1);
            uc_BoxSmall ub2 = new uc_BoxSmall();
            ub2.Location = new Point(300, 250);
            ub2.Size = new Size(110, 110);
            this.Controls.Add(ub2);
            uc_BoxMiddle ub3 = new uc_BoxMiddle();
            ub3.Location = new Point(500, 250);
            ub3.Size = new Size(110, 110);
            this.Controls.Add(ub3);
            uc_BoxMiddle ub4 = new uc_BoxMiddle();
            ub4.Location = new Point(700, 400);
            ub4.Size = new Size(110, 110);
            this.Controls.Add(ub4);
            //NG
            uc_BoxSmall ubNGSmall = new uc_BoxSmall();
            ubNGSmall.Location = new Point(500, 80);
            ubNGSmall.Size = new Size(110, 110);
            this.Controls.Add(ubNGSmall);
            uc_BoxMiddle ubNGMiddle = new uc_BoxMiddle();
            ubNGMiddle.Location = new Point(700, 80);
            ubNGMiddle.Size = new Size(110, 110);
            this.Controls.Add(ubNGMiddle);

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            cts.Cancel();
            Close();
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            

        }

        
    }
}
