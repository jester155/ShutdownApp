using System;
using System.Diagnostics;
using DreamLib.Time;

namespace ShutdownUI {

	/// <summary>
	/// Options for various shutdown methods.
	/// </summary>
	public enum ShutdownOptions {
		Shutdown , restart , LogOff , Hybernate , Hybrid
	}

	/// <summary>
	/// Units of time for conversion.
	/// </summary>
	public enum TimeUnits {
		Seconds , Minutes , Hours
	}

	/// <summary>
	/// Shutdown Process class used to create the shutdown process that will be passes to the System.Diagnostics.Process.Start method.
	/// </summary>
	class ShutdownProcess {

		/// <summary>
		/// Shutdown option.
		/// </summary>
		public ShutdownOptions Option { get; set; }

		/// <summary>
		/// Time unit to shutdown by.
		/// </summary>
		public TimeUnits TimeUnit { get; set; }

		/// <summary>
		/// The count down time to perform the shutdown. This should be converted to seconds in this.GetTimeArg()
		/// </summary>
		public double Time { get; set; }

		/// <summary>
		/// Default constructor.
		/// </summary>
		public ShutdownProcess() { }

		/// <summary>
		/// Sends the abort command to about a shutdown in progress.
		/// </summary>
		public void Abort() {
			Process.Start("shutdown" , "-a");
		}

		/// <summary>
		/// Executes the shutdown command resulting form the available arguments.
		/// </summary>
		public void Start() {
			Process.Start("shutdown" , this.GetArgString());
		}

		/// <summary>
		/// Formats and returns the argument string.
		/// </summary>
		/// <returns>Returns the argument string for the shutdown process.</returns>
		public string GetArgString() {
			return string.Format("{0} {1}" , GetShutdownArg() , GetTimeArg());
		}

		/// <summary>
		/// Finds the appropriate shutdown arguments based on this.Option [ShutdownOptions]
		/// </summary>
		/// <returns>Returns the shutdown argument</returns>
		private string GetShutdownArg() {
			var shutdownOption = string.Empty;

			switch(this.Option) {
				case ShutdownOptions.Shutdown:
					shutdownOption = "/s";
					break;
				case ShutdownOptions.restart:
					shutdownOption = "/r";
					break;
				case ShutdownOptions.LogOff:
					shutdownOption = "/l";
					break;
				case ShutdownOptions.Hybernate:
					shutdownOption = "/h";
					break;
				case ShutdownOptions.Hybrid:
					shutdownOption = "/hybrid";
					break;
			}

			return shutdownOption;
		}

		/// <summary>
		/// Converts the given time and returns the time argument for a given shutdown time.
		/// </summary>
		/// <returns>Returns an argument for a given time.</returns>
		private string GetTimeArg() {
			try {
				switch(this.TimeUnit) {
					case TimeUnits.Seconds:
						break;
					case TimeUnits.Minutes:
						this.Time = TimeConverter.MinutesToSeconds(this.Time);
						break;
					case TimeUnits.Hours:
						this.Time = TimeConverter.HoursToSeconds(this.Time);
						break;
				}
			}
			catch(Exception) {
				return string.Empty;
			}

			return string.Format("/t {0}" , this.Time);
		}
	}
}
