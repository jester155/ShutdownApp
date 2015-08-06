using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DreamLib.Time;
using System.Diagnostics;

namespace ShutdownApp {
	public partial class ShutdownForm : Form {

		ShutdownProcess ShutdownProcess;

		public ShutdownForm() {
			InitializeComponent();
			timeComboBox.SelectedIndex = 0;
			optionsComboBox.SelectedIndex = 0;
			this.lblTimeUnit.Text = timeComboBox.Text;
		}

		private void startButton_Click(object sender , EventArgs e) {
			this.ShutdownProcess = this.CreateProcess();
			ShutdownProcess.Start();
			this.timeLeftLabel.Text = this.ShutdownProcess.Time.ToString();
			tmrShutdown.Enabled = true;
			tmrShutdown.Start();
			this.abortButton.Enabled = true;
			this.startButton.Enabled = false;
		}

		private ShutdownProcess CreateProcess() {
			var sdCommand = string.Empty;

			ShutdownProcess process = null;

			try {
				process = new ShutdownProcess() {
					Option = this.cbHybrid.Checked ? ShutdownOptions.Hybrid : (ShutdownOptions) this.optionsComboBox.SelectedIndex ,
					TimeUnit = (TimeUnits) this.timeComboBox.SelectedIndex ,
					Time = Convert.ToDouble(this.setTimeText.Text)
				};
			}
			catch(Exception) {
				MessageBox.Show("Could not create shutdown process.");
			}

			return process != null ? process : null;
		}

		private void tmrShutdown_Tick(object sender , EventArgs e) {
			if(this.timeLeftLabel.Text != "0") {
				this.timeLeftLabel.Text = (Convert.ToInt32(this.timeLeftLabel.Text) - 1).ToString();
			}
			else {
				this.tmrShutdown.Stop();
				this.tmrShutdown.Enabled = false;
			}

		}

		private void abortButton_Click(object sender , EventArgs e) {
			this.startButton.Enabled = true;
			this.abortButton.Enabled = false;

			this.tmrShutdown.Stop();

			this.timeLeftLabel.Text = "0";

			this.ShutdownProcess.Abort();
		}
	}
}
