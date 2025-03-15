using MVVMPatternDamir8.ViewsModels;

namespace MVVMPatternDamir8.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
        BindingContext = new MainViewModel();
    }
}