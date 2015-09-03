using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shutdown.Core {

	/// <summary>
	/// Time struct to represent hours minutes and seconds.
	/// </summary>
	public struct Time {

		/// <summary>
		/// Hours time interval.
		/// </summary>
		public short Hours { get; set; }
		
		/// <summary>
		/// Minutes time interval.
		/// </summary>
		public short Minutes { get; set; }
		
		/// <summary>
		/// Seconds time interval.
		/// </summary>
		public short Seconds { get; set; }

		public int TotalSeconds { 
			get {
				return Hours != null && Minutes != null && Seconds != null ?
					(Hours * 60 * 60) + (Minutes * 60) + Seconds : -1;
			}
		}
	}
}
