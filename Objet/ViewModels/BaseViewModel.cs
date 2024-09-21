using objet.Context.Models;

namespace Objet.ViewModels
{
    public partial class BaseViewModel(IDialogService dialogService, INavigationService navigationService) : ObservableObject
    {
        public static ObjetContext DbContext { get; set; } = new ObjetContext();

        public IDialogService DialogService => dialogService;

        public INavigationService NavigationService => navigationService;

        [ObservableProperty]
        private string _title = string.Empty;
    }
}
