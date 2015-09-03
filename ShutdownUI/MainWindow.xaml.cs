﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using Shutdown.Core;
using System.Timers;
using System.Windows.Media.Animation;

namespace Shutdown.Ui {

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		#region Properties

		/// <summary>
		/// The active and default shutdown process for the form.
		/// </summary>
		private ShutdownProcess ShutdownProcess = new ShutdownProcess();

		/// <summary>
		/// Indicates that the app is shutting down.
		/// </summary>
		private bool IsShuttingDown { get; set; }

		/// <summary>
		/// The timer used to track shutdown in the program.
		/// </summary>
		public Timer ShutdownTimer { get; set; }

		/// <summary>
		/// Elapsed time in seconds once the shutdown process has benn started.
		/// </summary>
		public uint ElapsedTime { get; set; }

		#endregion

		#region Constructors

		/// <summary>
		/// Default constructor for creating a MainForm.
		/// </summary>
		public MainWindow() {
			InitializeComponent();
			CbShutdownOptions.ItemsSource = Enum.GetValues(typeof(ShutdownOptions)).Cast<ShutdownOptions>();
			CbShutdownOptions.SelectedIndex = 0;
			this.IsShuttingDown = false;
			this.SetActionButtonForeground();
			this.WindowStyle = System.Windows.WindowStyle.SingleBorderWindow;
			this.ResizeMode = System.Windows.ResizeMode.CanMinimize;
			this.ShutdownTimer = new Timer(1000);
			this.ShutdownTimer.Elapsed += TimerTick;
			this.ElapsedTime = 0;
		}

		#endregion

		#region Methods

		private void TimerTick(object sender , ElapsedEventArgs e) {
			Duration duration = TimeSpan.FromSeconds(1);
			DoubleAnimation doubleAnimation =
				new DoubleAnimation(this.ElapsedTime , this.ElapsedTime + 1 , duration);

			if(++this.ElapsedTime <= this.ShutdownProcess.Time.TotalSeconds) {
				this.Dispatcher.Invoke(() => {
					this.PbShutdown.BeginAnimation(ProgressBar.ValueProperty , doubleAnimation);
				});
			}
		}

		/// <summary>
		/// Checks if the a given set of characters is allowed.
		/// </summary>
		/// <param name="text">The string to evaluate.</param>
		/// <returns>Returns true if the text does not contain numbers.</returns>
		private static bool IsTextAllowed(string text) {
			Regex regex = new Regex("[^0-9]+"); //regex that matches disallowed text
			return !regex.IsMatch(text);
		}

		/// <summary>
		/// Action button click even handler.
		/// </summary>
		/// <param name="sender">The sender object of the evet.</param>
		/// <param name="e">The even arguments passed in from an action.</param>
		private void BtnActionClick(object sender , RoutedEventArgs e) {
			this.IsShuttingDown = !IsShuttingDown;
			this.SetActionButtonForeground();
			if(this.IsShuttingDown) {
				this.ShutdownProcess = new ShutdownProcess {
					Option = (ShutdownOptions) this.CbShutdownOptions.SelectedItem ,
					Time = new Time {
						Hours = short.Parse(this.TbHours.Text) ,
						Minutes = short.Parse(this.TbMinutes.Text) ,
						Seconds = short.Parse(this.TbSeconds.Text)
					}
				};

				this.ShutdownProcess.Start();
				this.ShutdownTimer.Start();
				this.PbShutdown.Maximum = this.ShutdownProcess.Time.TotalSeconds;
			}
			else { this.Resetvalues(); }
		}

		/// <summary>
		/// Resets all values to their defaults.
		/// </summary>
		public void Resetvalues() {
			this.ShutdownProcess.Abort();
			this.ShutdownTimer.Stop();
			this.ElapsedTime = 0;
			this.PbShutdown.Value = 0;
		}

		/// <summary>
		/// Sets the foreground text and color of the action button based on the state of shutdown.
		/// </summary>
		private void SetActionButtonForeground() {
			this.BtnAction.Foreground = this.IsShuttingDown ? Brushes.PaleVioletRed : Brushes.BlueViolet;
			this.BtnAction.Content = this.IsShuttingDown ? "Abort!" : "Start";
		}

		/// <summary>
		/// Validates the text coming into the textbox and assigns it appropriatly.
		/// </summary>
		/// <param name="sender">the sender object</param>
		/// <param name="e">The even arguments passed in from the action.</param>
		private void PreviewTextInputRegexValidation(object sender , TextCompositionEventArgs e) {
			var senderUpCast = sender as TextBox;
			e.Handled = !IsTextAllowed(e.Text);
		}

		#endregion
	}
}
