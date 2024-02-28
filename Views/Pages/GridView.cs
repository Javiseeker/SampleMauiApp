using ViewModels;

namespace Views.Pages;

public class GridView : ContentPage
{
    private readonly GridViewModel _gridViewModel;
    public GridView(GridViewModel gridViewModel)
	{
        _gridViewModel = gridViewModel;
		BindingContext = _gridViewModel;

        Title = "GridView";

        Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!"
				}
			}
		};
	}
}