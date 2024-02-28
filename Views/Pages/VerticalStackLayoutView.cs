using ViewModels;

namespace Views.Pages;

public class VerticalStackLayoutView : ContentPage
{
    private readonly VerticalStackLayoutViewModel _absoluteLayoutViewModel;

    public VerticalStackLayoutView(VerticalStackLayoutViewModel absoluteLayoutViewModel)
	{
		_absoluteLayoutViewModel = absoluteLayoutViewModel;
		BindingContext = _absoluteLayoutViewModel;

        Title = "VerticalStackLayoutView";

        Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}