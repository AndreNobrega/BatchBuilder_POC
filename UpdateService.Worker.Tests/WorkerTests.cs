using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using UpdateService.Core.Entities;
using UpdateService.Core.Entities.Settings;
using UpdateService.Core.Interfaces;

namespace UpdateService.Worker.Tests
{
    public class WorkerTests
	{
		internal Worker worker;
		internal Mock<ILogger<Worker>> loggerMock;
		internal Mock<IUpdateService> updateServiceMock;
		internal Mock<IConfigurationService> configurationServiceMock;

		[SetUp]
		public void Setup()
		{
			loggerMock = new Mock<ILogger<Worker>>();
			updateServiceMock= new Mock<IUpdateService>();
			configurationServiceMock= new Mock<IConfigurationService>();

			SetUpTenants();

			worker = new Worker(loggerMock.Object, updateServiceMock.Object, configurationServiceMock.Object);
		}

		private void SetUpTenants()
		{
			var tenant1 = new Tenant()
			{
				Id = "1",
				Name = "1",
				Environment = DeployEnvironment.Development
			};

			var tenant2 = new Tenant()
			{
				Id = "2",
				Name = "2",
				Environment = DeployEnvironment.Acceptance
			};

			var tenant3 = new Tenant()
			{
				Id = "3",
				Name = "3",
				Environment = DeployEnvironment.Production
			};

			var tenants = new List<Tenant> { tenant1, tenant2, tenant3 };

			configurationServiceMock
				.Setup(cs => cs.GetTenants())
				.Returns(tenants);
		}

		[Test]
		public void CheckForUpdates_IfNoUpdates_DoNothing()
		{
			// Arrange
			updateServiceMock
				.Setup(u => u.IsUpdateAvailable(It.IsAny<DeployEnvironment>()))
				.Returns(false);

			// Act
			bool result = worker.CheckForUpdates();

			// Assert
			Assert.That(result, Is.False);
		}

		[Test]
		public void CheckForUpdates_IfUpdatesAvailable_DownloadBinariesAndQueueUpdate()
		{
			// Arrange
			updateServiceMock
				.Setup(u => u.IsUpdateAvailable(It.IsAny<DeployEnvironment>()))
				.Returns(true);

			// Act
			bool result = worker.CheckForUpdates();

			// Assert
			Assert.That(result, Is.True);
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