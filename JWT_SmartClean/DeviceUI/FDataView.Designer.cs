﻿namespace JWT_SmartClean
{
    partial class FDataView
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
            this.chart = new Sunny.UI.UISymbolButton();
            this.exit = new Sunny.UI.UISymbolButton();
            this.log = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart.IsCircle = true;
            this.chart.Location = new System.Drawing.Point(302, 104);
            this.chart.MinimumSize = new System.Drawing.Size(1, 1);
            this.chart.Name = "chart";
            this.chart.Radius = 117;
            this.chart.Size = new System.Drawing.Size(190, 171);
            this.chart.StyleCustomMode = true;
            this.chart.Symbol = 61568;
            this.chart.TabIndex = 8;
            this.chart.Text = "效能图表";
            this.chart.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.chart.Click += new System.EventHandler(this.chart_Click);
            // 
            // exit
            // 
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.exit.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.exit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.exit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.IsCircle = true;
            this.exit.Location = new System.Drawing.Point(562, 104);
            this.exit.MinimumSize = new System.Drawing.Size(1, 1);
            this.exit.Name = "exit";
            this.exit.Radius = 117;
            this.exit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.exit.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.exit.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.exit.Size = new System.Drawing.Size(190, 171);
            this.exit.Style = Sunny.UI.UIStyle.Red;
            this.exit.StyleCustomMode = true;
            this.exit.Symbol = 61453;
            this.exit.TabIndex = 7;
            this.exit.Text = "退出";
            this.exit.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exit.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // log
            // 
            this.log.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log.IsCircle = true;
            this.log.Location = new System.Drawing.Point(42, 104);
            this.log.MinimumSize = new System.Drawing.Size(1, 1);
            this.log.Name = "log";
            this.log.Radius = 117;
            this.log.Size = new System.Drawing.Size(190, 171);
            this.log.StyleCustomMode = true;
            this.log.Symbol = 61508;
            this.log.TabIndex = 6;
            this.log.Text = "操作日志";
            this.log.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.log.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // FDataView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 350);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.log);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 900);
            this.MinimizeBox = false;
            this.Name = "FDataView";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ShowFullScreen = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "记录查询";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 600);
            this.Resize += new System.EventHandler(this.FDataView_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton chart;
        private Sunny.UI.UISymbolButton exit;
        private Sunny.UI.UISymbolButton log;
    }
}