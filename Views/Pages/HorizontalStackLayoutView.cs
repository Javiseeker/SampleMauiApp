using ViewModels;

namespace Views.Pages;

public class HorizontalStackLayoutView : ContentPage
{
    private readonly HorizontalStackLayoutViewModel _horizontalStackLayoutViewModel;
    public HorizontalStackLayoutView(HorizontalStackLayoutViewModel horizontalStackLayoutViewModel)
	{
		_horizontalStackLayoutViewModel = horizontalStackLayoutViewModel;
		BindingContext = _horizontalStackLayoutViewModel;

		Title = "HorizontalStackLayoutView";

        Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}