using ViewModels;

namespace Views.Pages;

public partial class StackLayoutView : ContentPage
{
    private readonly StackLayoutViewModel _stackLayoutViewModel;

    public StackLayoutView(StackLayoutViewModel stackLayoutViewModel)
	{
		_stackLayoutViewModel = stackLayoutViewModel;
		BindingContext = _stackLayoutViewModel;
		InitializeComponent();
	}
}