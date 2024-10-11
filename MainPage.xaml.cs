namespace MAPPUI;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private async void BugSweepclick(object sender, EventArgs e)
	{
		//await Navigation.PushAsync(new BugSweeper.MainPage());
	}

	private async void CalcClick(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new Calculator.MainPage());
	}

	private async void GoLClick(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GameOfLife.MainPage());
	}
}

