using System;
using System.Windows.Forms;
using DreamLib.Time;
using System.Diagnostics;

namespace ShutdownApp {
	public partial class ShutdownForm : Form {

		ShutdownProcess ShutdownProcess;

		public ShutdownForm() {

			InitializeComponent();
			ComboBoxTime.SelectedIndex = 0;
			ComboBoxOptions.SelectedIndex = 0;
			this.LblTimeUnit.Text = ComboBoxTime.Text;
		}

		private void startButton_Click(object sender , EventArgs e) {

			this.ShutdownProcess = this.CreateProcess();
			ShutdownProcess.Start();

			this.LblTimeLeft.Text = this.ShutdownProcess.Time.ToString();

			tmrShutdown.Enabled = true;
			tmrShutdown.Start();

			this.BtnAbort.Enabled = true;
			this.BtnStart.Enabled = false;
		}

		private ShutdownProcess CreateProcess() {

			ShutdownProcess process = null;

			try {
				process = new ShutdownProcess() {

					Option = this.CheckBoxHybrid.Checked ? ShutdownOptions.Hybrid : (ShutdownOptions) this.ComboBoxOptions.SelectedIndex ,
					TimeUnit = (TimeUnits) this.ComboBoxTime.SelectedIndex ,
					Time = Convert.ToDouble(this.TbSetTimeText.Text)
				};
			}
			catch(Exception) {
				MessageBox.Show("Could not create shutdown process.");
			}

			return process != null ? process : null;
		}

		private void tmrShutdown_Tick(object sender , EventArgs e) {

			if(this.LblTimeLeft.Text != "0") {
				this.LblTimeLeft.Text = (Convert.ToInt32(this.LblTimeLeft.Text) - 1).ToString();
			}
			else {
				this.tmrShutdown.Stop();
				this.tmrShutdown.Enabled = false;
			}

		}

		private void abortButton_Click(object sender , EventArgs e) {

			this.BtnStart.Enabled = true;
			this.BtnAbort.Enabled = false;

			this.tmrShutdown.Stop();

			this.LblTimeLeft.Text = "0";

			this.ShutdownProcess.Abort();
		}
	}
}
