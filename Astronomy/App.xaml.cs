namespace Astronomy;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		//Initializing new Shell Object
		MainPage = new AppShell();
	}
}
