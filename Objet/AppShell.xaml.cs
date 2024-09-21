namespace Objet
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            // Register the routes of the detail pages
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("newevent", typeof(NewEventPage));
            Routing.RegisterRoute(nameof(LocaLostBuisnessPage), typeof(LocaLostBuisnessPage));
            Routing.RegisterRoute(nameof(LoginBuisnessPage), typeof(LoginBuisnessPage));
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Current.GoToAsync("//login");
        }
    }
}
