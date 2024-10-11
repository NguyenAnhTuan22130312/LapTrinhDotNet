using MangaApp.Services;

namespace MangaApp.Pages;

public partial class LoginPage : ContentPage
{
	private readonly AuthService _authService;
	public LoginPage(AuthService authService)
	{
		InitializeComponent();
	}

    private async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		_authService.Login();
		await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }
}
