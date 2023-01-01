using NUnit.Framework;
using UpdateService.Core.Interfaces;
using Moq;

namespace UpdateService.Core.Tests
{
	public class UpdateServiceTests
	{
		private Services.UpdateService _updateService;
		private Mock<IFileTransferService> _fileTransferServiceMock;
		private Mock<IManifestService> _manifestServiceMock;

		[SetUp]
		public void Setup()
		{
			_fileTransferServiceMock= new Mock<IFileTransferService>();
			_manifestServiceMock= new Mock<IManifestService>();

			_updateService = new Services.UpdateService(_fileTransferServiceMock.Object, _manifestServiceMock.Object);
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
	}
}