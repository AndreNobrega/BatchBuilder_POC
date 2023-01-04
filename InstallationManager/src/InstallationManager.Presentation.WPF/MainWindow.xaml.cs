using InstallationManager.Application;
using InstallationManager.Infrastructure;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace InstallationManager.Presentation.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly IHost builder;

		public MainWindow()
		{
			builder = CreateHostBuilder(null).Build();
			builder.Run();

			InitializeComponent();
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
