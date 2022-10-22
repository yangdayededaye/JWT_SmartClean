namespace JWT_SmartClean
{
    partial class FClean
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerShow = new System.Windows.Forms.Timer(this.components);
            this.uiAnalogMeter1 = new Sunny.UI.UIAnalogMeter();
            this.lbWarn = new Sunny.UI.UISymbolLabel();
            this.uiLedBulb1 = new Sunny.UI.UILedBulb();
            this.uiLedBulb2 = new Sunny.UI.UILedBulb();
            this.uiLedBulb3 = new Sunny.UI.UILedBulb();
            this.uiLedBulb4 = new Sunny.UI.UILedBulb();
            this.uiLedBulb8 = new Sunny.UI.UILedBulb();
            this.uiLedBulb7 = new Sunny.UI.UILedBulb();
            this.uiLedBulb6 = new Sunny.UI.UILedBulb();
            this.uiLedBulb5 = new Sunny.UI.UILedBulb();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.btnExit = new Sunny.UI.UIButton();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel12 = new Sunny.UI.UILabel();
            this.uiLabel13 = new Sunny.UI.UILabel();
            this.uiLabel14 = new Sunny.UI.UILabel();
            this.uiLabel15 = new Sunny.UI.UILabel();
            this.uiLabel16 = new Sunny.UI.UILabel();
            this.uiLedBulb9 = new Sunny.UI.UILedBulb();
            this.uiLedBulb10 = new Sunny.UI.UILedBulb();
            this.uiLedBulb11 = new Sunny.UI.UILedBulb();
            this.uiLedBulb12 = new Sunny.UI.UILedBulb();
            this.uiLedBulb13 = new Sunny.UI.UILedBulb();
            this.uiLedBulb14 = new Sunny.UI.UILedBulb();
            this.uiLedBulb15 = new Sunny.UI.UILedBulb();
            this.uiLedBulb16 = new Sunny.UI.UILedBulb();
            this.SuspendLayout();
            // 
            // timerShow
            // 
            this.timerShow.Interval = 2000;
            this.timerShow.Tick += new System.EventHandler(this.timerShow_Tick);
            // 
            // uiAnalogMeter1
            // 
            this.uiAnalogMeter1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiAnalogMeter1.Location = new System.Drawing.Point(31, 86);
            this.uiAnalogMeter1.MaxValue = 100D;
            this.uiAnalogMeter1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiAnalogMeter1.MinValue = 0D;
            this.uiAnalogMeter1.Name = "uiAnalogMeter1";
            this.uiAnalogMeter1.Renderer = null;
            this.uiAnalogMeter1.Size = new System.Drawing.Size(180, 180);
            this.uiAnalogMeter1.Style = Sunny.UI.UIStyle.Custom;
            this.uiAnalogMeter1.TabIndex = 145;
            this.uiAnalogMeter1.Text = "uiAnalogMeter1";
            this.uiAnalogMeter1.Value = 0D;
            this.uiAnalogMeter1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lbWarn
            // 
            this.lbWarn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbWarn.Location = new System.Drawing.Point(12, 12);
            this.lbWarn.MinimumSize = new System.Drawing.Size(1, 1);
            this.lbWarn.Name = "lbWarn";
            this.lbWarn.Padding = new System.Windows.Forms.Padding(34, 0, 0, 0);
            this.lbWarn.Size = new System.Drawing.Size(790, 47);
            this.lbWarn.Style = Sunny.UI.UIStyle.Custom;
            this.lbWarn.StyleCustomMode = true;
            this.lbWarn.Symbol = 61553;
            this.lbWarn.SymbolColor = System.Drawing.Color.Green;
            this.lbWarn.SymbolOffset = new System.Drawing.Point(0, 2);
            this.lbWarn.SymbolSize = 30;
            this.lbWarn.TabIndex = 63;
            this.lbWarn.Text = "运行正常";
            this.lbWarn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbWarn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.lbWarn.Click += new System.EventHandler(this.lbWarn_Click);
            // 
            // uiLedBulb1
            // 
            this.uiLedBulb1.Location = new System.Drawing.Point(244, 125);
            this.uiLedBulb1.Name = "uiLedBulb1";
            this.uiLedBulb1.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb1.TabIndex = 146;
            this.uiLedBulb1.Text = "uiLedBulb1";
            this.uiLedBulb1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb2
            // 
            this.uiLedBulb2.Location = new System.Drawing.Point(329, 125);
            this.uiLedBulb2.Name = "uiLedBulb2";
            this.uiLedBulb2.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb2.TabIndex = 147;
            this.uiLedBulb2.Text = "uiLedBulb2";
            this.uiLedBulb2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb3
            // 
            this.uiLedBulb3.Location = new System.Drawing.Point(499, 125);
            this.uiLedBulb3.Name = "uiLedBulb3";
            this.uiLedBulb3.On = false;
            this.uiLedBulb3.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb3.TabIndex = 148;
            this.uiLedBulb3.Text = "uiLedBulb3";
            this.uiLedBulb3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb4
            // 
            this.uiLedBulb4.Location = new System.Drawing.Point(414, 125);
            this.uiLedBulb4.Name = "uiLedBulb4";
            this.uiLedBulb4.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb4.TabIndex = 149;
            this.uiLedBulb4.Text = "uiLedBulb4";
            this.uiLedBulb4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb8
            // 
            this.uiLedBulb8.Location = new System.Drawing.Point(244, 198);
            this.uiLedBulb8.Name = "uiLedBulb8";
            this.uiLedBulb8.On = false;
            this.uiLedBulb8.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb8.TabIndex = 150;
            this.uiLedBulb8.Text = "uiLedBulb8";
            this.uiLedBulb8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb7
            // 
            this.uiLedBulb7.Location = new System.Drawing.Point(329, 198);
            this.uiLedBulb7.Name = "uiLedBulb7";
            this.uiLedBulb7.On = false;
            this.uiLedBulb7.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb7.TabIndex = 151;
            this.uiLedBulb7.Text = "uiLedBulb7";
            this.uiLedBulb7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb6
            // 
            this.uiLedBulb6.Location = new System.Drawing.Point(499, 198);
            this.uiLedBulb6.Name = "uiLedBulb6";
            this.uiLedBulb6.On = false;
            this.uiLedBulb6.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb6.TabIndex = 152;
            this.uiLedBulb6.Text = "uiLedBulb6";
            this.uiLedBulb6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb5
            // 
            this.uiLedBulb5.Location = new System.Drawing.Point(414, 198);
            this.uiLedBulb5.Name = "uiLedBulb5";
            this.uiLedBulb5.On = false;
            this.uiLedBulb5.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb5.TabIndex = 153;
            this.uiLedBulb5.Text = "uiLedBulb5";
            this.uiLedBulb5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(226, 167);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(68, 23);
            this.uiLabel4.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel4.TabIndex = 154;
            this.uiLabel4.Text = "超声波";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(226, 243);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(68, 23);
            this.uiLabel5.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel5.TabIndex = 155;
            this.uiLabel5.Text = "...";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(311, 167);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(68, 23);
            this.uiLabel6.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel6.TabIndex = 156;
            this.uiLabel6.Text = "加热";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.Location = new System.Drawing.Point(397, 167);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(68, 23);
            this.uiLabel7.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel7.TabIndex = 157;
            this.uiLabel7.Text = "循环泵";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.Location = new System.Drawing.Point(481, 167);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(68, 23);
            this.uiLabel8.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel8.TabIndex = 158;
            this.uiLabel8.Text = "...";
            this.uiLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.Location = new System.Drawing.Point(311, 243);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(68, 23);
            this.uiLabel9.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel9.TabIndex = 159;
            this.uiLabel9.Text = "...";
            this.uiLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.Location = new System.Drawing.Point(396, 243);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(68, 23);
            this.uiLabel10.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel10.TabIndex = 160;
            this.uiLabel10.Text = "...";
            this.uiLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel10.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.Location = new System.Drawing.Point(481, 243);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(68, 23);
            this.uiLabel11.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel11.TabIndex = 161;
            this.uiLabel11.Text = "...";
            this.uiLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel11.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(899, 12);
            this.btnExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Radius = 10;
            this.btnExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnExit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.btnExit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.RectSize = 2;
            this.btnExit.Size = new System.Drawing.Size(113, 47);
            this.btnExit.Style = Sunny.UI.UIStyle.Red;
            this.btnExit.StyleCustomMode = true;
            this.btnExit.TabIndex = 162;
            this.btnExit.Text = "退出";
            this.btnExit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(824, 243);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(68, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 178;
            this.uiLabel1.Text = "...";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(739, 243);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(68, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 177;
            this.uiLabel2.Text = "...";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(654, 243);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(68, 23);
            this.uiLabel3.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel3.TabIndex = 176;
            this.uiLabel3.Text = "...";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel12
            // 
            this.uiLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel12.Location = new System.Drawing.Point(824, 167);
            this.uiLabel12.Name = "uiLabel12";
            this.uiLabel12.Size = new System.Drawing.Size(68, 23);
            this.uiLabel12.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel12.TabIndex = 175;
            this.uiLabel12.Text = "...";
            this.uiLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel12.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel13
            // 
            this.uiLabel13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel13.Location = new System.Drawing.Point(740, 167);
            this.uiLabel13.Name = "uiLabel13";
            this.uiLabel13.Size = new System.Drawing.Size(68, 23);
            this.uiLabel13.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel13.TabIndex = 174;
            this.uiLabel13.Text = "...";
            this.uiLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel13.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel14
            // 
            this.uiLabel14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel14.Location = new System.Drawing.Point(654, 167);
            this.uiLabel14.Name = "uiLabel14";
            this.uiLabel14.Size = new System.Drawing.Size(68, 23);
            this.uiLabel14.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel14.TabIndex = 173;
            this.uiLabel14.Text = "...";
            this.uiLabel14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel14.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel15
            // 
            this.uiLabel15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel15.Location = new System.Drawing.Point(569, 243);
            this.uiLabel15.Name = "uiLabel15";
            this.uiLabel15.Size = new System.Drawing.Size(68, 23);
            this.uiLabel15.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel15.TabIndex = 172;
            this.uiLabel15.Text = "...";
            this.uiLabel15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel15.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel16
            // 
            this.uiLabel16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel16.Location = new System.Drawing.Point(569, 167);
            this.uiLabel16.Name = "uiLabel16";
            this.uiLabel16.Size = new System.Drawing.Size(68, 23);
            this.uiLabel16.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel16.TabIndex = 171;
            this.uiLabel16.Text = "...";
            this.uiLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel16.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb9
            // 
            this.uiLedBulb9.Location = new System.Drawing.Point(757, 198);
            this.uiLedBulb9.Name = "uiLedBulb9";
            this.uiLedBulb9.On = false;
            this.uiLedBulb9.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb9.TabIndex = 170;
            this.uiLedBulb9.Text = "uiLedBulb9";
            this.uiLedBulb9.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb10
            // 
            this.uiLedBulb10.Location = new System.Drawing.Point(842, 198);
            this.uiLedBulb10.Name = "uiLedBulb10";
            this.uiLedBulb10.On = false;
            this.uiLedBulb10.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb10.TabIndex = 169;
            this.uiLedBulb10.Text = "uiLedBulb10";
            this.uiLedBulb10.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb11
            // 
            this.uiLedBulb11.Location = new System.Drawing.Point(672, 198);
            this.uiLedBulb11.Name = "uiLedBulb11";
            this.uiLedBulb11.On = false;
            this.uiLedBulb11.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb11.TabIndex = 168;
            this.uiLedBulb11.Text = "uiLedBulb11";
            this.uiLedBulb11.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb12
            // 
            this.uiLedBulb12.Location = new System.Drawing.Point(587, 198);
            this.uiLedBulb12.Name = "uiLedBulb12";
            this.uiLedBulb12.On = false;
            this.uiLedBulb12.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb12.TabIndex = 167;
            this.uiLedBulb12.Text = "uiLedBulb12";
            this.uiLedBulb12.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb13
            // 
            this.uiLedBulb13.Location = new System.Drawing.Point(757, 125);
            this.uiLedBulb13.Name = "uiLedBulb13";
            this.uiLedBulb13.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb13.TabIndex = 166;
            this.uiLedBulb13.Text = "uiLedBulb13";
            this.uiLedBulb13.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb14
            // 
            this.uiLedBulb14.Location = new System.Drawing.Point(842, 125);
            this.uiLedBulb14.Name = "uiLedBulb14";
            this.uiLedBulb14.On = false;
            this.uiLedBulb14.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb14.TabIndex = 165;
            this.uiLedBulb14.Text = "uiLedBulb14";
            this.uiLedBulb14.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb15
            // 
            this.uiLedBulb15.Location = new System.Drawing.Point(672, 125);
            this.uiLedBulb15.Name = "uiLedBulb15";
            this.uiLedBulb15.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb15.TabIndex = 164;
            this.uiLedBulb15.Text = "uiLedBulb15";
            this.uiLedBulb15.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLedBulb16
            // 
            this.uiLedBulb16.Location = new System.Drawing.Point(587, 125);
            this.uiLedBulb16.Name = "uiLedBulb16";
            this.uiLedBulb16.Size = new System.Drawing.Size(32, 32);
            this.uiLedBulb16.TabIndex = 163;
            this.uiLedBulb16.Text = "uiLedBulb16";
            this.uiLedBulb16.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FClean
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1024, 728);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiLabel12);
            this.Controls.Add(this.uiLabel13);
            this.Controls.Add(this.uiLabel14);
            this.Controls.Add(this.uiLabel15);
            this.Controls.Add(this.uiLabel16);
            this.Controls.Add(this.uiLedBulb9);
            this.Controls.Add(this.uiLedBulb10);
            this.Controls.Add(this.uiLedBulb11);
            this.Controls.Add(this.uiLedBulb12);
            this.Controls.Add(this.uiLedBulb13);
            this.Controls.Add(this.uiLedBulb14);
            this.Controls.Add(this.uiLedBulb15);
            this.Controls.Add(this.uiLedBulb16);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.uiLabel11);
            this.Controls.Add(this.uiLabel10);
            this.Controls.Add(this.uiLabel9);
            this.Controls.Add(this.uiLabel8);
            this.Controls.Add(this.uiLabel7);
            this.Controls.Add(this.uiLabel6);
            this.Controls.Add(this.uiLabel5);
            this.Controls.Add(this.uiLabel4);
            this.Controls.Add(this.uiLedBulb5);
            this.Controls.Add(this.uiLedBulb6);
            this.Controls.Add(this.uiLedBulb7);
            this.Controls.Add(this.uiLedBulb8);
            this.Controls.Add(this.uiLedBulb4);
            this.Controls.Add(this.uiLedBulb3);
            this.Controls.Add(this.uiLedBulb2);
            this.Controls.Add(this.uiLedBulb1);
            this.Controls.Add(this.uiAnalogMeter1);
            this.Controls.Add(this.lbWarn);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FClean";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ShowFullScreen = true;
            this.ShowTitle = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "...";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 600);
            this.Load += new System.EventHandler(this.FClean_Load);
            this.Resize += new System.EventHandler(this.FClean_Resize);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerShow;
        private Sunny.UI.UIAnalogMeter uiAnalogMeter1;
        private Sunny.UI.UISymbolLabel lbWarn;
        private Sunny.UI.UILedBulb uiLedBulb1;
        private Sunny.UI.UILedBulb uiLedBulb2;
        private Sunny.UI.UILedBulb uiLedBulb3;
        private Sunny.UI.UILedBulb uiLedBulb4;
        private Sunny.UI.UILedBulb uiLedBulb8;
        private Sunny.UI.UILedBulb uiLedBulb7;
        private Sunny.UI.UILedBulb uiLedBulb6;
        private Sunny.UI.UILedBulb uiLedBulb5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UIButton btnExit;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel15;
        private Sunny.UI.UILabel uiLabel16;
        private Sunny.UI.UILedBulb uiLedBulb9;
        private Sunny.UI.UILedBulb uiLedBulb10;
        private Sunny.UI.UILedBulb uiLedBulb11;
        private Sunny.UI.UILedBulb uiLedBulb12;
        private Sunny.UI.UILedBulb uiLedBulb13;
        private Sunny.UI.UILedBulb uiLedBulb14;
        private Sunny.UI.UILedBulb uiLedBulb15;
        private Sunny.UI.UILedBulb uiLedBulb16;
    }
}