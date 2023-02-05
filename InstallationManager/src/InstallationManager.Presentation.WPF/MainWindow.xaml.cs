using InstallationManager.Application;
using InstallationManager.Domain.Model;
using InstallationManager.Domain.Model.DatabaseConnection;
using InstallationManager.Infrastructure;
using Microsoft.Extensions.Hosting;
using System.Data.SqlClient;
using System.Windows;

namespace InstallationManager.Presentation.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//Installation installation = new Installation();
		
		public MainWindow()
		{
			InitializeComponent();
			//this.DataContext = installation;

			/*
			 * TODO: 
			 *	- create helper in Application layer that (de)constructs connection strings using the Domain layer's connection string extensions
			 *	- hook up helper to presentation layer's fields
			 */


			this.DataContext = new SqlConnectionDetails()
			{
				UserId = "admin",
				Password = "admin",
			}; ;
		}
	}
}
