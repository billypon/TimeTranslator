namespace TimeTranslator
{
	partial class frmMain
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
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.flpMain = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.cbTransType = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cbTimeZone = new System.Windows.Forms.ComboBox();
			this.cbCustomZone = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbTimeType = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.dtpMain = new System.Windows.Forms.DateTimePicker();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.btnNow = new System.Windows.Forms.Button();
			this.btnTrans = new System.Windows.Forms.Button();
			this.lblTips = new System.Windows.Forms.Label();
			this.flpMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// flpMain
			// 
			this.flpMain.AutoSize = true;
			this.flpMain.Controls.Add(this.label1);
			this.flpMain.Controls.Add(this.cbTransType);
			this.flpMain.Controls.Add(this.lblTips);
			this.flpMain.Controls.Add(this.label2);
			this.flpMain.Controls.Add(this.cbTimeZone);
			this.flpMain.Controls.Add(this.cbCustomZone);
			this.flpMain.Controls.Add(this.label3);
			this.flpMain.Controls.Add(this.cbTimeType);
			this.flpMain.Controls.Add(this.label4);
			this.flpMain.Controls.Add(this.dtpMain);
			this.flpMain.Controls.Add(this.txtTime);
			this.flpMain.Controls.Add(this.btnNow);
			this.flpMain.Controls.Add(this.btnTrans);
			this.flpMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flpMain.Location = new System.Drawing.Point(0, 0);
			this.flpMain.Name = "flpMain";
			this.flpMain.Size = new System.Drawing.Size(292, 266);
			this.flpMain.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "转换类型：";
			// 
			// cbTransType
			// 
			this.cbTransType.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbTransType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbTransType.FormattingEnabled = true;
			this.cbTransType.Items.AddRange(new object[] {
            "转换至",
            "转换自"});
			this.cbTransType.Location = new System.Drawing.Point(74, 3);
			this.cbTransType.Name = "cbTransType";
			this.cbTransType.Size = new System.Drawing.Size(60, 20);
			this.cbTransType.TabIndex = 2;
			this.cbTransType.SelectedIndexChanged += new System.EventHandler(this.cbTransType_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 33);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "转换时区：";
			// 
			// cbTimeZone
			// 
			this.cbTimeZone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbTimeZone.DropDownHeight = 122;
			this.cbTimeZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.flpMain.SetFlowBreak(this.cbTimeZone, true);
			this.cbTimeZone.FormattingEnabled = true;
			this.cbTimeZone.IntegralHeight = false;
			this.cbTimeZone.Items.AddRange(new object[] {
            "请选择",
            "-自选-"});
			this.cbTimeZone.Location = new System.Drawing.Point(74, 29);
			this.cbTimeZone.Name = "cbTimeZone";
			this.cbTimeZone.Size = new System.Drawing.Size(60, 20);
			this.cbTimeZone.TabIndex = 1;
			this.cbTimeZone.SelectedIndexChanged += new System.EventHandler(this.cbTimeZone_SelectedIndexChanged);
			// 
			// cbCustomZone
			// 
			this.cbCustomZone.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbCustomZone.DropDownHeight = 122;
			this.cbCustomZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.flpMain.SetFlowBreak(this.cbCustomZone, true);
			this.cbCustomZone.FormattingEnabled = true;
			this.cbCustomZone.IntegralHeight = false;
			this.cbCustomZone.Location = new System.Drawing.Point(3, 55);
			this.cbCustomZone.Name = "cbCustomZone";
			this.cbCustomZone.Size = new System.Drawing.Size(121, 20);
			this.cbCustomZone.TabIndex = 3;
			this.cbCustomZone.Visible = false;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "时间类型：";
			// 
			// cbTimeType
			// 
			this.cbTimeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.cbTimeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.flpMain.SetFlowBreak(this.cbTimeType, true);
			this.cbTimeType.FormattingEnabled = true;
			this.cbTimeType.Items.AddRange(new object[] {
            "时间",
            "时间日期"});
			this.cbTimeType.Location = new System.Drawing.Point(74, 81);
			this.cbTimeType.Name = "cbTimeType";
			this.cbTimeType.Size = new System.Drawing.Size(72, 20);
			this.cbTimeType.TabIndex = 4;
			this.cbTimeType.SelectedIndexChanged += new System.EventHandler(this.cbTimeType_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(3, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(65, 12);
			this.label4.TabIndex = 8;
			this.label4.Text = "转换时间：";
			// 
			// dtpMain
			// 
			this.dtpMain.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.dtpMain.Location = new System.Drawing.Point(74, 107);
			this.dtpMain.Name = "dtpMain";
			this.dtpMain.Size = new System.Drawing.Size(107, 21);
			this.dtpMain.TabIndex = 5;
			this.dtpMain.Visible = false;
			// 
			// txtTime
			// 
			this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.txtTime.BackColor = System.Drawing.SystemColors.Window;
			this.flpMain.SetFlowBreak(this.txtTime, true);
			this.txtTime.ForeColor = System.Drawing.SystemColors.GrayText;
			this.txtTime.Location = new System.Drawing.Point(187, 107);
			this.txtTime.Name = "txtTime";
			this.txtTime.Size = new System.Drawing.Size(100, 21);
			this.txtTime.TabIndex = 6;
			this.txtTime.Text = "hh:mm";
			this.txtTime.Enter += new System.EventHandler(this.txtTime_Enter);
			this.txtTime.Leave += new System.EventHandler(this.txtTime_Leave);
			// 
			// btnNow
			// 
			this.btnNow.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flpMain.SetFlowBreak(this.btnNow, true);
			this.btnNow.Location = new System.Drawing.Point(3, 134);
			this.btnNow.Name = "btnNow";
			this.btnNow.Size = new System.Drawing.Size(75, 23);
			this.btnNow.TabIndex = 9;
			this.btnNow.Text = "当前时间";
			this.btnNow.UseVisualStyleBackColor = true;
			this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
			// 
			// btnTrans
			// 
			this.btnTrans.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.flpMain.SetFlowBreak(this.btnTrans, true);
			this.btnTrans.Location = new System.Drawing.Point(3, 163);
			this.btnTrans.Name = "btnTrans";
			this.btnTrans.Size = new System.Drawing.Size(75, 23);
			this.btnTrans.TabIndex = 7;
			this.btnTrans.Text = "转 换";
			this.btnTrans.UseVisualStyleBackColor = true;
			this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
			// 
			// lblTips
			// 
			this.lblTips.AutoSize = true;
			this.flpMain.SetFlowBreak(this.lblTips, true);
			this.lblTips.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(134)));
			this.lblTips.ForeColor = System.Drawing.Color.DarkRed;
			this.lblTips.Location = new System.Drawing.Point(140, 7);
			this.lblTips.Margin = new System.Windows.Forms.Padding(3, 7, 3, 0);
			this.lblTips.Name = "lblTips";
			this.lblTips.Size = new System.Drawing.Size(0, 12);
			this.lblTips.TabIndex = 11;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 266);
			this.Controls.Add(this.flpMain);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.Text = "时间转换器";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.flpMain.ResumeLayout(false);
			this.flpMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpMain;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbTransType;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cbTimeZone;
		private System.Windows.Forms.ComboBox cbTimeType;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.Button btnTrans;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbCustomZone;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker dtpMain;
		private System.Windows.Forms.Button btnNow;
		private System.Windows.Forms.Label lblTips;
	}
}

