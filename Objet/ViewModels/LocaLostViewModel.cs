using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Objet.ViewModels
{
    public partial class LocaLostViewModel(IDialogService dialogService, INavigationService navigationService)
            : BaseViewModel(dialogService, navigationService)
    {
        [RelayCommand]
        private async void ConnexionBuisnessAsync()
        {
            await NavigationService.GoToAsync(nameof(LoginBuisnessPage));
        }

        [RelayCommand]
        private void Quitter() => App.Current!.Quit();

        //private async void OnQuitterButtonClicked(object sender, EventArgs e)
        //{
        //    // Cette méthode permet de revenir à la page précédente
        //    Application.Current.Quit();
        //}
    }
}