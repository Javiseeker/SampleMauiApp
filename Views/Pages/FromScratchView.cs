using CommunityToolkit.Maui.Markup;
using Microsoft.Maui.Controls;
using System.Data;
using ViewModels;

namespace Views.Pages;

public class FromScratchView : ContentPage
{
	private readonly FromScratchViewModel _fromScratchViewModel;
	public FromScratchView(FromScratchViewModel fromScratchViewModel)
	{
		_fromScratchViewModel = fromScratchViewModel;
		BindingContext = _fromScratchViewModel;

        #region MAUI Native Data Binding with MVVM
        var collectionView = new CollectionView() { HeightRequest = 295 };

        collectionView.SetBinding(CollectionView.ItemsSourceProperty, "CollectionBindedNatively", BindingMode.Default);

        collectionView.ItemTemplate = new DataTemplate(() =>
        {
            var label = new Label() { Padding = new Thickness(20, 2, 0, 0) };
            label.SetBinding(Label.TextProperty, new Binding("."));
            return label;
        });
        #endregion

        #region MAUI Community Toolkit
        var collectionView2 = new CollectionView();
        collectionView2.Bind(CollectionView.ItemsSourceProperty, "CollectionBindedWithToolkit", BindingMode.Default);

        collectionView2.ItemTemplate = new DataTemplate(() =>
        {
            var label = new Label() { Padding = new Thickness(20, 2, 0, 0) };
            label.SetBinding(Label.TextProperty, new Binding("."));
            return label;
        });
        #endregion

        var pushGesture = new TapGestureRecognizer();
        pushGesture.Tapped += onPushBtnClick;

        var popGesture = new TapGestureRecognizer();
        popGesture.Tapped += onPopBtnClick;

        var stackLGesture = new TapGestureRecognizer();
        stackLGesture.Tapped += onTapEvent;

        var vStackLGesture = new TapGestureRecognizer();
        vStackLGesture.Tapped += onTapEvent;

        var hStackLGesture = new TapGestureRecognizer();
        hStackLGesture.Tapped += onTapEvent;

        var aSLayoutLGesture = new TapGestureRecognizer();
        aSLayoutLGesture.Tapped += onTapEvent;

        var flexLayoutGesture = new TapGestureRecognizer();
        flexLayoutGesture.Tapped += onTapEvent;

        var gridGesture = new TapGestureRecognizer();
        gridGesture.Tapped += onTapEvent;

        Content = new VerticalStackLayout
		{
			Spacing = 20,
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI FROM SCRATCH!!" },
				new HorizontalStackLayout
				{
					Spacing = 5,
					Children =
					{
                        new Button { Text="Stack Layout", GestureRecognizers = { stackLGesture } },
                        new Button { Text="Horizontal Stack Layout", GestureRecognizers = { hStackLGesture } },
                        new Button { Text="Vertical Stack Layout", GestureRecognizers = { vStackLGesture } },
                        new Button { Text="Absolute Layout", GestureRecognizers = { aSLayoutLGesture } },
                        new Button { Text="Flex Layout", GestureRecognizers = { flexLayoutGesture } },
                        new Button { Text="Grid", GestureRecognizers = { gridGesture } },
                    }
                    
				}.Center(),
                new HorizontalStackLayout
                {
                    Spacing = 20,
                    Children =
                    {
                        new Button { Text="Push", GestureRecognizers = { pushGesture } },
                        new Button { Text="Pop", GestureRecognizers = { popGesture } }
                    }

                }.Center(),
                new Border {HeightRequest = 315, WidthRequest= 100,Content = collectionView.Margins(5,5,5,0)}.Center(),
                //new Border {HeightRequest = 315, WidthRequest= 100,Content = collectionView2.Margins(5,5,5,0)}.Center()

            }
        };
	}

    private async void onTapEvent(object? sender, TappedEventArgs e)
    {
        var senderButton = sender as Button;

        switch (senderButton!.Text)
        {
            case "Vertical Stack Layout":

                await Shell.Current.GoToAsync($"{nameof(VerticalStackLayoutView)}", true);
                break;

            case "Horizontal Stack Layout":

                await Shell.Current.GoToAsync($"{nameof(HorizontalStackLayoutView)}", true);
                break;

            case "Stack Layout":

                await Shell.Current.GoToAsync($"{nameof(StackLayoutView)}", true);
                break;

            case "Flex Layout":

                await Shell.Current.GoToAsync($"{nameof(FlexLayoutView)}", true);
                break;
            case "Absolute Layout":

                await Shell.Current.GoToAsync($"{nameof(AbsoluteLayoutView)}", true);
                break;
            case "Grid":

                await Shell.Current.GoToAsync($"{nameof(GridView)}", true);
                break;
        }
    }

    private async void onPushBtnClick(object? sender, TappedEventArgs e)
    {
        await _fromScratchViewModel.PushToCV();
    }

    private async void onPopBtnClick(object? sender, TappedEventArgs e)
    {
        await _fromScratchViewModel.PopFromCV();
    }

    protected override async void OnAppearing()
    {
		base.OnAppearing();

		await _fromScratchViewModel.InitializeView();
    }
    protected override void OnDisappearing()
    {

        base.OnDisappearing();
    }


}