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
				},
                new Frame { HeightRequest=100, WidthRequest=500, BackgroundColor= Colors.Red },
                new Frame { HeightRequest=250, WidthRequest=300, BackgroundColor= Colors.Blue },
                new Frame { HeightRequest=300, WidthRequest=700, BackgroundColor= Colors.Yellow },
                new Frame { HeightRequest=50, WidthRequest=200, BackgroundColor= Colors.Black }
            }
		};
	}
}