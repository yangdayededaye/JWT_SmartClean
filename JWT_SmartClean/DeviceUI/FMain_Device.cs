using EntityFramework.Extensions;
using JWT_SmartClean.CommonUI;
using JWT_SmartClean.DeviceUI;
using JWT_SmartClean.Service;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VM.Core;
using VM.PlatformSDKCS;

namespace JWT_SmartClean
{
    public partial class FMain_Device : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public Hsl hsl = Hsl.Instance;
        public LogCls lg = LogCls.Instance;
        public CameraSocket cs = CameraSocket.Instance;
        
        public FMain_Device()
        {
            InitializeComponent();
            asc.controllInitializeSize(this,true);

            this.WindowState = FormWindowState.Maximized;
            this.Text = SoftConfig._SoftName;

            UserCenter.Text = SoftConfig.user.Name;
            
            //开启日志
            lg.init(true);
            //连接plc和数据库
            Task.Run(()=> {
                if (hsl.Init())
                    lightPLC.State = UILightState.On;
                else
                    lightPLC.State = UILightState.Off;

                if (Util.initDB())
                    lightDB.State = UILightState.On;
                else
                    lightDB.State = UILightState.Off;

                //加载视觉
                try
                {
                    VmSolution.Load("D:\\程序备份\\10.23.sol");//加载
                    SoftConfig.processList = GetCurrentSolProcedureList();
                    lightScan.State = UILightState.On;
                }
                catch (Exception ex)
                {
                    lightScan.State = UILightState.Off;
                }

                //cs.ReceiveCameraData+= ongetCameraData;
            });
            //加载异常配置
            ReadWarnMap();
            
            
            
        }

        /// <summary>
        /// 获取当前方案的流程列表
        /// </summary>
        private List<VmProcedure> GetCurrentSolProcedureList()
        {
            List<VmProcedure> procedureList = new List<VmProcedure>();
            string processName = "";
            var processInfoList = VmSolution.Instance.GetAllProcedureList();
            for (int i = 0; i < processInfoList.nNum; i++)
            {
                processName = processInfoList.astProcessInfo[i].strProcessName;
                procedureList.Add((VmProcedure)VmSolution.Instance[processName]);
            }
            return procedureList;
        }

        /// <summary>
        /// 相机接受事件
        /// </summary>
        /// <param name="str"></param>
        private void ongetCameraData(string str)
        {
            string[] Str = str.Split(';');
            string type = Str[0];//大中小gv
            string PhotoTime = Str[1];//拍照次数
            string info1 = Str[2];//1产品信息
            string info2 = Str[3];//2产品信息
            string info3 = Str[4];//3产品信息
            string info4 = Str[5];//4产品信息
            string info5 = Str[6];//5产品信息
            string info6 = Str[7];//6产品信息

            switch (PhotoTime)
            {   //第一次拍照
                case "1":
                    string[] str1 = info1.Split(',');//分割产品信息1
                    string flag1 = str1[0];//产品1信息
                    string ocr1 = str1[1];
                    string code1 = str1[2];
                    if (flag1 == "1")
                    {
                        hsl.WriteInt(hsl.locationX1, 1);
                        hsl.WriteInt(hsl.locationY1, 1);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX1, 0);
                        hsl.WriteInt(hsl.locationY1, 0);
                    }

                    string[] str2 = info2.Split(',');//分割产品信息2
                    string flag2 = str2[0];//产品2信息
                    string ocr2 = str2[1];
                    string code2 = str2[2];
                    if (flag2 == "1")
                    {
                        hsl.WriteInt(hsl.locationX2, 2);
                        hsl.WriteInt(hsl.locationY2, 1);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX2, 0);
                        hsl.WriteInt(hsl.locationY2, 0);
                    }

                    string[] str3 = info3.Split(',');//分割产品信息3
                    string flag3 = str3[0];//产品2信息
                    string ocr3 = str3[1];
                    string code3 = str3[2];
                    if (flag3 == "1")
                    {
                        hsl.WriteInt(hsl.locationX3, 1);
                        hsl.WriteInt(hsl.locationY3, 2);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX3, 0);
                        hsl.WriteInt(hsl.locationY3, 0);
                    }

                    string[] str4 = info4.Split(',');//分割产品信息4
                    string flag4 = str4[0];//产品4信息
                    string ocr4 = str4[1];
                    string code4 = str4[2];
                    if (flag4 == "1")
                    {
                        hsl.WriteInt(hsl.locationX4, 2);
                        hsl.WriteInt(hsl.locationY4, 2);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX4, 0);
                        hsl.WriteInt(hsl.locationY4, 0);
                    }

                    string[] str5 = info5.Split(',');//分割产品信息5
                    string flag5 = str5[0];//产品5信息
                    string ocr5 = str5[1];
                    string code5 = str5[2];
                    if (flag5 == "1")
                    {
                        hsl.WriteInt(hsl.locationX5, 1);
                        hsl.WriteInt(hsl.locationY5, 3);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX5, 0);
                        hsl.WriteInt(hsl.locationY5, 0);
                    }

                    string[] str6 = info6.Split(',');//分割产品信息6
                    string flag6 = str6[0];//产品6信息
                    string ocr6 = str6[1];
                    string code6 = str6[2];
                    if (flag6 == "1")
                    {
                        hsl.WriteInt(hsl.locationX6, 2);
                        hsl.WriteInt(hsl.locationY6, 3);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX6, 0);
                        hsl.WriteInt(hsl.locationY6, 0);
                    }


                    break;
              //第二次拍照

                case "2":
                    string[] str7 = info1.Split(',');//分割产品信息7
                    string flag7 = str7[0];//产品7信息
                    string ocr7 = str7[1];
                    string code7 = str7[2];
                    if (flag7 == "1")
                    {
                        hsl.WriteInt(hsl.locationX7, 3);
                        hsl.WriteInt(hsl.locationY7, 1);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX7, 0);
                        hsl.WriteInt(hsl.locationY7, 0);
                    }

                    string[] str8 = info2.Split(',');//分割产品信息8
                    string flag8 = str8[0];//产品8信息
                    string ocr8 = str8[1];
                    string code8 = str8[2];
                    if (flag8 == "1")
                    {
                        hsl.WriteInt(hsl.locationX8, 4);
                        hsl.WriteInt(hsl.locationY8, 1);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX8, 0);
                        hsl.WriteInt(hsl.locationY8, 0);
                    }

                    string[] str9 = info3.Split(',');//分割产品信息9
                    string flag9 = str9[0];//产品9信息
                    string ocr9 = str9[1];
                    string code9 = str9[2];
                    if (flag9 == "1")
                    {
                        hsl.WriteInt(hsl.locationX9, 3);
                        hsl.WriteInt(hsl.locationY9, 2);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX9, 0);
                        hsl.WriteInt(hsl.locationY9, 0);
                    }

                    string[] str10 = info4.Split(',');//分割产品信息10
                    string flag10 = str10[0];//产品10信息
                    string ocr10 = str10[1];
                    string code10 = str10[2];
                    if (flag10 == "1")
                    {
                        hsl.WriteInt(hsl.locationX10, 4);
                        hsl.WriteInt(hsl.locationY10 ,2);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX10, 0);
                        hsl.WriteInt(hsl.locationY10, 0);
                    }

                    string[] str11 = info5.Split(',');//分割产品信息11
                    string flag11 = str11[0];//产品11信息
                    string ocr11 = str11[1];
                    string code11 = str11[2];
                    if (flag11 == "1")
                    {
                        hsl.WriteInt(hsl.locationX11, 3);
                        hsl.WriteInt(hsl.locationY11, 3);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX11, 0);
                        hsl.WriteInt(hsl.locationY11, 0);
                    }

                    string[] str12 = info6.Split(',');//分割产品信息12
                    string flag12 = str12[0];//产品12信息
                    string ocr12 = str12[1];
                    string code12 = str12[2];
                    if (flag12 == "1")
                    {
                        hsl.WriteInt(hsl.locationX12, 4);
                        hsl.WriteInt(hsl.locationY12, 3);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX12, 0);
                        hsl.WriteInt(hsl.locationY12, 0);
                    }


                    break;


                //第三次拍照

                case "3":
                    string[] str13 = info1.Split(',');//分割产品信息13
                    string flag13 = str13[0];//产品13信息
                    string ocr13 = str13[1];
                    string code13 = str13[2];
                    if (flag13 == "1")
                    {
                        hsl.WriteInt(hsl.locationX13, 1);
                        hsl.WriteInt(hsl.locationY13, 4);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX13, 0);
                        hsl.WriteInt(hsl.locationY13, 0);
                    }

                    string[] str14 = info2.Split(',');//分割产品信息14
                    string flag14 = str14[0];//产品14信息
                    string ocr14 = str14[1];
                    string code14 = str14[2];
                    if (flag14 == "1")
                    {
                        hsl.WriteInt(hsl.locationX14, 2);
                        hsl.WriteInt(hsl.locationY14, 4);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX14, 0);
                        hsl.WriteInt(hsl.locationY14, 0);
                    }

                    string[] str15 = info3.Split(',');//分割产品信息15
                    string flag15 = str15[0];//产品15信息
                    string ocr15 = str15[1];
                    string code15 = str15[2];
                    if (flag15 == "1")
                    {
                        hsl.WriteInt(hsl.locationX15, 1);
                        hsl.WriteInt(hsl.locationY15, 5);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX15, 0);
                        hsl.WriteInt(hsl.locationY15, 0);
                    }

                    string[] str16 = info4.Split(',');//分割产品信息16
                    string flag16 = str16[0];//产品16信息
                    string ocr16 = str16[1];
                    string code16 = str16[2];
                    if (flag16 == "1")
                    {
                        hsl.WriteInt(hsl.locationX16, 2);
                        hsl.WriteInt(hsl.locationY16, 5);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX16, 0);
                        hsl.WriteInt(hsl.locationY16, 0);
                    }

                    string[] str17 = info5.Split(',');//分割产品信息17
                    string flag17 = str17[0];//产品17信息
                    string ocr17 = str17[1];
                    string code17 = str17[2];
                    if (flag17 == "1")
                    {
                        hsl.WriteInt(hsl.locationX17, 1);
                        hsl.WriteInt(hsl.locationY17, 6);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX17, 0);
                        hsl.WriteInt(hsl.locationY17, 0);
                    }

                    string[] str18 = info6.Split(',');//分割产品信息18
                    string flag18 = str18[0];//产品18信息
                    string ocr18 = str18[1];
                    string code18 = str18[2];
                    if (flag18 == "1")
                    {
                        hsl.WriteInt(hsl.locationX18, 2);
                        hsl.WriteInt(hsl.locationY18, 6);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX18, 0);
                        hsl.WriteInt(hsl.locationY18, 0);
                    }


                    break;


                //第四次拍照

                case "4":
                    string[] str19 = info1.Split(',');//分割产品信息19
                    string flag19 = str19[0];//产品19信息
                    string ocr19 = str19[1];
                    string code19 = str19[2];
                    if (flag19 == "1")
                    {
                        hsl.WriteInt(hsl.locationX19, 3);
                        hsl.WriteInt(hsl.locationY19, 4);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX19, 0);
                        hsl.WriteInt(hsl.locationY19, 0);
                    }

                    string[] str20 = info2.Split(',');//分割产品信息20
                    string flag20 = str20[0];//产品20信息
                    string ocr20 = str20[1];
                    string code20 = str20[2];
                    if (flag20 == "1")
                    {
                        hsl.WriteInt(hsl.locationX20, 4);
                        hsl.WriteInt(hsl.locationY20, 4);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX20, 0);
                        hsl.WriteInt(hsl.locationY20, 0);
                    }

                    string[] str21 = info3.Split(',');//分割产品信息21
                    string flag21 = str21[0];//产品21信息
                    string ocr21 = str21[1];
                    string code21 = str21[2];
                    if (flag21 == "1")
                    {
                        hsl.WriteInt(hsl.locationX21, 3);
                        hsl.WriteInt(hsl.locationY21, 5);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX21,0);
                        hsl.WriteInt(hsl.locationY21, 0);
                    }

                    string[] str22 = info4.Split(',');//分割产品信息22
                    string flag22 = str22[0];//产品22信息
                    string ocr22 = str22[1];
                    string code22 = str22[2];
                    if (flag22 == "1")
                    {
                        hsl.WriteInt(hsl.locationX22, 4);
                        hsl.WriteInt(hsl.locationY22, 5);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX22, 0);
                        hsl.WriteInt(hsl.locationY22, 0);
                    }

                    string[] str23 = info5.Split(',');//分割产品信息23
                    string flag23 = str23[0];//产品23信息
                    string ocr23 = str23[1];
                    string code23 = str23[2];
                    if (flag23 == "1")
                    {
                        hsl.WriteInt(hsl.locationX23, 3);
                        hsl.WriteInt(hsl.locationY23, 6);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX23, 0);
                        hsl.WriteInt(hsl.locationY23, 0);
                    }

                    string[] str24 = info6.Split(',');//分割产品信息24
                    string flag24 = str24[0];//产品24信息
                    string ocr24 = str24[1];
                    string code24 = str24[2];
                    if (flag24 == "1")
                    {
                        hsl.WriteInt(hsl.locationX24, 4);
                        hsl.WriteInt(hsl.locationY24, 6);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX24, 0);
                        hsl.WriteInt(hsl.locationY24, 0);
                    }


                    break;

                //第5次拍照

                case "5":
                    string[] str25 = info1.Split(',');//分割产品信息25
                    string flag25 = str25[0];//产品25信息
                    string ocr25 = str25[1];
                    string code25 = str25[2];
                    if (flag25 == "1")
                    {
                        hsl.WriteInt(hsl.locationX25, 1);
                        hsl.WriteInt(hsl.locationY25, 7);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX25, 0);
                        hsl.WriteInt(hsl.locationY25, 0);
                    }

                    string[] str26 = info2.Split(',');//分割产品信息26
                    string flag26 = str26[0];//产品26信息
                    string ocr26 = str26[1];
                    string code26 = str26[2];
                    if (flag26 == "1")
                    {
                        hsl.WriteInt(hsl.locationX26, 2);
                        hsl.WriteInt(hsl.locationY26, 7);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX26, 0);
                        hsl.WriteInt(hsl.locationY26, 0);
                    }

                    string[] str27 = info3.Split(',');//分割产品信息27
                    string flag27 = str27[0];//产品27信息
                    string ocr27 = str27[1];
                    string code27 = str27[2];
                    if (flag27 == "1")
                    {
                        hsl.WriteInt(hsl.locationX27, 1);
                        hsl.WriteInt(hsl.locationY27, 8);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX27, 0);
                        hsl.WriteInt(hsl.locationY27, 0);
                    }

                    string[] str28 = info4.Split(',');//分割产品信息28
                    string flag28 = str28[0];//产品28信息
                    string ocr28 = str28[1];
                    string code28 = str28[2];
                    if (flag28 == "1")
                    {
                        hsl.WriteInt(hsl.locationX28, 2);
                        hsl.WriteInt(hsl.locationY28, 8);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX28, 0);
                        hsl.WriteInt(hsl.locationY28, 0);
                    }

                  

                    break;


                //第6次拍照

                case "6":
                    string[] str29 = info1.Split(',');//分割产品信息29
                    string flag29 = str29[0];//产品29信息
                    string ocr29 = str29[1];
                    string code29 = str29[2];
                    if (flag29 == "1")
                    {
                        hsl.WriteInt(hsl.locationX29, 3);
                        hsl.WriteInt(hsl.locationY29, 7);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX29, 0);
                        hsl.WriteInt(hsl.locationY29, 0);
                    }

                    string[] str30 = info2.Split(',');//分割产品信息30
                    string flag30 = str30[0];//产品30信息
                    string ocr30 = str30[1];
                    string code30 = str30[2];
                    if (flag30 == "1")
                    {
                        hsl.WriteInt(hsl.locationX30, 4);
                        hsl.WriteInt(hsl.locationY30, 7);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX30, 0);
                        hsl.WriteInt(hsl.locationY30, 0);
                    }

                    string[] str31 = info3.Split(',');//分割产品信息31
                    string flag31 = str31[0];//产品31信息
                    string ocr31 = str31[1];
                    string code31 = str31[2];
                    if (flag31 == "1")
                    {
                        hsl.WriteInt(hsl.locationX31, 3);
                        hsl.WriteInt(hsl.locationY31, 8);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX31, 0);
                        hsl.WriteInt(hsl.locationY31, 0);
                    }

                    string[] str32 = info4.Split(',');//分割产品信息32
                    string flag32 = str32[0];//产品32信息
                    string ocr32 = str32[1];
                    string code32 = str32[2];
                    if (flag32 == "1")
                    {
                        hsl.WriteInt(hsl.locationX32, 4);
                        hsl.WriteInt(hsl.locationY32, 8);
                    }
                    else
                    {
                        hsl.WriteInt(hsl.locationX32, 0);
                        hsl.WriteInt(hsl.locationY32, 0);
                    }



                    break;
            }





        }


        

        public bool ReadWarnMap()
        {
            try
            {
                FileInfo finfo = new FileInfo(System.Environment.CurrentDirectory+"\\warn.txt");
                FileStream fs = finfo.Open(FileMode.OpenOrCreate,
                FileAccess.ReadWrite);
                StreamReader sr = new StreamReader(fs);
                string strList = sr.ReadLine();
                while (strList != null)
                {
                    if (strList.Contains("="))
                    {
                        int iKey = -1;
                        int.TryParse(strList.Split('=')[0],out iKey);
                        if (iKey!=-1&&!SoftConfig._WarnMap.ContainsKey(iKey))
                        {
                            SoftConfig._WarnMap.Add(iKey, strList.Split('=')[1]);
                        }
                    }
                    strList = sr.ReadLine();
                }
                sr.Close();
                fs.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private void FMain_Manage_Resize(object sender, EventArgs e)
        {
            asc.controlAutoSize(this.Width, this.Height, this, true);
        }


        private void FMain_Device_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!ShowAskDialog("确认退出系统吗？"))
            {
                e.Cancel = true;
            }
            else
            {
                foreach (Process p in Process.GetProcesses())
                {
                    if (p.ProcessName.Contains("JWT_SmartClean"))
                    {
                        try
                        {
                            p.Kill();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }
            }
        }

        

        private void hbtnSortAuto_Click(object sender, EventArgs e)
        {
            FClean f = new FClean();
            f.ShowDialog();
        }

        private void hbtnReport_Click(object sender, EventArgs e)
        {
            FDataView f = new FDataView();
            f.ShowDialog();
        }

        private void hbtnUser_Click(object sender, EventArgs e)
        {
            FUser f = new FUser();
            f.ShowDialog();
        }

        private void hbtnTest_Click(object sender, EventArgs e)
        {
            //VmSolution.OnWorkStatusEvent -= VmSolution_OnWorkStatusEvent;//注册流程状态回调
            FTest f = new FTest();
            f.ShowDialog();
            //VmSolution.OnWorkStatusEvent += VmSolution_OnWorkStatusEvent;//注册流程状态回调
        }

        private void hbtnSet_Click(object sender, EventArgs e)
        {
            FSet f = new FSet();
            f.ShowDialog();
        }

        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public int iTouchTime = 0;
        private void FMain_Device_Click(object sender, EventArgs e)
        {
            iTouchTime++;
            if (iTouchTime==10)
            {
                iTouchTime = 0;
                FUpdateLog f = new FUpdateLog();
                f.ShowDialog();
            }
        }

        private void UserCenter_Click(object sender, EventArgs e)
        {
            VmSolution.Instance.Run();
            //if (ShowAskDialog("请选择需要的操作,点击\"确定\"切换用户,点击\"取消\"修改密码"))
            //{
            //    FLogin f = new FLogin(true);
            //    f.ShowDialog();
            //}
            //else
            //{
            //    FChangePsw f = new FChangePsw();
            //    f.ShowDialog();
            //}
        }
    }
}
