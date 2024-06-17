namespace Plugin.Maui.Handlers.Sample;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    async void OnHideKeyboardClicked(object sender, EventArgs args)
    {
       UtilHandler.HideKeyboard();
    }
}
