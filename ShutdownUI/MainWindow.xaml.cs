using System;
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

		public bool IsShuttingDown { get; set; }

		public MainWindow() {
			InitializeComponent();
			CbShutdownOptions.ItemsSource = Enum.GetValues(typeof(ShutdownOptions)).Cast<ShutdownOptions>();
			CbShutdownOptions.SelectedIndex = 0;
			this.IsShuttingDown = false;
			this.SetActionButtonForeground();
		}

		private static bool IsTextAllowed(string text) {
			Regex regex = new Regex("[^0-9.-]+"); //regex that matches disallowed text
			return !regex.IsMatch(text);
		}

		private void BtnActionClick(object sender , RoutedEventArgs e) {
			this.IsShuttingDown = !IsShuttingDown;
			this.SetActionButtonForeground();
		}

		private void SetActionButtonForeground() {
			this.BtnAction.Foreground = this.IsShuttingDown ? Brushes.PaleVioletRed : Brushes.BlueViolet;
			this.BtnAction.Content = this.IsShuttingDown ? "Abort!" : "Start";
		}

		private void PreviewTextInputRegexValidation(object sender , TextCompositionEventArgs e) {
			e.Handled = !IsTextAllowed(e.Text);
		}
	}
}
