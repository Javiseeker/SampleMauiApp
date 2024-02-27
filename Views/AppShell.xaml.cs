using Views.Pages;

namespace Views
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute($"{nameof(FromScratchView)}", typeof(FromScratchView));
        }
    }
}
