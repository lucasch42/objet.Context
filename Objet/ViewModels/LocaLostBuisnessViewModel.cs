using objet.Context.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Objet.ViewModels
{
    public partial class LocaLostBuisnessViewModel : BaseViewModel
    {
        [ObservableProperty]
        private Lieu selectedLieu = new Lieu();

        public ObservableCollection<Entreprise> Entreprises { get; set; } = new ObservableCollection<Entreprise>();

        public LocaLostBuisnessViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            LoadEntreprisesAsync();
            SelectedLieu = new Lieu(); // Initialize a new Lieu or fetch an existing one depending on your app's flow
        }

        private async void LoadEntreprisesAsync()
        {
            var entreprises = await DbContext.Entreprises.ToListAsync();
            Entreprises = new ObservableCollection<Entreprise>(entreprises);
        }

        [RelayCommand]
        public async Task SaveLieuAsync()
        {
            if (SelectedLieu.Lieuxid == 0)
            {
                DbContext.Lieus.Add(SelectedLieu);
            }
            else
            {
                DbContext.Lieus.Update(SelectedLieu);
            }

            await DbContext.SaveChangesAsync();
        }
    }
}