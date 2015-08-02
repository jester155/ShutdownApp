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
		public ShutdownForm() {
			InitializeComponent();
			timeComboBox.SelectedIndex = 0;
			optionsComboBox.SelectedIndex = 0;
			this.label3.Text = timeComboBox.Text;
		}

		private void startButton_Click(object sender , EventArgs e) {
			this.timeLeftLabel.Text = this.setTimeText.Text;
			var command = this.CreateProcessString();
			tmrShutdown.Enabled = true;
			tmrShutdown.Start();
			Process.Start("shutdown" , command);
			this.abortButton.Enabled = true;
			this.startButton.Enabled = false;
		}

		private string CreateProcessString() {
			var sdCommand = string.Empty;

			if(this.cbHybrid.Checked) {
				sdCommand = "/hybrid";
			}
			else {
				switch(this.optionsComboBox.SelectedIndex) {
					case 0:
						sdCommand += "/s ";
						break;
					case 1:
						sdCommand += "/r ";
						break;
					case 2:
						sdCommand += "/l ";
						break;
					case 3:
						sdCommand += "/h ";
						break;
				}
			}
			var time = 0.0;

			switch(this.timeComboBox.SelectedIndex) {
				case 0:
					double.TryParse(this.setTimeText.Text , out time);
					break;
				case 1:
					double.TryParse(this.setTimeText.Text , out time);
					time = TimeConverter.MinutesToSeconds(time);
					break;
				case 2:
					double.TryParse(this.setTimeText.Text , out time);
					time = TimeConverter.HoursToSeconds(time);
					break;
				default:
					break;
			}

			sdCommand += "/t " + time;

			this.timeLeftLabel.Text = time.ToString();

			return sdCommand;
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

			Process.Start("shutdown" , "-a");
		}
	}
}
