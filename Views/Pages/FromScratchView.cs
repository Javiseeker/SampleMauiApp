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

        var dataTemplate = new DataTemplate()
        {

        };

        var collectionView = new CollectionView();

		// MAUI native binding
		//collectionView.SetBinding();


		// Using Community ToolKit
		//collectionView.Bind();
        
		

        Content = new VerticalStackLayout
		{
			Spacing = 20,
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI FROM SCRATCH!!" },
				collectionView
			}
		};
	}

    protected override async void OnAppearing()
    {
		base.OnAppearing();
    }
    protected override void OnDisappearing()
    {

        base.OnDisappearing();
    }


}