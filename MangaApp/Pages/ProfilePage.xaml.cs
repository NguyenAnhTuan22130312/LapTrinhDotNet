using MangaApp.Services;

namespace MangaApp.Pages;


public partial class ProfilePage : ContentPage
{
	private readonly AuthService _authService;
	public ProfilePage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		_authService.Logout();
		Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
    }
}
