using ViewModels;

namespace Views.Pages;

public partial class AbsoluteLayoutView : ContentPage
{
    private readonly AbsoluteLayoutViewModel _absoluteLayoutViewModel;

    public AbsoluteLayoutView(AbsoluteLayoutViewModel absoluteLayoutViewModel)
	{
		_absoluteLayoutViewModel = absoluteLayoutViewModel;
		BindingContext = _absoluteLayoutViewModel;

		InitializeComponent();
	}
}