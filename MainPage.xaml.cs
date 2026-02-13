using CommunityToolkit.Maui;

namespace maui_set_binding;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

		new AppThemeColor { Light = new Color(0, 0, 0, 1), Dark = new Color(1, 1, 1, 1) }.GetBinding();
	}

	private void OnCounterClicked(object? sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}
