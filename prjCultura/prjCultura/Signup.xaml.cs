using System.Threading.Tasks;

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

    private async void lblViewLicense_Tapped(object sender, TappedEventArgs e)
    {
		//open the license on github
		BrowserLaunchOptions options = new BrowserLaunchOptions()
		{
			LaunchMode = BrowserLaunchMode.SystemPreferred,
			TitleMode = BrowserTitleMode.Show
		};
		await Browser.Default.OpenAsync("https://github.com/LukaVerbrugghe/Cultura/blob/main/LICENSE", options);
    }

	private async void lblViewPrivacyPolicy_Tapped(object sender, TappedEventArgs e)
    {
        //open the privacy policy on github
        BrowserLaunchOptions options = new BrowserLaunchOptions()
        {
            LaunchMode = BrowserLaunchMode.SystemPreferred,
            TitleMode = BrowserTitleMode.Show
        };
        await Browser.Default.OpenAsync("https://github.com/LukaVerbrugghe/Cultura/blob/main/PRIVACY.md", options);
    }
}