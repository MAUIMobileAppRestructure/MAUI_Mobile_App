using CommunityToolkit.Maui.Alerts;

namespace MyFirstMauiApp;


public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	private async void OnSettingsButtonClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new SettingsPage());
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private async void OnShowSnackbarClicked(object sender, EventArgs e)
	{
		var snackbar = Snackbar.Make("This is a snackbar message", duration: TimeSpan.FromSeconds(3));
		await snackbar.Show();
	}
}

