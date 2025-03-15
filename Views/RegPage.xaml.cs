using MVVMPatternDamir8.ViewsModels;

namespace MVVMPatternDamir8.Views;

public partial class RegPage : ContentPage
{
	public RegPage()
	{
		InitializeComponent();
		BindingContext = new RegViewModel();
	}
}