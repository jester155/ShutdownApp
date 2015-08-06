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
			this.abortButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.lblTimeUnit = new System.Windows.Forms.Label();
			this.timeComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.optionsComboBox = new System.Windows.Forms.ComboBox();
			this.setTimeText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.timeLeftLabel = new System.Windows.Forms.Label();
			this.cbHybrid = new System.Windows.Forms.CheckBox();
			this.tmrShutdown = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// abortButton
			// 
			this.abortButton.Enabled = false;
			this.abortButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.abortButton.ForeColor = System.Drawing.Color.Maroon;
			this.abortButton.Location = new System.Drawing.Point(21, 114);
			this.abortButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.abortButton.Name = "abortButton";
			this.abortButton.Size = new System.Drawing.Size(133, 50);
			this.abortButton.TabIndex = 4;
			this.abortButton.Text = "Abort!";
			this.abortButton.UseVisualStyleBackColor = true;
			this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.startButton.Location = new System.Drawing.Point(21, 57);
			this.startButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(133, 50);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// lblTimeUnit
			// 
			this.lblTimeUnit.AutoSize = true;
			this.lblTimeUnit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimeUnit.Location = new System.Drawing.Point(352, 129);
			this.lblTimeUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblTimeUnit.Name = "lblTimeUnit";
			this.lblTimeUnit.Size = new System.Drawing.Size(91, 23);
			this.lblTimeUnit.TabIndex = 14;
			this.lblTimeUnit.Text = "Time Unit";
			// 
			// timeComboBox
			// 
			this.timeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.timeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeComboBox.FormattingEnabled = true;
			this.timeComboBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
			this.timeComboBox.Location = new System.Drawing.Point(269, 17);
			this.timeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.timeComboBox.MaxDropDownItems = 3;
			this.timeComboBox.Name = "timeComboBox";
			this.timeComboBox.Size = new System.Drawing.Size(160, 31);
			this.timeComboBox.TabIndex = 11;
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
			// optionsComboBox
			// 
			this.optionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.optionsComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.optionsComboBox.FormattingEnabled = true;
			this.optionsComboBox.Items.AddRange(new object[] {
            "Shutdown",
            "Restart",
            "Log Off",
            "Sleep"});
			this.optionsComboBox.Location = new System.Drawing.Point(269, 68);
			this.optionsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.optionsComboBox.Name = "optionsComboBox";
			this.optionsComboBox.Size = new System.Drawing.Size(160, 31);
			this.optionsComboBox.TabIndex = 12;
			// 
			// setTimeText
			// 
			this.setTimeText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.setTimeText.Location = new System.Drawing.Point(123, 17);
			this.setTimeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.setTimeText.Name = "setTimeText";
			this.setTimeText.Size = new System.Drawing.Size(132, 30);
			this.setTimeText.TabIndex = 10;
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
			// timeLeftLabel
			// 
			this.timeLeftLabel.AutoSize = true;
			this.timeLeftLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLeftLabel.Location = new System.Drawing.Point(264, 127);
			this.timeLeftLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.timeLeftLabel.Name = "timeLeftLabel";
			this.timeLeftLabel.Size = new System.Drawing.Size(25, 28);
			this.timeLeftLabel.TabIndex = 15;
			this.timeLeftLabel.Text = "0";
			// 
			// cbHybrid
			// 
			this.cbHybrid.AutoSize = true;
			this.cbHybrid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbHybrid.Location = new System.Drawing.Point(25, 180);
			this.cbHybrid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.cbHybrid.Name = "cbHybrid";
			this.cbHybrid.Size = new System.Drawing.Size(155, 23);
			this.cbHybrid.TabIndex = 16;
			this.cbHybrid.Text = "Hybrid Shutdown";
			this.cbHybrid.UseVisualStyleBackColor = true;
			// 
			// tmrShutdown
			// 
			this.tmrShutdown.Interval = 1000;
			this.tmrShutdown.Tick += new System.EventHandler(this.tmrShutdown_Tick);
			// 
			// ShutdownForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(447, 215);
			this.Controls.Add(this.cbHybrid);
			this.Controls.Add(this.timeLeftLabel);
			this.Controls.Add(this.lblTimeUnit);
			this.Controls.Add(this.timeComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.optionsComboBox);
			this.Controls.Add(this.setTimeText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.abortButton);
			this.Controls.Add(this.startButton);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "ShutdownForm";
			this.Text = "ShutdownForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button abortButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label lblTimeUnit;
		private System.Windows.Forms.ComboBox timeComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox optionsComboBox;
		private System.Windows.Forms.TextBox setTimeText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label timeLeftLabel;
		private System.Windows.Forms.CheckBox cbHybrid;
		private System.Windows.Forms.Timer tmrShutdown;
	}
}