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
			this.abortButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
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
			this.abortButton.Location = new System.Drawing.Point(16, 93);
			this.abortButton.Name = "abortButton";
			this.abortButton.Size = new System.Drawing.Size(100, 41);
			this.abortButton.TabIndex = 4;
			this.abortButton.Text = "Abort!";
			this.abortButton.UseVisualStyleBackColor = true;
			this.abortButton.Click += new System.EventHandler(this.abortButton_Click);
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.startButton.Location = new System.Drawing.Point(16, 46);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(100, 41);
			this.startButton.TabIndex = 5;
			this.startButton.Text = "Start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(264, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(50, 18);
			this.label3.TabIndex = 14;
			this.label3.Text = "label3";
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
			this.timeComboBox.Location = new System.Drawing.Point(202, 14);
			this.timeComboBox.MaxDropDownItems = 3;
			this.timeComboBox.Name = "timeComboBox";
			this.timeComboBox.Size = new System.Drawing.Size(121, 26);
			this.timeComboBox.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(129, 105);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 18);
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
			this.optionsComboBox.Location = new System.Drawing.Point(202, 55);
			this.optionsComboBox.Name = "optionsComboBox";
			this.optionsComboBox.Size = new System.Drawing.Size(121, 26);
			this.optionsComboBox.TabIndex = 12;
			// 
			// setTimeText
			// 
			this.setTimeText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.setTimeText.Location = new System.Drawing.Point(92, 14);
			this.setTimeText.Name = "setTimeText";
			this.setTimeText.Size = new System.Drawing.Size(100, 26);
			this.setTimeText.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(16, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 18);
			this.label1.TabIndex = 9;
			this.label1.Text = "Set Time";
			// 
			// timeLeftLabel
			// 
			this.timeLeftLabel.AutoSize = true;
			this.timeLeftLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.timeLeftLabel.Location = new System.Drawing.Point(198, 103);
			this.timeLeftLabel.Name = "timeLeftLabel";
			this.timeLeftLabel.Size = new System.Drawing.Size(20, 22);
			this.timeLeftLabel.TabIndex = 15;
			this.timeLeftLabel.Text = "0";
			// 
			// cbHybrid
			// 
			this.cbHybrid.AutoSize = true;
			this.cbHybrid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbHybrid.Location = new System.Drawing.Point(19, 146);
			this.cbHybrid.Name = "cbHybrid";
			this.cbHybrid.Size = new System.Drawing.Size(125, 20);
			this.cbHybrid.TabIndex = 16;
			this.cbHybrid.Text = "Hybrid Shutdown";
			this.cbHybrid.UseVisualStyleBackColor = true;
			// 
			// tmrShutdown
			// 
			this.tmrShutdown.Interval = 10000;
			this.tmrShutdown.Tick += new System.EventHandler(this.tmrShutdown_Tick);
			// 
			// ShutdownForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(335, 175);
			this.Controls.Add(this.cbHybrid);
			this.Controls.Add(this.timeLeftLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.timeComboBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.optionsComboBox);
			this.Controls.Add(this.setTimeText);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.abortButton);
			this.Controls.Add(this.startButton);
			this.Name = "ShutdownForm";
			this.Text = "ShutdownForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button abortButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.Label label3;
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