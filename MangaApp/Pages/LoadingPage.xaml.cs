using MangaApp.Services;

namespace MangaApp.Pages;

public partial class LoadingPage : ContentPage
{
	private readonly AuthService _authService;
	public LoadingPage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

		if (await _authService.IsAuthenticatedAsync()) {
            //Neu nguoi dung dang nhap
            //Dua toi trang Main Page
            await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
        }
		else
		{
			//Neu khong dang nhap
			//Dua toi trang Login Page
			await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
		}
    }
}
