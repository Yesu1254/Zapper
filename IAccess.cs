using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
	public interface IAccess
	{
		Task<bool> CanAccess(string settings, int position);
	}
}
