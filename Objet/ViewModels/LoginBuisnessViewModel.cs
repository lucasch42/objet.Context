using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace Objet.ViewModels
{
    public partial class LoginBuisnessViewModel(IDialogService dialogService, INavigationService navigationService)
            : BaseViewModel(dialogService, navigationService)
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty]
        private string _password;

        [RelayCommand]
        private async Task ConnexionAsync()
        {
            // Logique d'authentification
            var existingSalarie= await DbContext.Salaries
                .FirstOrDefaultAsync(d => d.Email == Email);

            if (existingSalarie == null || Password != existingSalarie.Motdepasse)
            {
                await DialogService.DisplayAlertAsync("Erreur", "Email ou mot de passe incorrect.", "OK");
                return;
            }

            // Efface les données utilisateurs
            DbContext.ChangeTracker.Clear();

            await DialogService.DisplayAlertAsync("Succès", "Connexion réussie.", "OK");

            // Redirection au questionnaire après authentification
            await NavigationService.GoToAsync(nameof(LocaLostBuisnessPage));
        }

    }
}
