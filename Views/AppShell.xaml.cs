using Views.Pages;

namespace Views
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute($"{nameof(FromScratchView)}", typeof(FromScratchView));
            Routing.RegisterRoute($"{nameof(FlexLayoutView)}", typeof(FlexLayoutView));
            Routing.RegisterRoute($"{nameof(StackLayoutView)}", typeof(StackLayoutView));
            Routing.RegisterRoute($"{nameof(HorizontalStackLayoutView)}", typeof(HorizontalStackLayoutView));
            Routing.RegisterRoute($"{nameof(VerticalStackLayoutView)}", typeof(VerticalStackLayoutView));
            Routing.RegisterRoute($"{nameof(AbsoluteLayoutView)}", typeof(AbsoluteLayoutView));
            Routing.RegisterRoute($"{nameof(GridView)}", typeof(GridView));
        }
    }
}
