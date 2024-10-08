using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Model
{
	public class UserSettings
	{
		public bool SMSNotificationsEnabled { get; set; }
		public bool PushNotificationsEnabled { get; set; }
		public bool BioMetricsEnabled { get; set; }
		public bool CameraEnabled { get; set; }
		public bool LocationEnabled { get; set; }
		public bool NFCEnabled { get; set; }
		public bool VouchersEnabled { get; set; }
		public bool LoyaltyEnabled { get; set; }
	}
}
