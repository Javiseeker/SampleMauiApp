using CommunityToolkit.Maui.Markup;
using ViewModels;

namespace Views.Pages;

public class FromScratchView : ContentPage
{
	private readonly FromScratchViewModel _fromScratchViewModel;
	public FromScratchView(FromScratchViewModel fromScratchViewModel)
	{
		_fromScratchViewModel = fromScratchViewModel;
		BindingContext = _fromScratchViewModel;

		//var collectionView = new CollectionView().Bind();
		//collectionView.SetBinding()
		var dataTemplate = new DataTemplate()
		{
		
		};

        Content = new VerticalStackLayout
		{
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI FROM SCRATCH!!" },
				//new CollectionView {
				//}
			}
		};
	}
}