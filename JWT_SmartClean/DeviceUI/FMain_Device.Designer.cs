namespace JWT_SmartClean
{
    partial class FMain_Device
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.UserCenter = new Sunny.UI.UIHeaderButton();
            this.hbtnSet = new Sunny.UI.UIHeaderButton();
            this.hbtnTest = new Sunny.UI.UIHeaderButton();
            this.hbtnUser = new Sunny.UI.UIHeaderButton();
            this.hbtnReport = new Sunny.UI.UIHeaderButton();
            this.hbtnClean = new Sunny.UI.UIHeaderButton();
            this.plMain = new Sunny.UI.UIPanel();
            this.vmFrontendControl1 = new VMControls.Winform.Release.VmFrontendControl();
            this.lbTime = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lightScan = new Sunny.UI.UILight();
            this.lightPLC = new Sunny.UI.UILight();
            this.lightDB = new Sunny.UI.UILight();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.uiPanel1.SuspendLayout();
            this.plMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.UserCenter);
            this.uiPanel1.Controls.Add(this.hbtnSet);
            this.uiPanel1.Controls.Add(this.hbtnTest);
            this.uiPanel1.Controls.Add(this.hbtnUser);
            this.uiPanel1.Controls.Add(this.hbtnReport);
            this.uiPanel1.Controls.Add(this.hbtnClean);
            this.uiPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiPanel1.Location = new System.Drawing.Point(1, 36);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1022, 126);
            this.uiPanel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPanel1.StyleCustomMode = true;
            this.uiPanel1.TabIndex = 23;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // UserCenter
            // 
            this.UserCenter.CircleColor = System.Drawing.Color.SlateGray;
            this.UserCenter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UserCenter.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserCenter.Location = new System.Drawing.Point(897, 8);
            this.UserCenter.MinimumSize = new System.Drawing.Size(1, 1);
            this.UserCenter.Name = "UserCenter";
            this.UserCenter.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.UserCenter.Radius = 0;
            this.UserCenter.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.UserCenter.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.UserCenter.Size = new System.Drawing.Size(110, 110);
            this.UserCenter.Style = Sunny.UI.UIStyle.Custom;
            this.UserCenter.Symbol = 61447;
            this.UserCenter.SymbolOffset = new System.Drawing.Point(1, 2);
            this.UserCenter.SymbolSize = 41;
            this.UserCenter.TabIndex = 7;
            this.UserCenter.Text = "admin";
            this.UserCenter.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserCenter.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.UserCenter.Click += new System.EventHandler(this.UserCenter_Click);
            // 
            // hbtnSet
            // 
            this.hbtnSet.CircleColor = System.Drawing.Color.Olive;
            this.hbtnSet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnSet.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnSet.Location = new System.Drawing.Point(508, 8);
            this.hbtnSet.MinimumSize = new System.Drawing.Size(1, 1);
            this.hbtnSet.Name = "hbtnSet";
            this.hbtnSet.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.hbtnSet.Radius = 0;
            this.hbtnSet.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.hbtnSet.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.hbtnSet.Size = new System.Drawing.Size(110, 110);
            this.hbtnSet.Style = Sunny.UI.UIStyle.Custom;
            this.hbtnSet.Symbol = 61573;
            this.hbtnSet.SymbolOffset = new System.Drawing.Point(1, 2);
            this.hbtnSet.SymbolSize = 41;
            this.hbtnSet.TabIndex = 6;
            this.hbtnSet.Text = "系统设置";
            this.hbtnSet.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnSet.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.hbtnSet.Click += new System.EventHandler(this.hbtnSet_Click);
            // 
            // hbtnTest
            // 
            this.hbtnTest.CircleColor = System.Drawing.Color.Goldenrod;
            this.hbtnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnTest.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnTest.Location = new System.Drawing.Point(142, 8);
            this.hbtnTest.MinimumSize = new System.Drawing.Size(1, 1);
            this.hbtnTest.Name = "hbtnTest";
            this.hbtnTest.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.hbtnTest.Radius = 0;
            this.hbtnTest.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.hbtnTest.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.hbtnTest.Size = new System.Drawing.Size(110, 110);
            this.hbtnTest.Style = Sunny.UI.UIStyle.Custom;
            this.hbtnTest.Symbol = 57397;
            this.hbtnTest.SymbolOffset = new System.Drawing.Point(1, 2);
            this.hbtnTest.SymbolSize = 41;
            this.hbtnTest.TabIndex = 5;
            this.hbtnTest.Text = "设备调试";
            this.hbtnTest.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnTest.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.hbtnTest.Click += new System.EventHandler(this.hbtnTest_Click);
            // 
            // hbtnUser
            // 
            this.hbtnUser.CircleColor = System.Drawing.Color.DarkOrange;
            this.hbtnUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnUser.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnUser.Location = new System.Drawing.Point(264, 8);
            this.hbtnUser.MinimumSize = new System.Drawing.Size(1, 1);
            this.hbtnUser.Name = "hbtnUser";
            this.hbtnUser.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.hbtnUser.Radius = 0;
            this.hbtnUser.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.hbtnUser.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.hbtnUser.Size = new System.Drawing.Size(110, 110);
            this.hbtnUser.Style = Sunny.UI.UIStyle.Custom;
            this.hbtnUser.Symbol = 62144;
            this.hbtnUser.SymbolOffset = new System.Drawing.Point(0, 1);
            this.hbtnUser.SymbolSize = 40;
            this.hbtnUser.TabIndex = 2;
            this.hbtnUser.Text = "用户管理";
            this.hbtnUser.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnUser.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.hbtnUser.Click += new System.EventHandler(this.hbtnUser_Click);
            // 
            // hbtnReport
            // 
            this.hbtnReport.CircleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hbtnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnReport.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnReport.Location = new System.Drawing.Point(386, 8);
            this.hbtnReport.MinimumSize = new System.Drawing.Size(1, 1);
            this.hbtnReport.Name = "hbtnReport";
            this.hbtnReport.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.hbtnReport.Radius = 0;
            this.hbtnReport.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.hbtnReport.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.hbtnReport.Size = new System.Drawing.Size(110, 110);
            this.hbtnReport.Style = Sunny.UI.UIStyle.Custom;
            this.hbtnReport.Symbol = 61953;
            this.hbtnReport.SymbolOffset = new System.Drawing.Point(1, 0);
            this.hbtnReport.SymbolSize = 44;
            this.hbtnReport.TabIndex = 1;
            this.hbtnReport.Text = "记录查询";
            this.hbtnReport.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnReport.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.hbtnReport.Click += new System.EventHandler(this.hbtnReport_Click);
            // 
            // hbtnClean
            // 
            this.hbtnClean.CircleColor = System.Drawing.Color.RoyalBlue;
            this.hbtnClean.CircleHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.hbtnClean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hbtnClean.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnClean.Location = new System.Drawing.Point(20, 8);
            this.hbtnClean.MinimumSize = new System.Drawing.Size(1, 1);
            this.hbtnClean.Name = "hbtnClean";
            this.hbtnClean.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.hbtnClean.Radius = 0;
            this.hbtnClean.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.hbtnClean.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.hbtnClean.Size = new System.Drawing.Size(110, 110);
            this.hbtnClean.Style = Sunny.UI.UIStyle.Custom;
            this.hbtnClean.Symbol = 162454;
            this.hbtnClean.TabIndex = 0;
            this.hbtnClean.Text = "自动清洗";
            this.hbtnClean.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hbtnClean.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.hbtnClean.Click += new System.EventHandler(this.hbtnSortAuto_Click);
            // 
            // plMain
            // 
            this.plMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plMain.Controls.Add(this.vmFrontendControl1);
            this.plMain.Controls.Add(this.lbTime);
            this.plMain.Controls.Add(this.uiLabel3);
            this.plMain.Controls.Add(this.uiLabel2);
            this.plMain.Controls.Add(this.uiLabel1);
            this.plMain.Controls.Add(this.lightScan);
            this.plMain.Controls.Add(this.lightPLC);
            this.plMain.Controls.Add(this.lightDB);
            this.plMain.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plMain.Location = new System.Drawing.Point(-1, 175);
            this.plMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.plMain.MinimumSize = new System.Drawing.Size(1, 1);
            this.plMain.Name = "plMain";
            this.plMain.Size = new System.Drawing.Size(1024, 552);
            this.plMain.Style = Sunny.UI.UIStyle.Custom;
            this.plMain.TabIndex = 11;
            this.plMain.Text = null;
            this.plMain.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.plMain.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // vmFrontendControl1
            // 
            this.vmFrontendControl1.Location = new System.Drawing.Point(4, 7);
            this.vmFrontendControl1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.vmFrontendControl1.Name = "vmFrontendControl1";
            this.vmFrontendControl1.Size = new System.Drawing.Size(1014, 466);
            this.vmFrontendControl1.TabIndex = 90;
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTime.Location = new System.Drawing.Point(756, 493);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(255, 34);
            this.lbTime.Style = Sunny.UI.UIStyle.Custom;
            this.lbTime.TabIndex = 89;
            this.lbTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(266, 500);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(72, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 7;
            this.uiLabel3.Text = "相机";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(138, 500);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(72, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 6;
            this.uiLabel2.Text = "PLC";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(7, 500);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(72, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 5;
            this.uiLabel1.Text = "数据库";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lightScan
            // 
            this.lightScan.BackColor = System.Drawing.Color.Transparent;
            this.lightScan.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightScan.Location = new System.Drawing.Point(345, 493);
            this.lightScan.MinimumSize = new System.Drawing.Size(1, 1);
            this.lightScan.Name = "lightScan";
            this.lightScan.Radius = 35;
            this.lightScan.Size = new System.Drawing.Size(35, 35);
            this.lightScan.State = Sunny.UI.UILightState.Off;
            this.lightScan.Style = Sunny.UI.UIStyle.Custom;
            this.lightScan.TabIndex = 2;
            this.lightScan.Text = "uiLight1";
            this.lightScan.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lightPLC
            // 
            this.lightPLC.BackColor = System.Drawing.Color.Transparent;
            this.lightPLC.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightPLC.Location = new System.Drawing.Point(219, 493);
            this.lightPLC.MinimumSize = new System.Drawing.Size(1, 1);
            this.lightPLC.Name = "lightPLC";
            this.lightPLC.Radius = 35;
            this.lightPLC.Size = new System.Drawing.Size(35, 35);
            this.lightPLC.State = Sunny.UI.UILightState.Off;
            this.lightPLC.Style = Sunny.UI.UIStyle.Custom;
            this.lightPLC.TabIndex = 1;
            this.lightPLC.Text = "uiLight1";
            this.lightPLC.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lightDB
            // 
            this.lightDB.BackColor = System.Drawing.Color.Transparent;
            this.lightDB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lightDB.Location = new System.Drawing.Point(90, 493);
            this.lightDB.MinimumSize = new System.Drawing.Size(1, 1);
            this.lightDB.Name = "lightDB";
            this.lightDB.Radius = 35;
            this.lightDB.Size = new System.Drawing.Size(35, 35);
            this.lightDB.State = Sunny.UI.UILightState.Off;
            this.lightDB.Style = Sunny.UI.UIStyle.Custom;
            this.lightDB.TabIndex = 0;
            this.lightDB.Text = "uiLight1";
            this.lightDB.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // FMain_Device
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1024, 728);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.plMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FMain_Device";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ShowFullScreen = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "XXX系统V1.0";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1024, 728);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_Device_FormClosing);
            this.Click += new System.EventHandler(this.FMain_Device_Click);
            this.Resize += new System.EventHandler(this.FMain_Manage_Resize);
            this.uiPanel1.ResumeLayout(false);
            this.plMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UIHeaderButton hbtnTest;
        private Sunny.UI.UIHeaderButton hbtnUser;
        private Sunny.UI.UIHeaderButton hbtnReport;
        private Sunny.UI.UIHeaderButton hbtnClean;
        private Sunny.UI.UIHeaderButton hbtnSet;
        private Sunny.UI.UIPanel plMain;
        private Sunny.UI.UILight lightDB;
        private Sunny.UI.UILight lightScan;
        private Sunny.UI.UILight lightPLC;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lbTime;
        private System.Windows.Forms.Timer timerDateTime;
        private Sunny.UI.UIHeaderButton UserCenter;
        private VMControls.Winform.Release.VmFrontendControl vmFrontendControl1;
    }
}

