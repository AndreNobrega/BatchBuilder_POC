using Application;
using Infrastructure;
using Microsoft.Extensions.Hosting;

namespace InstallationManager.Presentation.WPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : System.Windows.Application
	{
		public App()
		{
			CreateHostBuilder(null).Build().Run();
		}

		public static IHostBuilder CreateHostBuilder(string[]? args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureServices((hostContext, services) =>
				{
					services.AddApplicationServices();
					services.AddInfrastructureServices();
				});
	}
}
