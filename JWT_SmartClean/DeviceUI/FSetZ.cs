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
    public partial class FSetZ : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Hsl hsl = Hsl.Instance;
        public FSetZ()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);

        }

        private void FSetZ_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this.Width, this.Height, this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2202", float.Parse(uiTextBox8.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2224", float.Parse(uiTextBox8.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2246", float.Parse(uiTextBox8.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2268", float.Parse(uiTextBox8.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2206", float.Parse(uiTextBox7.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2228", float.Parse(uiTextBox7.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2250", float.Parse(uiTextBox7.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2272", float.Parse(uiTextBox7.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2002", float.Parse(uiTextBox1.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2024", float.Parse(uiTextBox1.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2046", float.Parse(uiTextBox1.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2068", float.Parse(uiTextBox1.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2012", float.Parse(uiTextBox2.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2034", float.Parse(uiTextBox2.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2056", float.Parse(uiTextBox2.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2078", float.Parse(uiTextBox2.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2014", float.Parse(uiTextBox3.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2036", float.Parse(uiTextBox3.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2058", float.Parse(uiTextBox3.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2080", float.Parse(uiTextBox3.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2004", float.Parse(uiTextBox12.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2026", float.Parse(uiTextBox12.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2048", float.Parse(uiTextBox12.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2070", float.Parse(uiTextBox12.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2006", float.Parse(uiTextBox11.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2028", float.Parse(uiTextBox11.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2050", float.Parse(uiTextBox11.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2072", float.Parse(uiTextBox11.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2008", float.Parse(uiTextBox10.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2030", float.Parse(uiTextBox10.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2052", float.Parse(uiTextBox10.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2074", float.Parse(uiTextBox10.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D2010", float.Parse(uiTextBox9.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D2032", float.Parse(uiTextBox9.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D2054", float.Parse(uiTextBox9.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D2076", float.Parse(uiTextBox9.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2000", float.Parse(txtReadyPosi.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button27_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2200", float.Parse(txtReadyPosiSpeed.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }


















        private void button23_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2090", float.Parse(uiTextBox24.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2092", float.Parse(uiTextBox23.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2094", float.Parse(uiTextBox22.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2096", float.Parse(uiTextBox21.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2098", float.Parse(uiTextBox20.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2100", float.Parse(uiTextBox19.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2102", float.Parse(uiTextBox18.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2104", float.Parse(uiTextBox17.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2106", float.Parse(uiTextBox16.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2108", float.Parse(uiTextBox5.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2302", float.Parse(uiTextBox27.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2304", float.Parse(uiTextBox26.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2306", float.Parse(uiTextBox25.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2308", float.Parse(uiTextBox4.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2290", float.Parse(uiTextBox15.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D2296", float.Parse(uiTextBox14.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            float[] fPosi = new float[7];
            switch (cbPosi.Text)
            {
                case "1":
                    fPosi = hsl.ReadFloat("D2002", 7);

                    uiTextBox8.Text = hsl.ReadFloat("D2202", 1)[0].ToString();
                    uiTextBox7.Text = hsl.ReadFloat("D2206", 1)[0].ToString();
                    break;
                case "2":
                    fPosi = hsl.ReadFloat("D2024", 7);

                    uiTextBox8.Text = hsl.ReadFloat("D2224", 1)[0].ToString();
                    uiTextBox7.Text = hsl.ReadFloat("D2228", 1)[0].ToString();
                    break;
                case "3":
                    fPosi = hsl.ReadFloat("D2036", 7);

                    uiTextBox8.Text = hsl.ReadFloat("D2246", 1)[0].ToString();
                    uiTextBox7.Text = hsl.ReadFloat("D2250", 1)[0].ToString();
                    break;
                case "4":
                    fPosi = hsl.ReadFloat("D2048", 7);

                    uiTextBox8.Text = hsl.ReadFloat("D2268", 1)[0].ToString();
                    uiTextBox7.Text = hsl.ReadFloat("D2272", 1)[0].ToString();
                    break;
            }
            uiTextBox1.Text = fPosi[0].ToString();
            uiTextBox2.Text = fPosi[1].ToString();
            uiTextBox3.Text = fPosi[2].ToString();
            uiTextBox12.Text = fPosi[3].ToString();
            uiTextBox11.Text = fPosi[4].ToString();
            uiTextBox10.Text = fPosi[5].ToString();
            uiTextBox9.Text = fPosi[6].ToString();

            //和工位无关
            txtReadyPosi.Text = hsl.ReadFloat("D2000", 1)[0].ToString();
            txtReadyPosiSpeed.Text = hsl.ReadFloat("D2200", 1)[0].ToString();

            float[] fxPosi = new float[9];
            fxPosi = hsl.ReadFloat("D2090", 10);
            uiTextBox24.Text = fxPosi[0].ToString();
            uiTextBox23.Text = fxPosi[1].ToString();
            uiTextBox22.Text = fxPosi[2].ToString();
            uiTextBox21.Text = fxPosi[3].ToString();
            uiTextBox20.Text = fxPosi[4].ToString();
            uiTextBox19.Text = fxPosi[5].ToString();
            uiTextBox18.Text = fxPosi[6].ToString();
            uiTextBox17.Text = fxPosi[7].ToString();
            uiTextBox16.Text = fxPosi[8].ToString();
            uiTextBox5.Text = fxPosi[9].ToString();

            uiTextBox15.Text = hsl.ReadFloat("D2290", 1)[0].ToString();
            uiTextBox14.Text = hsl.ReadFloat("D2296", 1)[0].ToString();
            uiTextBox27.Text = hsl.ReadFloat("D2302", 1)[0].ToString();
            uiTextBox26.Text = hsl.ReadFloat("D2304", 1)[0].ToString();
            uiTextBox25.Text = hsl.ReadFloat("D2306", 1)[0].ToString();
            uiTextBox4.Text = hsl.ReadFloat("D2308", 1)[0].ToString();
        }
    }
}
