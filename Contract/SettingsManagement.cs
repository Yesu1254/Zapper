using Functions.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Functions.Contracts
{
	public class SettingsManagement : ISettingsManagement
	{
		public void SaveBinarySettings(string settings, string filepath)
		{
			if (!string.IsNullOrEmpty(settings) && !string.IsNullOrEmpty(filepath))
			{
				var fullpath = System.IO.Path.Combine(filepath, "binarystettings.txt");
				System.IO.File.WriteAllText(fullpath, settings);
			}
		}

		public string ReadBinarySettings(string filepath)
		{
			var fullpath = System.IO.Path.Combine(filepath, "binarystettings.txt");
			if (System.IO.File.Exists(fullpath))
			{
				return System.IO.File.ReadAllText(fullpath);
			}
			else throw new Exception("File not found in a given path");
		}

		public UserSettings ReadJsonSettings(string filepath)
		{
			var fullpath = System.IO.Path.Combine(filepath, "jsonstettings.txt");
			if (System.IO.File.Exists(fullpath))
			{
				var fileContents = System.IO.File.ReadAllText(fullpath);

				if (fileContents != null)
				{
					return JsonSerializer.Deserialize<UserSettings>(fileContents)!;
				}

				return new UserSettings();
			}
			else throw new Exception("File not found in a given path");
		}

		public void SaveJsonSettings(UserSettings settings, string filepath)
		{
			if (settings != null)
			{
				var fullpath = System.IO.Path.Combine(filepath, "jsonstettings.txt");
				var json = JsonSerializer.Serialize(settings);
				System.IO.File.WriteAllText(fullpath, json);
			}
			else throw new Exception("Problem with saving a file");
		}
	}
}
