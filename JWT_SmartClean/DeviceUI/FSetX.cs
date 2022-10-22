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
    public partial class FSetX : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Hsl hsl = Hsl.Instance;

        public FSetX()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);

        }

        private void FSetX_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this.Width, this.Height, this);
        }

        private void FSetX_Load(object sender, EventArgs e)
        {
            //读取X轴参数
            hsl.ReadFloat("D1122",18);

            hsl.ReadFloat("D1322", 18);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            bResult = hsl.WriteFloat("D1000",float.Parse(txtReadyPosi.Text));
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
            bResult = hsl.WriteFloat("D1200", float.Parse(txtReadyPosiSpeed.Text));
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
                    bResult = hsl.WriteFloat("D1002", float.Parse(txtTakePhoto1.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1032", float.Parse(txtTakePhoto1.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1062", float.Parse(txtTakePhoto1.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1092", float.Parse(txtTakePhoto1.Text));
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
                    bResult = hsl.WriteFloat("D1004", float.Parse(txtTakePhoto2.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1034", float.Parse(txtTakePhoto2.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1064", float.Parse(txtTakePhoto2.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1094", float.Parse(txtTakePhoto2.Text));
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
                    bResult = hsl.WriteFloat("D1006", float.Parse(txtTakePhoto3.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1036", float.Parse(txtTakePhoto3.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1066", float.Parse(txtTakePhoto3.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1096", float.Parse(txtTakePhoto3.Text));
                    break;
            }
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
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D1008", float.Parse(txtTakePhoto4.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1038", float.Parse(txtTakePhoto4.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1068", float.Parse(txtTakePhoto4.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1098", float.Parse(txtTakePhoto4.Text));
                    break;
            }
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
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D1010", float.Parse(txtTakePhoto5.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1040", float.Parse(txtTakePhoto5.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1070", float.Parse(txtTakePhoto5.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1100", float.Parse(txtTakePhoto5.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D1012", float.Parse(txtTakePhoto6.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1042", float.Parse(txtTakePhoto6.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1072", float.Parse(txtTakePhoto6.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1102", float.Parse(txtTakePhoto6.Text));
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
                    bResult = hsl.WriteFloat("D1014", float.Parse(txtExchangeBarCode.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1044", float.Parse(txtExchangeBarCode.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1074", float.Parse(txtExchangeBarCode.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1104", float.Parse(txtExchangeBarCode.Text));
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
                    bResult = hsl.WriteFloat("D1016", float.Parse(txtSmallTake.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1046", float.Parse(txtSmallTake.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1076", float.Parse(txtSmallTake.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1106", float.Parse(txtSmallTake.Text));
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
                    bResult = hsl.WriteFloat("D1018", float.Parse(txtBigTake.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1048", float.Parse(txtBigTake.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1078", float.Parse(txtBigTake.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1108", float.Parse(txtBigTake.Text));
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
                    bResult = hsl.WriteFloat("D1020", float.Parse(txtSuperBigTake.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1050", float.Parse(txtSuperBigTake.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1080", float.Parse(txtSuperBigTake.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1110", float.Parse(txtSuperBigTake.Text));
                    break;
            }
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        //速度存疑 多个工位是否要设置多次
        private void button7_Click(object sender, EventArgs e)
        {
            bool bResult = false;
            switch (cbPosi.Text)
            {
                case "1":
                    bResult = hsl.WriteFloat("D1202", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1204", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1206", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1208", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1210", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1212", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1214", float.Parse(txtTakePhotoSpeed.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1232", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1234", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1236", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1238", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1240", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1242", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1244", float.Parse(txtTakePhotoSpeed.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1262", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1264", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1266", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1268", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1270", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1272", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1274", float.Parse(txtTakePhotoSpeed.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1292", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1294", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1296", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1298", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1300", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1302", float.Parse(txtTakePhotoSpeed.Text));
                    //bResult = hsl.WriteFloat("D1304", float.Parse(txtTakePhotoSpeed.Text));
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
                    bResult = hsl.WriteFloat("D1216", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1218", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1220", float.Parse(txtTakeSpeed.Text));
                    break;
                case "2":
                    bResult = hsl.WriteFloat("D1246", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1248", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1250", float.Parse(txtTakeSpeed.Text));
                    break;
                case "3":
                    bResult = hsl.WriteFloat("D1276", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1278", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1280", float.Parse(txtTakeSpeed.Text));
                    break;
                case "4":
                    bResult = hsl.WriteFloat("D1306", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1308", float.Parse(txtTakeSpeed.Text));
                    //bResult = hsl.WriteFloat("D1310", float.Parse(txtTakeSpeed.Text));
                    break;
            }
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
            bResult = hsl.WriteFloat("D1122", float.Parse(txtSmallCleanPosi.Text));
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
            bResult = hsl.WriteFloat("D1124", float.Parse(txtBigCleanPosi.Text));
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
            bResult = hsl.WriteFloat("D1126", float.Parse(txtSuperBigCleanPosi.Text));
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
            bResult = hsl.WriteFloat("D1128", float.Parse(txtSmallNGPosi.Text));
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
            bResult = hsl.WriteFloat("D1130", float.Parse(txtBigNGPosi.Text));
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
            bResult = hsl.WriteFloat("D1132", float.Parse(txtBigNGPosi.Text));
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
            bResult = hsl.WriteFloat("D1134", float.Parse(txtBlowCheckPosi.Text));
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
            bResult = hsl.WriteFloat("D1136", float.Parse(txtMouseCheckPosi.Text));
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
            bResult = hsl.WriteFloat("D1138", float.Parse(txtBoardCheckPosi.Text));
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
            bResult = hsl.WriteFloat("D1322", float.Parse(txtCleanPosiSpeed.Text));
            //bResult = hsl.WriteFloat("D1324", float.Parse(txtCleanPosiSpeed.Text));
            //bResult = hsl.WriteFloat("D1326", float.Parse(txtCleanPosiSpeed.Text));
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
            bResult = hsl.WriteFloat("D1328", float.Parse(txtNGPosiSpeed.Text));
            //bResult = hsl.WriteFloat("D1330", float.Parse(txtNGPosiSpeed.Text));
            //bResult = hsl.WriteFloat("D1332", float.Parse(txtNGPosiSpeed.Text));
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
            bResult = hsl.WriteFloat("D1334", float.Parse(txtBlowCheckPosiSpeed.Text));
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
            bResult = hsl.WriteFloat("D1336", float.Parse(txtMouseCheckPosiSpeed.Text));
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
            bResult = hsl.WriteFloat("D1338", float.Parse(txtBoardCheckPosiSpeed.Text));
            if (bResult)
            {
                ShowSuccessTip("修改成功");
            }
            else
                ShowSuccessTip("修改失败");
        }

        /// <summary>
        /// 读取参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button28_Click(object sender, EventArgs e)
        {
            float[] fPosi = new float[10];
            switch (cbPosi.Text)
            {
                case "1":
                    fPosi = hsl.ReadFloat("D1002", 10);

                    txtTakePhotoSpeed.Text = hsl.ReadFloat("D1202", 1)[0].ToString();
                    txtTakeSpeed.Text = hsl.ReadFloat("D1216", 1)[0].ToString();
                    break;
                case "2":
                    fPosi = hsl.ReadFloat("D1032", 10);

                    txtTakePhotoSpeed.Text = hsl.ReadFloat("D1232", 1)[0].ToString();
                    txtTakeSpeed.Text = hsl.ReadFloat("D1246", 1)[0].ToString();
                    break;
                case "3":
                    fPosi = hsl.ReadFloat("D1062", 10);

                    txtTakePhotoSpeed.Text = hsl.ReadFloat("D1262", 1)[0].ToString();
                    txtTakeSpeed.Text = hsl.ReadFloat("D1276", 1)[0].ToString();
                    break;
                case "4":
                    fPosi = hsl.ReadFloat("D1092", 10);

                    txtTakePhotoSpeed.Text = hsl.ReadFloat("D1292", 1)[0].ToString();
                    txtTakeSpeed.Text = hsl.ReadFloat("D1306", 1)[0].ToString();
                    break;
            }
            txtTakePhoto1.Text = fPosi[0].ToString();
            txtTakePhoto2.Text = fPosi[1].ToString();
            txtTakePhoto3.Text = fPosi[2].ToString();
            txtTakePhoto4.Text = fPosi[3].ToString();
            txtTakePhoto5.Text = fPosi[4].ToString();
            txtTakePhoto6.Text = fPosi[5].ToString();
            txtExchangeBarCode.Text= fPosi[6].ToString();
            txtSmallTake.Text= fPosi[7].ToString();
            txtBigTake.Text= fPosi[8].ToString();
            txtSuperBigTake.Text= fPosi[9].ToString();

            //和工位无关
            txtReadyPosi.Text= hsl.ReadFloat("D1000", 1)[0].ToString();
            txtReadyPosiSpeed.Text = hsl.ReadFloat("D1200", 1)[0].ToString();

            float[] fxPosi = new float[9];
            fxPosi = hsl.ReadFloat("D1122", 9);
            txtSmallCleanPosi.Text = fxPosi[0].ToString();
            txtBigCleanPosi.Text = fxPosi[1].ToString();
            txtSuperBigCleanPosi.Text = fxPosi[2].ToString();
            txtSmallNGPosi.Text = fxPosi[3].ToString();
            txtBigNGPosi.Text = fxPosi[4].ToString();
            txtSuperBigNGPosi.Text = fxPosi[5].ToString();
            txtBlowCheckPosi.Text = fxPosi[6].ToString();
            txtMouseCheckPosi.Text = fxPosi[7].ToString();
            txtBoardCheckPosi.Text = fxPosi[8].ToString();
            txtCleanPosiSpeed.Text = hsl.ReadFloat("D1322",1)[0].ToString();
            txtNGPosiSpeed.Text = hsl.ReadFloat("D1328", 1)[0].ToString();
            txtBlowCheckPosiSpeed.Text = hsl.ReadFloat("D1334", 1)[0].ToString();
            txtMouseCheckPosiSpeed.Text = hsl.ReadFloat("D1336", 1)[0].ToString();
            txtBoardCheckPosiSpeed.Text = hsl.ReadFloat("D1338", 1)[0].ToString();
        }
    }
}
