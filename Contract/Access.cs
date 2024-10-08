using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions.Contracts
{
	public class Access : IAccess
	{
		public async Task<bool> CanAccess(string settings, int position)
		{
			var index = 0;
			if (position > 0)
				index = position - 1;

			if (!string.IsNullOrEmpty(settings))
			{
				if (position <= settings.Length)
				{
					return settings[index].ToString() == "1";
				}
			}
			return false;
		}
	}
}
