using NUnit.Framework;
using UpdateService.Core.Services;

namespace UpdateService.Core.Tests
{
	public class ManifestServiceTests
	{
		private ManifestService manifestService;

		[SetUp]
		public void Setup()
		{
			manifestService = new ManifestService();
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
	}
}
