// See https://aka.ms/new-console-template for more information
using Functions;
using Functions.Contracts;
using Functions.Model;

//Console.WriteLine("Hello, World!");

var filePath = "C:\\temp";
if (!System.IO.File.Exists(filePath))
{
	System.IO.Directory.CreateDirectory(filePath);
}

IAccess access = new Access();
var canAccess = await access.CanAccess("00000010", 7);
if (canAccess)
	Console.WriteLine("Vouchers access enabled");
else
	Console.WriteLine("Vouchers access enabled");

ISettingsManagement settingsManagement = new SettingsManagement();
settingsManagement.SaveBinarySettings("0001", filePath);
Console.WriteLine("Binary format file Created Succesfully!");

var model = new UserSettings()
{
	SMSNotificationsEnabled = true,
	PushNotificationsEnabled = true,
	BioMetricsEnabled = true,
	CameraEnabled = true,
	LocationEnabled = true,
	NFCEnabled = true,
	VouchersEnabled = true,
	LoyaltyEnabled = true,
};

settingsManagement.SaveJsonSettings(model, filePath);
Console.WriteLine("Json format file Created Succesfully!");

var result = settingsManagement.ReadBinarySettings(filePath);
Console.WriteLine("Binary Settings file read completed! {0}", result);

var userModel = settingsManagement.ReadJsonSettings(filePath);
Console.WriteLine("Json Settings file read completed! SMSNotificationsEnabled: {0},PushNotificationsEnabled: {1},BioMetricsEnabled: {2},CameraEnabled: {3}, LocationEnabled:{4},NFCEnabled:{5},VouchersEnabled: {6}, LoyaltyEnabled:{7}", userModel.SMSNotificationsEnabled, userModel.PushNotificationsEnabled, userModel.BioMetricsEnabled, userModel.CameraEnabled, userModel.LoyaltyEnabled, userModel.NFCEnabled, userModel.VouchersEnabled, userModel.LoyaltyEnabled);