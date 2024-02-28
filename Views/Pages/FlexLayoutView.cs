using ViewModels;

namespace Views.Pages;

public class FlexLayoutView : ContentPage
{
    private readonly FlexLayoutViewModel _flexLayoutViewModel;

    public FlexLayoutView(FlexLayoutViewModel flexLayoutViewModel)
	{
        _flexLayoutViewModel = flexLayoutViewModel;
		BindingContext = _flexLayoutViewModel;

        Title = "FlexLayoutView";

        Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}