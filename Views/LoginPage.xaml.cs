using MVVMPatternDamir8.ViewsModels;

namespace MVVMPatternDamir8.Views;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}