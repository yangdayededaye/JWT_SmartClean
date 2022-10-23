using EntityFramework.Extensions;
using JWT_SmartClean.Model;
using JWT_SmartClean.Service;
using Newtonsoft.Json;
using SaveImageCs;
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
using VM.Core;
using VM.PlatformSDKCS;

namespace JWT_SmartClean
{
    public partial class FClean : UIForm
    {
        AutoSizeFormClass asc = new AutoSizeFormClass();
        public LogCls lg = LogCls.Instance;
        public Hsl hsl = Hsl.Instance;

        public CancellationTokenSource cts=new CancellationTokenSource();

        public FClean()
        {
            InitializeComponent();
            asc.controllInitializeSize(this);
            this.WindowState = FormWindowState.Maximized;
            //注册
            VmSolution.OnWorkStatusEvent += VmSolution_OnWorkStatusEvent;//注册流程状态回调
            //加载运行界面
            vmFrontendControl1.LoadFrontendSource();
        }

        public VmProcedure GetProcessByID(uint ID)
        {
            for (int i = 0; i < SoftConfig.processList.Count(); i++)
            {
                if (SoftConfig.processList[i].ID==ID)
                {
                    return SoftConfig.processList[i];
                }
            }
            return null;
        }

        /// <summary>
        /// 回调函数
        /// </summary>
        /// <param name="workStatusInfo"></param>
        private void VmSolution_OnWorkStatusEvent(VM.PlatformSDKCS.ImvsSdkDefine.IMVS_MODULE_WORK_STAUS workStatusInfo)
        {
            try
            {
                //小型工位拍照
                if (workStatusInfo.nWorkStatus == 0 && workStatusInfo.nProcessID == 10003)
                {

                    List<VmDynamicIODefine.IoNameInfo> ioNameInfos = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetAllOutputNameInfo();
                    if (ioNameInfos.Count != 0)//判断流程结果个数是否为0
                    {
                        if (ioNameInfos[0].TypeName == IMVS_MODULE_BASE_DATA_TYPE.IMVS_GRAP_TYPE_STRING)//判断流程第一个结果是否为字符串类型
                        {
                            //获取流程结果
                            string strResult = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetOutputString(ioNameInfos[0].Name).astStringVal[0].strValue;
                            if (strResult != null)
                            {
                                lg.SendCommand("10003小型工位拍照获取结果:"+ strResult, 1);
                                //解析输出
                                GetInfoByResult(strResult);
                            }
                            else
                            {
                                 lg.SendCommand("10003小型工位拍照获取结果失败：结果为空!", 1);
                            }
                        }
                    }
                    else
                    {
                        //strMessage = "获取结果失败：流程结果个数为0!";
                    }
                }
                //大型工位拍照
                if (workStatusInfo.nWorkStatus == 0 && workStatusInfo.nProcessID == 10004)//流程空闲且为流程
                {
                    List<VmDynamicIODefine.IoNameInfo> ioNameInfos = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetAllOutputNameInfo();
                    if (ioNameInfos.Count != 0)//判断流程结果个数是否为0
                    {
                        if (ioNameInfos[0].TypeName == IMVS_MODULE_BASE_DATA_TYPE.IMVS_GRAP_TYPE_STRING)//判断流程第一个结果是否为字符串类型
                        {
                            //获取流程结果
                            string strResult = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetOutputString(ioNameInfos[0].Name).astStringVal[0].strValue;
                            if (strResult != null)
                            {
                                lg.SendCommand("10004大型工位拍照获取结果:" + strResult, 1);
                                //解析输出
                                GetInfoByResult(strResult);
                            }
                            else
                            {
                                lg.SendCommand("10004大型工位拍照获取结果失败：结果为空!", 1);
                                //strMessage = "获取结果失败：结果为空!";
                            }
                        }
                    }
                    else
                    {
                        //strMessage = "获取结果失败：流程结果个数为0!";
                    }
                }
                //超大型工位拍照
                if (workStatusInfo.nWorkStatus == 0 && workStatusInfo.nProcessID == 10005)//流程空闲且为流程
                {
                    List<VmDynamicIODefine.IoNameInfo> ioNameInfos = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetAllOutputNameInfo();
                    if (ioNameInfos.Count != 0)//判断流程结果个数是否为0
                    {
                        if (ioNameInfos[0].TypeName == IMVS_MODULE_BASE_DATA_TYPE.IMVS_GRAP_TYPE_STRING)//判断流程第一个结果是否为字符串类型
                        {
                            //获取流程结果
                            string strResult = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetOutputString(ioNameInfos[0].Name).astStringVal[0].strValue;
                            if (strResult != null)
                            {
                                lg.SendCommand("10005超大型工位拍照获取结果:" + strResult, 1);
                                //解析输出
                                GetInfoByResult(strResult);
                            }
                            else
                            {
                                lg.SendCommand("10005超大型工位拍照获取结果失败：结果为空!", 1);
                                //strMessage = "获取结果失败：结果为空!";
                            }
                        }
                    }
                    else
                    {
                        //strMessage = "获取结果失败：流程结果个数为0!";
                    }
                }

                //喷嘴
                if (workStatusInfo.nWorkStatus == 1 && workStatusInfo.nProcessID == 10008)
                {
                    int iIndex = hsl.ReadInt("D3019", 1)[0];
                    WorkPiece wp = GetWorkPieceByIndex(iIndex);
                    SaveImageTool saveImage = (SaveImageTool)VmSolution.Instance["吸嘴前.输出图像1"];
                    saveImage.ModuParams.SetParamValue("RenderImgPath", @"D:\VM\"+iIndex.ToString()+"_"+wp.BarCode + "_" + wp.Ocr+"_1.jpg");
                    lg.SendCommand("10008设置喷嘴清洗前图片路径:" + @"D:\VM\" + iIndex.ToString() + "_" + wp.BarCode + "_" + wp.Ocr + "_1.jpg", 0);
                    Task.Run(()=> {
                        while (hsl.ReadUShort("D3020",1)[0]!=1)
                        {
                            Thread.Sleep(200);
                        }
                        VmProcedure procedure = VmSolution.Instance[wp.Ocr] as VmProcedure;
                        if (procedure != null)
                        {
                            procedure.Run();
                        }
                    });
                }
                if (workStatusInfo.nWorkStatus == 0 && workStatusInfo.nProcessID == 10000)
                {
                    int iIndex = hsl.ReadInt("D3019", 1)[0];
                    int iWorkPieceIndex = GetWorkPieceIndexByIndex(iIndex);
                    List<VmDynamicIODefine.IoNameInfo> ioNameInfos = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetAllOutputNameInfo();
                    if (ioNameInfos.Count != 0)//判断流程结果个数是否为0
                    {
                        if (ioNameInfos[0].TypeName == IMVS_MODULE_BASE_DATA_TYPE.IMVS_GRAP_TYPE_STRING)//判断流程第一个结果是否为字符串类型
                        {
                            //获取流程结果
                            string strResult = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetOutputString(ioNameInfos[0].Name).astStringVal[0].strValue;
                            if (strResult != null)
                            {
                                lg.SendCommand("10000获取喷嘴检测结果:"+strResult, 0);
                                SoftConfig.lstWorkPiece[iWorkPieceIndex].MouseResult = strResult;
                            }
                            else
                            {
                                lg.SendCommand("10000获取喷嘴检测结果失败：结果为空!", 1);
                                //strMessage = "获取结果失败：结果为空!";
                            }
                        }
                    }
                    else
                    {
                        //strMessage = "获取结果失败：流程结果个数为0!";
                    }
                }
                //反光板
                if (workStatusInfo.nWorkStatus == 1 && workStatusInfo.nProcessID == 10006)
                {
                    int iIndex = hsl.ReadInt("D3019", 1)[0];
                    WorkPiece wp = GetWorkPieceByIndex(iIndex);
                    SaveImageTool saveImage = (SaveImageTool)VmSolution.Instance["反光板前.输出图像1"];
                    saveImage.ModuParams.SetParamValue("RenderImgPath", @"D:\VM\" + iIndex.ToString() + "_" + wp.BarCode + "_" + wp.Ocr + "_2.jpg");
                    lg.SendCommand("10006设置反光板清洗前图片路径:" + @"D:\VM\" + iIndex.ToString() + "_" + wp.BarCode + "_" + wp.Ocr + "_1.jpg", 0);
                    Task.Run(() => {
                        while (hsl.ReadUShort("D3030", 1)[0]!=1)
                        {
                            Thread.Sleep(200);
                        }
                        VmProcedure procedure = VmSolution.Instance["反光板"] as VmProcedure;
                        if (procedure != null)
                        {
                            procedure.Run();
                        }
                    });
                }
                if (workStatusInfo.nWorkStatus == 0 && workStatusInfo.nProcessID == 10007)
                {
                    int iIndex = hsl.ReadInt("D3019", 1)[0];
                    int iWorkPieceIndex = GetWorkPieceIndexByIndex(iIndex);
                    List<VmDynamicIODefine.IoNameInfo> ioNameInfos = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetAllOutputNameInfo();
                    if (ioNameInfos.Count != 0)//判断流程结果个数是否为0
                    {
                        if (ioNameInfos[0].TypeName == IMVS_MODULE_BASE_DATA_TYPE.IMVS_GRAP_TYPE_STRING)//判断流程第一个结果是否为字符串类型
                        {
                            //获取流程结果
                            string strResult = GetProcessByID(workStatusInfo.nProcessID).ModuResult.GetOutputString(ioNameInfos[0].Name).astStringVal[0].strValue;
                            if (strResult != null)
                            {
                                lg.SendCommand("10007获取反光板检测结果:" + strResult, 0);
                                SoftConfig.lstWorkPiece[iWorkPieceIndex].ReflectBoardResult = strResult;
                            }
                            else
                            {
                                lg.SendCommand("10007获取反光板结果失败：结果为空!", 1);
                                //strMessage = "获取结果失败：结果为空!";
                            }
                        }
                    }
                    else
                    {
                        //strMessage = "获取结果失败：流程结果个数为0!";
                    }
                }
            }
            catch (VmException ex)
            {
                //strMessage = "获取结果失败，错误码：0x" + Convert.ToString(ex.errorCode, 16);
            }
            catch (Exception ex)
            {
                //strMessage = "获取结果失败：" + Convert.ToString(ex.Message);
            }
        }

        public WorkPiece GetWorkPieceByIndex(int index)
        {
            for (int i = 0; i < SoftConfig.lstWorkPiece.Count; i++)
            {
                if (SoftConfig.lstWorkPiece[i].Index==index)
                {
                    return SoftConfig.lstWorkPiece[i];
                }
            }
            return null;
        }

        public int GetWorkPieceIndexByIndex(int index)
        {
            for (int i = 0; i < SoftConfig.lstWorkPiece.Count; i++)
            {
                if (SoftConfig.lstWorkPiece[i].Index == index)
                {
                    return i;
                }
            }
            return -1;
        }

        public void GetInfoByResult(string str)
        {
            try
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
                WorkPiece wp1 = new WorkPiece();
                WorkPiece wp2 = new WorkPiece();
                WorkPiece wp3 = new WorkPiece();
                WorkPiece wp4 = new WorkPiece();
                WorkPiece wp5 = new WorkPiece();
                WorkPiece wp6 = new WorkPiece();

                EWorkPieceType eType=new EWorkPieceType();
                switch (type)
                {
                    case "3":
                        eType = EWorkPieceType.superbig;
                        break;
                    case "2":
                        eType = EWorkPieceType.big;
                        break;
                    case "1":
                        eType = EWorkPieceType.small;
                        break;
                }

                switch (PhotoTime)
                {   //第一次拍照
                    case "1":
                        //上传上一次的结果
                        if (SoftConfig.lstWorkPiece!=null&&SoftConfig.lstWorkPiece.Count>0)
                        {
                            for (int i = 0; i < SoftConfig.lstWorkPiece.Count; i++)
                            {
                                CleanLog cl = new CleanLog();
                                cl.LogIndex = SoftConfig.lstWorkPiece[i].Index;
                                cl.LogTime = DateTime.Now;
                                cl.BarCode = SoftConfig.lstWorkPiece[i].BarCode;
                                cl.Ocr = SoftConfig.lstWorkPiece[i].Ocr;
                                cl.Type = SoftConfig.lstWorkPiece[i].Type.ToString();
                                cl.MouseResult = SoftConfig.lstWorkPiece[i].MouseResult;
                                cl.ReflectPanelResult = SoftConfig.lstWorkPiece[i].ReflectBoardResult;
                                SoftConfig.db.CleanLog.Add(cl);
                            }
                            SoftConfig.db.SaveChanges();
                            //清空
                            SoftConfig.lstWorkPiece = new List<WorkPiece>();
                        }
                        string[] str1 = info1.Split(',');//分割产品信息1
                        string flag1 = str1[0];//产品1信息
                        string ocr1 = str1[2];
                        string code1 = str1[1];
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
                        
                        wp1.Index = 1;
                        wp1.Type = eType;
                        wp1.IsExist = flag1 == "1" ? true : false;
                        wp1.Ocr = ocr1;
                        wp1.BarCode = code1;
                        SoftConfig.lstWorkPiece.Add(wp1);

                        string[] str2 = info2.Split(',');//分割产品信息2
                        string flag2 = str2[0];//产品2信息
                        string ocr2 = str2[2];
                        string code2 = str2[1];
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
                        
                        wp2.Index = 2;
                        wp2.Type = eType;
                        wp2.IsExist = flag2 == "1" ? true : false;
                        wp2.Ocr = ocr2;
                        wp2.BarCode = code2;
                        SoftConfig.lstWorkPiece.Add(wp2);

                        string[] str3 = info3.Split(',');//分割产品信息3
                        string flag3 = str3[0];//产品2信息
                        string ocr3 = str3[2];
                        string code3 = str3[1];
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
                        
                        wp3.Index = 2;
                        wp3.Type = eType;
                        wp3.IsExist = flag2 == "1" ? true : false;
                        wp3.Ocr = ocr2;
                        wp3.BarCode = code2;
                        SoftConfig.lstWorkPiece.Add(wp3);

                        string[] str4 = info4.Split(',');//分割产品信息4
                        string flag4 = str4[0];//产品4信息
                        string ocr4 = str4[2];
                        string code4 = str4[1];
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
                        
                        wp4.Index = 4;
                        wp4.Type = eType;
                        wp4.IsExist = flag4 == "1" ? true : false;
                        wp4.Ocr = ocr4;
                        wp4.BarCode = code4;
                        SoftConfig.lstWorkPiece.Add(wp4);

                        string[] str5 = info5.Split(',');//分割产品信息5
                        string flag5 = str5[0];//产品5信息
                        string ocr5 = str5[2];
                        string code5 = str5[1];
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
                        
                        wp5.Index = 5;
                        wp5.Type = eType;
                        wp5.IsExist = flag5 == "1" ? true : false;
                        wp5.Ocr = ocr5;
                        wp5.BarCode = code5;
                        SoftConfig.lstWorkPiece.Add(wp5);

                        string[] str6 = info6.Split(',');//分割产品信息6
                        string flag6 = str6[0];//产品6信息
                        string ocr6 = str6[2];
                        string code6 = str6[1];
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
                        
                        wp6.Index = 6;
                        wp6.Type = eType;
                        wp6.IsExist = flag6 == "1" ? true : false;
                        wp6.Ocr = ocr6;
                        wp6.BarCode = code6;
                        SoftConfig.lstWorkPiece.Add(wp6);

                        break;
                    //第二次拍照

                    case "2":
                        string[] str7 = info1.Split(',');//分割产品信息7
                        string flag7 = str7[0];//产品7信息
                        string ocr7 = str7[2];
                        string code7 = str7[1];
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
                        wp1.Index = 7;
                        wp1.Type = eType;
                        wp1.IsExist = flag7 == "1" ? true : false;
                        wp1.Ocr = ocr7;
                        wp1.BarCode = code7;
                        SoftConfig.lstWorkPiece.Add(wp1);

                        string[] str8 = info2.Split(',');//分割产品信息8
                        string flag8 = str8[0];//产品8信息
                        string ocr8 = str8[2];
                        string code8 = str8[1];
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
                        wp2.Index = 8;
                        wp2.Type = eType;
                        wp2.IsExist = flag8 == "1" ? true : false;
                        wp2.Ocr = ocr8;
                        wp2.BarCode = code8;
                        SoftConfig.lstWorkPiece.Add(wp2);

                        string[] str9 = info3.Split(',');//分割产品信息9
                        string flag9 = str9[0];//产品9信息
                        string ocr9 = str9[2];
                        string code9 = str9[1];
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
                        wp3.Index = 9;
                        wp3.Type = eType;
                        wp3.IsExist = flag9 == "1" ? true : false;
                        wp3.Ocr = ocr9;
                        wp3.BarCode = code9;
                        SoftConfig.lstWorkPiece.Add(wp3);

                        string[] str10 = info4.Split(',');//分割产品信息10
                        string flag10 = str10[0];//产品10信息
                        string ocr10 = str10[2];
                        string code10 = str10[1];
                        if (flag10 == "1")
                        {
                            hsl.WriteInt(hsl.locationX10, 4);
                            hsl.WriteInt(hsl.locationY10, 2);
                        }
                        else
                        {
                            hsl.WriteInt(hsl.locationX10, 0);
                            hsl.WriteInt(hsl.locationY10, 0);
                        }
                        wp4.Index = 10;
                        wp4.Type = eType;
                        wp4.IsExist = flag10 == "1" ? true : false;
                        wp4.Ocr = ocr10;
                        wp4.BarCode = code10;
                        SoftConfig.lstWorkPiece.Add(wp4);

                        string[] str11 = info5.Split(',');//分割产品信息11
                        string flag11 = str11[0];//产品11信息
                        string ocr11 = str11[2];
                        string code11 = str11[1];
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
                        wp5.Index = 11;
                        wp5.Type = eType;
                        wp5.IsExist = flag11 == "1" ? true : false;
                        wp5.Ocr = ocr11;
                        wp5.BarCode = code11;
                        SoftConfig.lstWorkPiece.Add(wp5);

                        string[] str12 = info6.Split(',');//分割产品信息12
                        string flag12 = str12[0];//产品12信息
                        string ocr12 = str12[2];
                        string code12 = str12[1];
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
                        wp6.Index = 12;
                        wp6.Type = eType;
                        wp6.IsExist = flag12 == "1" ? true : false;
                        wp6.Ocr = ocr12;
                        wp6.BarCode = code12;
                        SoftConfig.lstWorkPiece.Add(wp6);

                        break;


                    //第三次拍照

                    case "3":
                        string[] str13 = info1.Split(',');//分割产品信息13
                        string flag13 = str13[0];//产品13信息
                        string ocr13 = str13[2];
                        string code13 = str13[1];
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
                        wp1.Index = 13;
                        wp1.Type = eType;
                        wp1.IsExist = flag13 == "1" ? true : false;
                        wp1.Ocr = ocr13;
                        wp1.BarCode = code13;
                        SoftConfig.lstWorkPiece.Add(wp1);

                        string[] str14 = info2.Split(',');//分割产品信息14
                        string flag14 = str14[0];//产品14信息
                        string ocr14 = str14[2];
                        string code14 = str14[1];
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
                        wp2.Index = 14;
                        wp2.Type = eType;
                        wp2.IsExist = flag14 == "1" ? true : false;
                        wp2.Ocr = ocr14;
                        wp2.BarCode = code14;
                        SoftConfig.lstWorkPiece.Add(wp2);

                        string[] str15 = info3.Split(',');//分割产品信息15
                        string flag15 = str15[0];//产品15信息
                        string ocr15 = str15[2];
                        string code15 = str15[1];
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
                        wp3.Index = 15;
                        wp3.Type = eType;
                        wp3.IsExist = flag15 == "1" ? true : false;
                        wp3.Ocr = ocr15;
                        wp3.BarCode = code15;
                        SoftConfig.lstWorkPiece.Add(wp3);

                        string[] str16 = info4.Split(',');//分割产品信息16
                        string flag16 = str16[0];//产品16信息
                        string ocr16 = str16[2];
                        string code16 = str16[1];
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
                        wp4.Index = 16;
                        wp4.Type = eType;
                        wp4.IsExist = flag16 == "1" ? true : false;
                        wp4.Ocr = ocr16;
                        wp4.BarCode = code16;
                        SoftConfig.lstWorkPiece.Add(wp4);

                        string[] str17 = info5.Split(',');//分割产品信息17
                        string flag17 = str17[0];//产品17信息
                        string ocr17 = str17[2];
                        string code17 = str17[1];
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
                        wp5.Index = 17;
                        wp5.Type = eType;
                        wp5.IsExist = flag17 == "1" ? true : false;
                        wp5.Ocr = ocr17;
                        wp5.BarCode = code17;
                        SoftConfig.lstWorkPiece.Add(wp5);

                        string[] str18 = info6.Split(',');//分割产品信息18
                        string flag18 = str18[0];//产品18信息
                        string ocr18 = str18[2];
                        string code18 = str18[1];
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
                        wp6.Index = 18;
                        wp6.Type = eType;
                        wp6.IsExist = flag18 == "1" ? true : false;
                        wp6.Ocr = ocr18;
                        wp6.BarCode = code18;
                        SoftConfig.lstWorkPiece.Add(wp6);

                        break;


                    //第四次拍照

                    case "4":
                        string[] str19 = info1.Split(',');//分割产品信息19
                        string flag19 = str19[0];//产品19信息
                        string ocr19 = str19[2];
                        string code19 = str19[1];
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
                        wp1.Index = 19;
                        wp1.Type = eType;
                        wp1.IsExist = flag19 == "1" ? true : false;
                        wp1.Ocr = ocr19;
                        wp1.BarCode = code19;
                        SoftConfig.lstWorkPiece.Add(wp1);

                        string[] str20 = info2.Split(',');//分割产品信息20
                        string flag20 = str20[0];//产品20信息
                        string ocr20 = str20[2];
                        string code20 = str20[1];
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
                        wp2.Index = 20;
                        wp2.Type = eType;
                        wp2.IsExist = flag20 == "1" ? true : false;
                        wp2.Ocr = ocr20;
                        wp2.BarCode = code20;
                        SoftConfig.lstWorkPiece.Add(wp2);

                        string[] str21 = info3.Split(',');//分割产品信息21
                        string flag21 = str21[0];//产品21信息
                        string ocr21 = str21[2];
                        string code21 = str21[1];
                        if (flag21 == "1")
                        {
                            hsl.WriteInt(hsl.locationX21, 3);
                            hsl.WriteInt(hsl.locationY21, 5);
                        }
                        else
                        {
                            hsl.WriteInt(hsl.locationX21, 0);
                            hsl.WriteInt(hsl.locationY21, 0);
                        }
                        wp3.Index = 21;
                        wp3.Type = eType;
                        wp3.IsExist = flag21 == "1" ? true : false;
                        wp3.Ocr = ocr21;
                        wp3.BarCode = code21;
                        SoftConfig.lstWorkPiece.Add(wp3);

                        string[] str22 = info4.Split(',');//分割产品信息22
                        string flag22 = str22[0];//产品22信息
                        string ocr22 = str22[2];
                        string code22 = str22[1];
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
                        wp4.Index = 22;
                        wp4.Type = eType;
                        wp4.IsExist = flag22 == "1" ? true : false;
                        wp4.Ocr = ocr22;
                        wp4.BarCode = code22;
                        SoftConfig.lstWorkPiece.Add(wp4);

                        string[] str23 = info5.Split(',');//分割产品信息23
                        string flag23 = str23[0];//产品23信息
                        string ocr23 = str23[2];
                        string code23 = str23[1];
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
                        wp5.Index = 23;
                        wp5.Type = eType;
                        wp5.IsExist = flag23 == "1" ? true : false;
                        wp5.Ocr = ocr23;
                        wp5.BarCode = code23;
                        SoftConfig.lstWorkPiece.Add(wp5);

                        string[] str24 = info6.Split(',');//分割产品信息24
                        string flag24 = str24[0];//产品24信息
                        string ocr24 = str24[2];
                        string code24 = str24[1];
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
                        wp6.Index = 24;
                        wp6.Type = eType;
                        wp6.IsExist = flag24 == "1" ? true : false;
                        wp6.Ocr = ocr24;
                        wp6.BarCode = code24;
                        SoftConfig.lstWorkPiece.Add(wp6);

                        break;

                    //第5次拍照

                    case "5":
                        string[] str25 = info1.Split(',');//分割产品信息25
                        string flag25 = str25[0];//产品25信息
                        string ocr25 = str25[2];
                        string code25 = str25[1];
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
                        wp1.Index = 25;
                        wp1.Type = eType;
                        wp1.IsExist = flag25 == "1" ? true : false;
                        wp1.Ocr = ocr25;
                        wp1.BarCode = code25;
                        SoftConfig.lstWorkPiece.Add(wp1);

                        string[] str26 = info2.Split(',');//分割产品信息26
                        string flag26 = str26[0];//产品26信息
                        string ocr26 = str26[2];
                        string code26 = str26[1];
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
                        wp2.Index = 26;
                        wp2.Type = eType;
                        wp2.IsExist = flag26 == "1" ? true : false;
                        wp2.Ocr = ocr26;
                        wp2.BarCode = code26;
                        SoftConfig.lstWorkPiece.Add(wp2);

                        string[] str27 = info3.Split(',');//分割产品信息27
                        string flag27 = str27[0];//产品27信息
                        string ocr27 = str27[2];
                        string code27 = str27[1];
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
                        wp3.Index = 27;
                        wp3.Type = eType;
                        wp3.IsExist = flag27 == "1" ? true : false;
                        wp3.Ocr = ocr27;
                        wp3.BarCode = code27;
                        SoftConfig.lstWorkPiece.Add(wp3);

                        string[] str28 = info4.Split(',');//分割产品信息28
                        string flag28 = str28[0];//产品28信息
                        string ocr28 = str28[2];
                        string code28 = str28[1];
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
                        wp4.Index = 28;
                        wp4.Type = eType;
                        wp4.IsExist = flag28 == "1" ? true : false;
                        wp4.Ocr = ocr28;
                        wp4.BarCode = code28;
                        SoftConfig.lstWorkPiece.Add(wp4);


                        break;


                    //第6次拍照

                    case "6":
                        string[] str29 = info1.Split(',');//分割产品信息29
                        string flag29 = str29[0];//产品29信息
                        string ocr29 = str29[2];
                        string code29 = str29[1];
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
                        wp1.Index = 29;
                        wp1.Type = eType;
                        wp1.IsExist = flag29 == "1" ? true : false;
                        wp1.Ocr = ocr29;
                        wp1.BarCode = code29;
                        SoftConfig.lstWorkPiece.Add(wp1);

                        string[] str30 = info2.Split(',');//分割产品信息30
                        string flag30 = str30[0];//产品30信息
                        string ocr30 = str30[2];
                        string code30 = str30[1];
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
                        wp2.Index = 30;
                        wp2.Type = eType;
                        wp2.IsExist = flag30 == "1" ? true : false;
                        wp2.Ocr = ocr30;
                        wp2.BarCode = code30;
                        SoftConfig.lstWorkPiece.Add(wp2);

                        string[] str31 = info3.Split(',');//分割产品信息31
                        string flag31 = str31[0];//产品31信息
                        string ocr31 = str31[2];
                        string code31 = str31[1];
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
                        wp3.Index = 31;
                        wp3.Type = eType;
                        wp3.IsExist = flag31 == "1" ? true : false;
                        wp3.Ocr = ocr31;
                        wp3.BarCode = code31;
                        SoftConfig.lstWorkPiece.Add(wp3);

                        string[] str32 = info4.Split(',');//分割产品信息32
                        string flag32 = str32[0];//产品32信息
                        string ocr32 = str32[2];
                        string code32 = str32[1];
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
                        wp4.Index = 32;
                        wp4.Type = eType;
                        wp4.IsExist = flag32 == "1" ? true : false;
                        wp4.Ocr = ocr32;
                        wp4.BarCode = code32;
                        SoftConfig.lstWorkPiece.Add(wp4);


                        break;
                }
            }
            catch (Exception ex)
            {

            }
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


            ////工位
            //uc_BoxSmall ub1 = new uc_BoxSmall();
            //ub1.Location = new Point(100, 250);
            //ub1.Size = new Size(110, 110);
            //this.Controls.Add(ub1);
            //uc_BoxSmall ub2 = new uc_BoxSmall();
            //ub2.Location = new Point(300, 250);
            //ub2.Size = new Size(110, 110);
            //this.Controls.Add(ub2);
            //uc_BoxMiddle ub3 = new uc_BoxMiddle();
            //ub3.Location = new Point(500, 250);
            //ub3.Size = new Size(110, 110);
            //this.Controls.Add(ub3);
            //uc_BoxMiddle ub4 = new uc_BoxMiddle();
            //ub4.Location = new Point(700, 400);
            //ub4.Size = new Size(110, 110);
            //this.Controls.Add(ub4);
            ////NG
            //uc_BoxSmall ubNGSmall = new uc_BoxSmall();
            //ubNGSmall.Location = new Point(500, 80);
            //ubNGSmall.Size = new Size(110, 110);
            //this.Controls.Add(ubNGSmall);
            //uc_BoxMiddle ubNGMiddle = new uc_BoxMiddle();
            //ubNGMiddle.Location = new Point(700, 80);
            //ubNGMiddle.Size = new Size(110, 110);
            //this.Controls.Add(ubNGMiddle);

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            VmSolution.OnWorkStatusEvent -= VmSolution_OnWorkStatusEvent;//注册流程状态回调
            cts.Cancel();
            Close();
        }

        private void timerShow_Tick(object sender, EventArgs e)
        {
            //查询状态
            ledCheckState.On = hsl.ReadBool("M18", 1)[0] ? true : false;
            int iResult = hsl.ReadInt("D3047", 1)[0];
            switch (iResult)
            {
                case 1:
                    ledCheckCleanResult.On = true;
                    ledCheckNGResult.On = true;
                    break;
                case 2:
                    ledCheckCleanResult.On = true;
                    ledCheckNGResult.On = false;
                    break;
                case 3:
                    ledCheckCleanResult.On = false;
                    ledCheckNGResult.On = true;
                    break;
                case 4:
                    ledCheckCleanResult.On = false;
                    ledCheckNGResult.On = false;
                    break;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            hsl.WriteBool("M0", true);
            Thread.Sleep(300);
            hsl.WriteBool("M0", false);
        }

        private void btnOrigin_Click(object sender, EventArgs e)
        {
            hsl.WriteBool("M1", true);
            Thread.Sleep(300);
            hsl.WriteBool("M1", false);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            hsl.WriteBool("M7", true);
            Thread.Sleep(300);
            hsl.WriteBool("M7", false);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            hsl.WriteBool("M8", true);
            Thread.Sleep(300);
            hsl.WriteBool("M8", false);
        }
    }
}
