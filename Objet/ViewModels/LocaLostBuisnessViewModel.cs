using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.ComponentModel;
using System.Windows.Input;

namespace Objet.ViewModels
{
    public class LocaLostBuisnessViewModel : BaseViewModel
    {
        public string NomLieu { get; set; }
        public string DescriptionLieu { get; set; }
        public string CoordonneesGps { get; set; }
        public string SelectedEntreprise { get; set; }

        public DateTime DateDecouverte { get; set; } = DateTime.Now;
        public TimeSpan HeureDecouverte { get; set; } = DateTime.Now.TimeOfDay;
        public string SelectedCategorieObjet { get; set; }
        public string NomObjet { get; set; }
        public string NumeroObjet { get; set; }
        public string CouleurObjet { get; set; }
        public string DescriptionObjet { get; set; }

        public ICommand SaveLieuCommand { get; }
        public ICommand SaveObjetCommand { get; }
        public ICommand DeleteObjetCommand { get; }

        public LocaLostBuisnessViewModel(IDialogService dialogService, INavigationService navigationService)
            : base(dialogService, navigationService)
        {
            SaveLieuCommand = new Command(SaveLieu);
            SaveObjetCommand = new Command(SaveObjet);
            DeleteObjetCommand = new Command(DeleteObjet);
        }

        private void SaveLieu()
        {
            // Logique pour sauvegarder ou modifier le lieu
            Console.WriteLine("Lieu enregistré : " + NomLieu);
        }

        private void SaveObjet()
        {
            // Logique pour sauvegarder ou modifier l'objet trouvé
            Console.WriteLine("Objet trouvé enregistré : " + NomObjet);
        }

        private void DeleteObjet()
        {
            // Logique pour supprimer l'objet trouvé
            Console.WriteLine("Objet trouvé supprimé");
        }
    }
}
