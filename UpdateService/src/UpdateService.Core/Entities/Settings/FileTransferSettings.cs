namespace UpdateService.Core.Entities.Settings
{
	public class FileTransferSettings
	{
		public LocalFileSystemSettings LocalFileSystemSettings { get; set; }
		public SftpSettings SftpSettings { get; set; }
	}
}
