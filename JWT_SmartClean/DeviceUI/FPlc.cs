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
    public partial class FPlc : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Hsl hsl = Hsl.Instance;
        public FPlc()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);

        }

        private void FPlc_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this.Width, this.Height, this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.front_after_air_out_1, true);
                    break;
                case "2":
                    hsl.WriteBool(hsl.front_after_air_out_2, true);
                    break;
                case "3":
                    hsl.WriteBool(hsl.front_after_air_out_3, true);
                    break;
                case "4":
                    hsl.WriteBool(hsl.front_after_air_out_4, true);
                    break;
            }
            Thread.Sleep(200);
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.front_after_air_out_1, false);
                    break;
                case "2":
                    hsl.WriteBool(hsl.front_after_air_out_2, false);
                    break;
                case "3":
                    hsl.WriteBool(hsl.front_after_air_out_3, false);
                    break;
                case "4":
                    hsl.WriteBool(hsl.front_after_air_out_4, false);
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.front_after_air_back_1, true);
                    break;
                case "2":
                    hsl.WriteBool(hsl.front_after_air_back_2, true);
                    break;
                case "3":
                    hsl.WriteBool(hsl.front_after_air_back_3, true);
                    break;
                case "4":
                    hsl.WriteBool(hsl.front_after_air_back_4, true);
                    break;
            }
            Thread.Sleep(200);
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.front_after_air_back_1, false);
                    break;
                case "2":
                    hsl.WriteBool(hsl.front_after_air_back_2, false);
                    break;
                case "3":
                    hsl.WriteBool(hsl.front_after_air_back_3, false);
                    break;
                case "4":
                    hsl.WriteBool(hsl.front_after_air_back_4, false);
                    break;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.clip_air_close_1, true);
                    break;
                case "2":
                    hsl.WriteBool(hsl.clip_air_close_2, true);
                    break;
                case "3":
                    hsl.WriteBool(hsl.clip_air_close_3, true);
                    break;
                case "4":
                    hsl.WriteBool(hsl.clip_air_close_4, true);
                    break;
            }
            Thread.Sleep(200);
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.clip_air_close_1, false);
                    break;
                case "2":
                    hsl.WriteBool(hsl.clip_air_close_2, false);
                    break;
                case "3":
                    hsl.WriteBool(hsl.clip_air_close_3, false);
                    break;
                case "4":
                    hsl.WriteBool(hsl.clip_air_close_4, false);
                    break;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.clip_air_open_1, true);
                    break;
                case "2":
                    hsl.WriteBool(hsl.clip_air_open_2, true);
                    break;
                case "3":
                    hsl.WriteBool(hsl.clip_air_open_3, true);
                    break;
                case "4":
                    hsl.WriteBool(hsl.clip_air_open_4, true);
                    break;
            }
            Thread.Sleep(200);
            switch (cbPosi.Text)
            {
                case "1":
                    hsl.WriteBool(hsl.clip_air_open_1, false);
                    break;
                case "2":
                    hsl.WriteBool(hsl.clip_air_open_2, false);
                    break;
                case "3":
                    hsl.WriteBool(hsl.clip_air_open_3, false);
                    break;
                case "4":
                    hsl.WriteBool(hsl.clip_air_open_4, false);
                    break;
            }
        }

        private void btnFJRun_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.cleancover_air_out, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.cleancover_air_out, false);
        }

        private void btnFJRunBack_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.cleancover_air_back, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.cleancover_air_back, false);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.blow_emvalve_work, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.blow_emvalve_work, false);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.blow_emvalve_stop, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.blow_emvalve_stop, false);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.Penetrability_emvalve_work, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.Penetrability_emvalve_work, false);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.Penetrability_emvalve_stop, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.Penetrability_emvalve_stop, false);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.bigsmall_clip_air_close_1, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.bigsmall_clip_air_close_1, false);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.bigsmall_clip_air_open_1, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.bigsmall_clip_air_open_1, false);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.superbig_clip_air_close_1, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.superbig_clip_air_close_1, false);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.superbig_clip_air_open_1, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.superbig_clip_air_open_1, false);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.ultrasonic, true);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.ultrasonic, false);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.heating, true);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.heating, false);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.loop, true);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.loop, false);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.x_origin, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.x_origin, false);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.y_origin, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.y_origin, false);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.y_origin, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.y_origin, false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.x_add, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.x_add, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.x_minu, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.x_minu, false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.y_add, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.y_add, false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.y_minu, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.y_minu, false);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.z_add, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.z_add, false);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(hsl.z_minu, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.z_minu, false);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            hsl.WriteFloat(hsl.x_posi_value,float.Parse(txtXPulse.Text));
            Thread.Sleep(100);
            hsl.WriteBool(hsl.x_posi, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.x_posi, false);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            hsl.WriteFloat(hsl.y_posi_value, float.Parse(txtYPulse.Text));
            Thread.Sleep(100);
            hsl.WriteBool(hsl.y_posi, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.y_posi, false);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            hsl.WriteFloat(hsl.z_posi_value, float.Parse(txtZPulse.Text));
            Thread.Sleep(100);
            hsl.WriteBool(hsl.z_posi, true);
            Thread.Sleep(200);
            hsl.WriteBool(hsl.z_posi, false);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedIndex==2)
            {
                timerShowWarn.Enabled = true;
            }
            else
            {
                timerShowWarn.Enabled = false;
            }
                
        }









        /// <summary>
        /// 异常查询页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerShowWarn_Tick(object sender, EventArgs e)
        {
            //int iNo = 0;
            //foreach (Control c in Controls)
            //{
            //    if (c.Name.Contains("light"))
            //    {
            //        iNo = int.Parse(c.Name.Substring(5, c.Name.Length - 5));
            //        (UILedBulb)c.On=
            //    }
            //}
            for (int i = 0; i < hsl.bWarn.Count(); i++)
            {
                Control[] lstControl = this.Controls.Find("light"+i.ToString(),true);
                if (lstControl.Count()>0)
                {
                    UILedBulb ub = (UILedBulb)lstControl[0];
                    ub.On = hsl.bWarn[i];
                }
            }

        }






        //参数设置页面
        private void button49_Click(object sender, EventArgs e)
        {
            //X轴
            FSetX f = new FSetX();
            f.ShowDialog();
        }

        private void button50_Click(object sender, EventArgs e)
        {
            //Y轴

        }

        private void button51_Click(object sender, EventArgs e)
        {
            //Z轴

        }


        private void button33_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D1350", float.Parse(uiTextBox3.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D1352", float.Parse(uiTextBox3.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D1850", float.Parse(uiTextBox3.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D1852", float.Parse(uiTextBox3.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2350", float.Parse(uiTextBox3.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2352", float.Parse(uiTextBox3.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        /// <summary>
        /// 刷新参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button31_Click(object sender, EventArgs e)
        {
            float[] fx = hsl.ReadFloat("D1350", 2);
            uiTextBox3.Text = fx[0].ToString();
            uiTextBox11.Text = fx[1].ToString();
            float[] fy = hsl.ReadFloat("D1850", 2);
            uiTextBox4.Text = fy[0].ToString();
            uiTextBox14.Text = fy[1].ToString();
            float[] fz = hsl.ReadFloat("D2350", 2);
            uiTextBox7.Text = fz[0].ToString();
            uiTextBox17.Text = fz[1].ToString();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            hsl.WriteInt(txtAdress.Text,Convert.ToInt32(txtValue.Text));

        }

        private void button35_Click(object sender, EventArgs e)
        {
            hsl.WriteFloat(txtAdress.Text, Convert.ToSingle(txtValue.Text));
        }

        private void button36_Click(object sender, EventArgs e)
        {
            hsl.WriteBool(txtAdress.Text, Convert.ToBoolean(txtValue.Text));
        }

        private void button38_Click(object sender, EventArgs e)
        {
           int[] a= hsl.ReadInt(txtAdress.Text, 4);
            txtShowValue.Text = a[0].ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            float[] a = hsl.ReadFloat(txtAdress.Text, 4);
            txtShowValue.Text = a[0].ToString();
        }

        private void button40_Click(object sender, EventArgs e)
        {
            bool[] a = hsl.ReadBool(txtAdress.Text, 4);
            txtShowValue.Text = a[0].ToString();
        }
    }
}
