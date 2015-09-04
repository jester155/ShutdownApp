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

<<<<<<< HEAD
		public uint TotalSeconds {
			get {
				return Convert.ToUInt32((Hours * 60 * 60) + (Minutes * 60) + Seconds);
			}
		}

		public ulong TotalMiliseconds {
=======
		public int TotalSeconds { 
>>>>>>> 5aeb1697d9854494897a60fbd940402a29cc109a
			get {
				return Convert.ToUInt64(this.TotalSeconds * 1000);
			}
		}
	}
}
