using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace UpdateService.Worker.Tests
{
	public class WorkerTests
	{
		internal Worker worker;
		internal Mock<ILogger<Worker>> loggerMock;

		[SetUp]
		public void Setup()
		{
			loggerMock = new Mock<ILogger<Worker>>();
			worker = new Worker(loggerMock.Object);
		}

		[Test]
		public void CheckForUpdates_IfNoUpdates_DoNothing()
		{
			bool result = worker.CheckForUpdates();
			Assert.That(result, Is.False);
		}

		[Test]
		public void CheckForUpdates_IfUpdatesAvailable_DownloadBinariesAndQueueUpdate()
		{
			Assert.Pass();
		}

		[Test]
		public void UpdateVersionManifest_IfSftpIsAvailable_UpdateManifest()
		{
			Assert.Pass();
		}

		[Test]
		public void UpdateVersionManifest_IfSftpIsNotAvailable_LogError()
		{
			Assert.Pass();
		}
	}
}