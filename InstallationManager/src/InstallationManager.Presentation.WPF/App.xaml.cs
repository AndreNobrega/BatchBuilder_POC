using InstallationManager.Application;
using InstallationManager.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace InstallationManager.Presentation.WPF
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : System.Windows.Application
	{
		private static IHost? host;

		public App()
		{
			host = CreateHostBuilder().Build();
		}

		private static IHostBuilder CreateHostBuilder() =>
			Host.CreateDefaultBuilder()
				.ConfigureServices((hostContext, services) =>
				{
					services.AddApplicationServices();
					services.AddInfrastructureServices();

					services.AddSingleton<MainWindow>();
				});

		protected override async void OnStartup(StartupEventArgs e)
		{
			await host!.StartAsync();

			var mainWindow = host!.Services.GetRequiredService<MainWindow>();
			mainWindow.Show();

			base.OnStartup(e);
		}

		protected override async void OnExit(ExitEventArgs e)
		{
			await host!.StopAsync();
			base.OnExit(e);
		}
	}
}
