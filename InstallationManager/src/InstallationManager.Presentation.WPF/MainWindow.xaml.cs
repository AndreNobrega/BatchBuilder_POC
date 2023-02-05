using InstallationManager.Domain.Model.DatabaseConnection;
using System.Windows;

namespace InstallationManager.Presentation.WPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		//Installation installation = new Installation();
		SqlConnectionDetails sqlConnectionDetails = new() { Database = "database", Server = "server", UserId = "user", Password = "password"};

		public MainWindow()
		{
			InitializeComponent();
			//this.DataContext = installation;

			/*
			 * TODO: 
			 *	- create helper in Application layer that (de)constructs connection strings using the Domain layer's connection string extensions
			 *	- hook up helper to presentation layer's fields
			 *	- change the Connection String behaviour so it isn't automatically set when params change and vice-versa. This messes with the input.
			 */

			this.DataContext = sqlConnectionDetails;
		}
	}
}
