using Functions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
	public interface ISettingsManagement
	{
		void SaveBinarySettings(string settings, string filepath);
		string ReadBinarySettings(string filepath);
		UserSettings ReadJsonSettings(string filepath);
		void SaveJsonSettings(UserSettings settings, string path);
	}
}
