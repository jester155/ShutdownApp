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
using DreamLib.Time;
using System.Text.RegularExpressions;

namespace ShutdownUI {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window {

		/// <summary>
		/// Indicates that the app is shutting down.
		/// </summary>
		public bool IsShuttingDown { get; set; }

		public MainWindow() {
			InitializeComponent();
			CbShutdownOptions.ItemsSource = Enum.GetValues(typeof(ShutdownOptions)).Cast<ShutdownOptions>();
			CbShutdownOptions.SelectedIndex = 0;
			this.IsShuttingDown = false;
			this.SetActionButtonForeground();
		}

		/// <summary>
		/// Checks if the a given set of characters is allowed.
		/// </summary>
		/// <param name="text">The string to evaluate.</param>
		/// <returns>Returns true if the text does not contain numbers.</returns>
		private static bool IsTextAllowed(string text) {
			Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
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
			e.Handled = !IsTextAllowed(e.Text);
		}
	}
}
