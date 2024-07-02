using Dalui.Views;

namespace Dalui;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new DashboardView();
	}
}
