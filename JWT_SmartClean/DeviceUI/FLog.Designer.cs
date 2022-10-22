namespace JWT_SmartClean
{
    partial class FLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.cbRuleType = new Sunny.UI.UIComboBox();
            this.dpUseEnd = new Sunny.UI.UIDatetimePicker();
            this.dpUseStart = new Sunny.UI.UIDatetimePicker();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.dv = new Sunny.UI.UIDataGridView();
            this.departmentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalamount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnStart = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)(this.dv)).BeginInit();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(22, 63);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(45, 23);
            this.uiLabel1.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel1.TabIndex = 141;
            this.uiLabel1.Text = "用户";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // cbRuleType
            // 
            this.cbRuleType.DataSource = null;
            this.cbRuleType.FillColor = System.Drawing.Color.White;
            this.cbRuleType.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbRuleType.Items.AddRange(new object[] {
            "医嘱类别",
            "给药途径",
            "病区",
            "批次"});
            this.cbRuleType.Location = new System.Drawing.Point(86, 61);
            this.cbRuleType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbRuleType.MinimumSize = new System.Drawing.Size(63, 0);
            this.cbRuleType.Name = "cbRuleType";
            this.cbRuleType.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.cbRuleType.Size = new System.Drawing.Size(150, 29);
            this.cbRuleType.Style = Sunny.UI.UIStyle.Custom;
            this.cbRuleType.TabIndex = 140;
            this.cbRuleType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.cbRuleType.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dpUseEnd
            // 
            this.dpUseEnd.FillColor = System.Drawing.Color.White;
            this.dpUseEnd.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpUseEnd.Location = new System.Drawing.Point(536, 61);
            this.dpUseEnd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpUseEnd.MaxLength = 19;
            this.dpUseEnd.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpUseEnd.Name = "dpUseEnd";
            this.dpUseEnd.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpUseEnd.Size = new System.Drawing.Size(224, 29);
            this.dpUseEnd.Style = Sunny.UI.UIStyle.Custom;
            this.dpUseEnd.SymbolDropDown = 61555;
            this.dpUseEnd.SymbolNormal = 61555;
            this.dpUseEnd.TabIndex = 144;
            this.dpUseEnd.Text = "2022-06-13 10:42:25";
            this.dpUseEnd.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpUseEnd.Value = new System.DateTime(2022, 6, 13, 10, 42, 25, 201);
            this.dpUseEnd.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dpUseStart
            // 
            this.dpUseStart.FillColor = System.Drawing.Color.White;
            this.dpUseStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dpUseStart.Location = new System.Drawing.Point(262, 61);
            this.dpUseStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dpUseStart.MaxLength = 19;
            this.dpUseStart.MinimumSize = new System.Drawing.Size(63, 0);
            this.dpUseStart.Name = "dpUseStart";
            this.dpUseStart.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.dpUseStart.Size = new System.Drawing.Size(224, 29);
            this.dpUseStart.Style = Sunny.UI.UIStyle.Custom;
            this.dpUseStart.SymbolDropDown = 61555;
            this.dpUseStart.SymbolNormal = 61555;
            this.dpUseStart.TabIndex = 143;
            this.dpUseStart.Text = "2022-06-13 10:42:25";
            this.dpUseStart.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.dpUseStart.Value = new System.DateTime(2022, 6, 13, 10, 42, 25, 0);
            this.dpUseStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(491, 63);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(40, 23);
            this.uiLabel2.Style = Sunny.UI.UIStyle.Custom;
            this.uiLabel2.TabIndex = 142;
            this.uiLabel2.Text = "~";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // dv
            // 
            this.dv.AllowUserToAddRows = false;
            this.dv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dv.BackgroundColor = System.Drawing.Color.White;
            this.dv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dv.ColumnHeadersHeight = 32;
            this.dv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.departmentname,
            this.currentsort,
            this.specamount,
            this.totalamount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dv.EnableHeadersVisualStyles = false;
            this.dv.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.dv.Location = new System.Drawing.Point(26, 176);
            this.dv.Name = "dv";
            this.dv.ReadOnly = true;
            this.dv.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(160)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dv.RowHeight = 27;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dv.RowTemplate.Height = 27;
            this.dv.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.dv.SelectedIndex = -1;
            this.dv.Size = new System.Drawing.Size(749, 401);
            this.dv.StripeOddColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.dv.Style = Sunny.UI.UIStyle.Custom;
            this.dv.StyleCustomMode = true;
            this.dv.TabIndex = 145;
            this.dv.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // departmentname
            // 
            this.departmentname.DataPropertyName = "DepartmentName";
            this.departmentname.HeaderText = "名称";
            this.departmentname.Name = "departmentname";
            this.departmentname.ReadOnly = true;
            // 
            // currentsort
            // 
            this.currentsort.DataPropertyName = "DoCount";
            this.currentsort.HeaderText = "时间";
            this.currentsort.Name = "currentsort";
            this.currentsort.ReadOnly = true;
            // 
            // specamount
            // 
            this.specamount.DataPropertyName = "SpecCount";
            this.specamount.HeaderText = "类别";
            this.specamount.Name = "specamount";
            this.specamount.ReadOnly = true;
            // 
            // totalamount
            // 
            this.totalamount.DataPropertyName = "Count";
            this.totalamount.HeaderText = "结果";
            this.totalamount.Name = "totalamount";
            this.totalamount.ReadOnly = true;
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(536, 110);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Radius = 10;
            this.btnStart.RectSize = 2;
            this.btnStart.Size = new System.Drawing.Size(224, 47);
            this.btnStart.StyleCustomMode = true;
            this.btnStart.TabIndex = 146;
            this.btnStart.Text = "查询";
            this.btnStart.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // FLog
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.dv);
            this.Controls.Add(this.dpUseEnd);
            this.Controls.Add(this.dpUseStart);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.cbRuleType);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1440, 900);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FLog";
            this.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ShowFullScreen = true;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "记录";
            this.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 600);
            this.Resize += new System.EventHandler(this.FLog_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIComboBox cbRuleType;
        private Sunny.UI.UIDatetimePicker dpUseEnd;
        private Sunny.UI.UIDatetimePicker dpUseStart;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIDataGridView dv;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentname;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn specamount;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalamount;
        private Sunny.UI.UIButton btnStart;
    }
}