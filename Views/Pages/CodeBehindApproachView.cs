using ViewModels;

namespace Views.Pages;

public class CodeBehindApproachView : ContentPage
{
    private readonly CodeBehindApproachViewModel _codeBehindApproachViewModel;

	public CodeBehindApproachView(CodeBehindApproachViewModel codeBehindApproachViewModel)
	{
		_codeBehindApproachViewModel = codeBehindApproachViewModel;
		BindingContext = _codeBehindApproachViewModel;

		var onTapGesture = new TapGestureRecognizer();
		onTapGesture.Tapped += onTapEvent;

		Content = new VerticalStackLayout
		{
			Spacing = 20,
			Children = {
				new Label { HorizontalOptions = LayoutOptions.Center, VerticalOptions = LayoutOptions.Center, Text = "Welcome to .NET MAUI!" },
				new Button { HorizontalOptions = LayoutOptions.Center, Text="Navigate to FromScratch", GestureRecognizers =
					{
						onTapGesture
					}
				}
			}
		};
	}

    private async void onTapEvent(object? sender, TappedEventArgs e)
    {
		await Shell.Current.GoToAsync($"{nameof(FromScratchView)}", true);
    }
}