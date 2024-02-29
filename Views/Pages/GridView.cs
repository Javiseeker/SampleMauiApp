using CommunityToolkit.Maui.Markup;
using ViewModels;
using static CommunityToolkit.Maui.Markup.GridRowsColumns;

namespace Views.Pages;

public class GridView : ContentPage
{
    private readonly GridViewModel _gridViewModel;
    public GridView(GridViewModel gridViewModel)
	{
        _gridViewModel = gridViewModel;
		BindingContext = _gridViewModel;

        Title = "GridView";

		var childrenGrid1 = new Grid
		{
            ColumnDefinitions = Columns.Define(Star, Star,Star),
            RowDefinitions = Rows.Define(Star, Star, Star),
            Children =
            {
                new StackLayout {BackgroundColor = Colors.Red }.Row(0).Column(0),
                new StackLayout {BackgroundColor = Colors.Brown }.Row(1).Column(0),
                new StackLayout {BackgroundColor = Colors.BlueViolet }.Row(2).Column(0),

                new StackLayout {BackgroundColor = Colors.DarkGreen }.Row(0).Column(1),
                new StackLayout {BackgroundColor = Colors.Yellow }.Row(1).Column(1),
                new StackLayout {BackgroundColor = Colors.DarkKhaki }.Row(2).Column(1),

                new StackLayout {BackgroundColor = Colors.Black }.Row(0).Column(2),
                new StackLayout {BackgroundColor = Colors.RosyBrown }.Row(1).Column(2),
                new StackLayout {BackgroundColor = Colors.WhiteSmoke }.Row(2).Column(2),
            }
        };

		var parentGrid = new Grid
		{
			ColumnDefinitions = Columns.Define(Star, Star),
			RowDefinitions = Rows.Define(Star, Star),
            Children =
            {
                childrenGrid1.Row(0).Column(0),
                new StackLayout {BackgroundColor = Colors.LightGreen }.Row(0).Column(1),
                new Label().Text("Testing this great part...").Row(1).Column(0),
                new VerticalStackLayout { BackgroundColor = Colors.LightSteelBlue }.Row(1).Column(1)
            }
		};

        Content = parentGrid;

    }
}