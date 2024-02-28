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

        var onPushGesture = new TapGestureRecognizer();
        onPushGesture.Tapped += onPushBtnClick;

        var onPopGesture = new TapGestureRecognizer();
        onPopGesture.Tapped += onPopBtnClick;

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
                        new Button { Text="Stack Layout" },
                        new Button { Text="Horizontal Stack Layout" },
                        new Button { Text="Vertical Stack Layout" },
                        new Button { Text="Absolute Layout" },
                        new Button { Text="Flex Layout" },
                        new Button { Text="Grid" },
                    }
                    
				}.Center(),
                new HorizontalStackLayout
                {
                    Spacing = 20,
                    Children =
                    {
                        new Button { Text="Push", GestureRecognizers =
                            {
                                onPushGesture
                            }
                        },
                        new Button { Text="Pop", GestureRecognizers =
                            {
                                onPopGesture
                            }
                        }
                    }

                }.Center(),
                new Border {HeightRequest = 315, WidthRequest= 100,Content = collectionView.Margins(5,5,5,0)}.Center(),
                //new Border {HeightRequest = 315, WidthRequest= 100,Content = collectionView2.Margins(5,5,5,0)}.Center()

            }
        };
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