using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using DreamLib.Time;

namespace ShutdownApp {

	public enum ShutdownOptions {
		Shutdown , restart , Lock , Hybernate , Hybrid
	}

	public enum TimeUnits {
		Seconds , Minutes , Hours
	}

	class ShutdownProcess {

		public ShutdownOptions Option { get; set; }
		public TimeUnits TimeUnit { get; set; }
		public string TimeString { get; set; }


		public ShutdownProcess() { }

		public ShutdownProcess(ShutdownOptions option , TimeUnits timeUnit , string timeString) {
			this.Option = option;
			this.TimeUnit = timeUnit;
			this.TimeString = timeString;
		}

		public void Abort() {
			Process.Start("shutdown" , "-a");
		}

		public string BuildArgString() {
			return string.Format("shutdown {0} {1}" , GetShutdownArg() , GetTimeArg());
		}

		private string GetShutdownArg() {
			var shutdownOption = string.Empty;

			switch(this.Option) {
				case ShutdownOptions.Shutdown:
					shutdownOption = "/s";
					break;
				case ShutdownOptions.restart:
					shutdownOption = "/r";
					break;
				case ShutdownOptions.Lock:
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

		private string GetTimeArg() {

			var timeArg = string.Empty;
			var time = 0.0;
			try {

				double.TryParse(this.TimeString , out time);

				switch(this.TimeUnit) {
					case TimeUnits.Seconds:
						break;
					case TimeUnits.Minutes:
						time = TimeConverter.MinutesToSeconds(time);
						break;
					case TimeUnits.Hours:
						time = TimeConverter.HoursToSeconds(time);
						break;
				}
			}
			catch(Exception) {
				return string.Empty;
			}

			timeArg += string.Format("/t {0}" , time);

			return timeArg;
		}
	}
}
