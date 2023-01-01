namespace UpdateService.Core.Entities.Settings
{
	public class SftpSettings : FileTransferSettingsBase
	{
		public bool UseSftp { get; set; }
		public string BaseUrl { get; set; }
		public string Port { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
