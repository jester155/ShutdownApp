namespace ShutdownApp {
	partial class ShutdownForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShutdownForm));
			this.BtnAbort = new System.Windows.Forms.Button();
			this.BtnStart = new System.Windows.Forms.Button();
			this.LblTimeUnit = new System.Windows.Forms.Label();
			this.ComboBoxTime = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.ComboBoxOptions = new System.Windows.Forms.ComboBox();
			this.TbSetTimeText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.LblTimeLeft = new System.Windows.Forms.Label();
			this.CheckBoxHybrid = new System.Windows.Forms.CheckBox();
			this.tmrShutdown = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// BtnAbort
			// 
			this.BtnAbort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.BtnAbort.Enabled = false;
			this.BtnAbort.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnAbort.ForeColor = System.Drawing.Color.Maroon;
			this.BtnAbort.Location = new System.Drawing.Point(21, 114);
			this.BtnAbort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnAbort.Name = "BtnAbort";
			this.BtnAbort.Size = new System.Drawing.Size(133, 50);
			this.BtnAbort.TabIndex = 4;
			this.BtnAbort.Text = "Abort!";
			this.BtnAbort.UseVisualStyleBackColor = true;
			this.BtnAbort.Click += new System.EventHandler(this.abortButton_Click);
			// 
			// BtnStart
			// 
			this.BtnStart.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnStart.ForeColor = System.Drawing.SystemColors.ControlText;
			this.BtnStart.Location = new System.Drawing.Point(21, 57);
			this.BtnStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnStart.Name = "BtnStart";
			this.BtnStart.Size = new System.Drawing.Size(133, 50);
			this.BtnStart.TabIndex = 5;
			this.BtnStart.Text = "Start";
			this.BtnStart.UseVisualStyleBackColor = true;
			this.BtnStart.Click += new System.EventHandler(this.startButton_Click);
			// 
			// LblTimeUnit
			// 
			this.LblTimeUnit.AutoSize = true;
			this.LblTimeUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTimeUnit.Location = new System.Drawing.Point(352, 129);
			this.LblTimeUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblTimeUnit.Name = "LblTimeUnit";
			this.LblTimeUnit.Size = new System.Drawing.Size(91, 23);
			this.LblTimeUnit.TabIndex = 14;
			this.LblTimeUnit.Text = "Time Unit";
			// 
			// ComboBoxTime
			// 
			this.ComboBoxTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboBoxTime.FormattingEnabled = true;
			this.ComboBoxTime.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
			this.ComboBoxTime.Location = new System.Drawing.Point(269, 17);
			this.ComboBoxTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ComboBoxTime.MaxDropDownItems = 3;
			this.ComboBoxTime.Name = "ComboBoxTime";
			this.ComboBoxTime.Size = new System.Drawing.Size(160, 31);
			this.ComboBoxTime.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(172, 129);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 23);
			this.label2.TabIndex = 13;
			this.label2.Text = "Time Left:";
			// 
			// ComboBoxOptions
			// 
			this.ComboBoxOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ComboBoxOptions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ComboBoxOptions.FormattingEnabled = true;
			this.ComboBoxOptions.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Log Off",
            "Sleep"});
			this.ComboBoxOptions.Location = new System.Drawing.Point(269, 68);
			this.ComboBoxOptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ComboBoxOptions.Name = "ComboBoxOptions";
			this.ComboBoxOptions.Size = new System.Drawing.Size(160, 31);
			this.ComboBoxOptions.TabIndex = 12;
			// 
			// TbSetTimeText
			// 
			this.TbSetTimeText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TbSetTimeText.Location = new System.Drawing.Point(123, 17);
			this.TbSetTimeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TbSetTimeText.Name = "TbSetTimeText";
			this.TbSetTimeText.Size = new System.Drawing.Size(132, 30);
			this.TbSetTimeText.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 21);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "Set Time";
			// 
			// LblTimeLeft
			// 
			this.LblTimeLeft.AutoSize = true;
			this.LblTimeLeft.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTimeLeft.Location = new System.Drawing.Point(264, 127);
			this.LblTimeLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblTimeLeft.Name = "LblTimeLeft";
			this.LblTimeLeft.Size = new System.Drawing.Size(25, 28);
			this.LblTimeLeft.TabIndex = 15;
			this.LblTimeLeft.Text = "0";
			// 
			// CheckBoxHybrid
			// 
			this.CheckBoxHybrid.AutoSize = true;
			this.CheckBoxHybrid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CheckBoxHybrid.Location = new System.Drawing.Point(25, 180);
			this.CheckBoxHybrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.CheckBoxHybrid.Name = "CheckBoxHybrid";
			this.CheckBoxHybrid.Size = new System.Drawing.Size(155, 23);
			this.CheckBoxHybrid.TabIndex = 16;
			this.CheckBoxHybrid.Text = "Hybrid Shutdown";
			this.CheckBoxHybrid.UseVisualStyleBackColor = true;
			// 
			// tmrShutdown
			// 
			this.tmrShutdown.Interval = 1000;
			this.tmrShutdown.Tick += new System.EventHandler(this.tmrShutdown_Tick);
			// 
			// ShutdownForm
			// 
			this.AcceptButton = this.BtnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.BtnAbort;
			this.ClientSize = new System.Drawing.Size(447, 215);
			this.Controls.Add(this.CheckBoxHybrid);
			this.Controls.Add(this.LblTimeLeft);
			this.Controls.Add(this.LblTimeUnit);
			this.Controls.Add(this.ComboBoxTime);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.ComboBoxOptions);
			this.Controls.Add(this.TbSetTimeText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.BtnAbort);
			this.Controls.Add(this.BtnStart);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ShutdownForm";
			this.Text = "ShutdownForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnAbort;
		private System.Windows.Forms.Button BtnStart;
		private System.Windows.Forms.Label LblTimeUnit;
		private System.Windows.Forms.ComboBox ComboBoxTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox ComboBoxOptions;
		private System.Windows.Forms.TextBox TbSetTimeText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label LblTimeLeft;
		private System.Windows.Forms.CheckBox CheckBoxHybrid;
		private System.Windows.Forms.Timer tmrShutdown;
	}
}