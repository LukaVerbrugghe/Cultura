namespace prjCultura;

public partial class Signup : ContentPage
{
	public Signup()
	{
		InitializeComponent();
	}

	private async void toggleShowFirstPassword(object sender, EventArgs e)
	{

	}

	private async void toggleShowSecondPassword(object sender, EventArgs e)
	{ 
	
	}

	private async void btnRegistreren_Clicked(object sender, EventArgs e)
    { 
    
    }

	private async void lblGoToLogin_Tapped(object sender, EventArgs e)
    { 
		await Shell.Current.GoToAsync("///MainPage"); //MainPage is the DataTemplate for the login page, do not change
    }
}