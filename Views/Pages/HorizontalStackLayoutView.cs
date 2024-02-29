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

        var ly = new HorizontalStackLayout
        {
            Children = {
                new Frame { HeightRequest=500, WidthRequest=500, BackgroundColor= Colors.Red },
                new Frame { HeightRequest=200, WidthRequest=300, BackgroundColor= Colors.Blue },
                new Frame { HeightRequest=300, WidthRequest=700, BackgroundColor= Colors.Yellow },
                new Frame { HeightRequest=600, WidthRequest=200, BackgroundColor= Colors.Black }
            }
        };


        Content = new ScrollView { Content = ly, Orientation = ScrollOrientation.Horizontal };
	}
}