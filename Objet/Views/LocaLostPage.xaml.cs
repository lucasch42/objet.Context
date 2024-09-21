using System.Reflection;

namespace Objet.Views
{
    public partial class LocaLostPage : ContentPage
    {
        public LocaLostPage(LocaLostViewModel viewModel)
        {
            InitializeComponent();
        }
        //private async void LoginBuisness(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new LoginBuiness());
        //}

        private async void OnQuitterButtonClicked(object sender, EventArgs e)
        {
            // Cette méthode permet de revenir à la page précédente
            Application.Current.Quit();
        }
    }
}
