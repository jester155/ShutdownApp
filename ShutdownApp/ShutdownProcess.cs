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
		public double Time { get; set; }
		public string ProcessString { get; set; }


		public ShutdownProcess() { }

		public ShutdownProcess(ShutdownOptions option , TimeUnits timeUnit , double time) {
			this.Option = option;
			this.TimeUnit = timeUnit;
			this.Time = time;
		}

		public void Abort() {
			Process.Start("shutdown" , "-a");
		}

		public void Start() {
			Process.Start("shutdown" , this.GetArgString());
		}

		public string GetArgString() {
			return string.Format("{0} {1}" , GetShutdownArg() , GetTimeArg());
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
