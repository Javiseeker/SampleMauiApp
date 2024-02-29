using Microsoft.Maui.Layouts;
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

        var flexLayout = new FlexLayout
        {
            Direction = FlexDirection.Column,
            AlignItems = FlexAlignItems.Center,
            JustifyContent = FlexJustify.SpaceEvenly
        };

        var label1 = new Label { Text = "FlexLayout in Action" };
        var button = new Button { Text = "Click Me!" };
        var frame = new Frame { HeightRequest = 333, WidthRequest = 200, BackgroundColor = Colors.YellowGreen };
        // Add children to the FlexLayout
        flexLayout.Children.Add(label1);
        flexLayout.Children.Add(button);
        flexLayout.Children.Add(frame);
        // Set the FlexLayout as the content of the page
        Content = flexLayout;
    }
}